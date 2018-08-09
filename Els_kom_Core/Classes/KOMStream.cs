// Copyright (c) 2014-2018, Els_kom org.
// https://github.com/Elskom/
// All rights reserved.
// license: MIT, see LICENSE for more details.

namespace Els_kom_Core.Classes
{
    /// <summary>
    /// KOM File format related stream.
    /// </summary>
    public class KOMStream : System.IO.Stream
    {
        /// <summary>
        /// Returns if the Stream can Read.
        /// </summary>
        public override bool CanRead => false;
        /// <summary>
        /// Returns if the Stream can Seek.
        /// </summary>
        public override bool CanSeek => false;
        /// <summary>
        /// Returns if the Stream can Write.
        /// </summary>
        public override bool CanWrite => false;
        /// <summary>
        /// Returns if the Stream can Timeout.
        /// </summary>
        public override bool CanTimeout => false;
        /// <summary>
        /// The length of the stream.
        /// Always 0 as no real stuff is supported.
        /// This is only to support extending this
        /// class for more kom plugins if needed.
        /// </summary>
        public override long Length => 0;
        /// <summary>
        /// Changes the KOMStream Position.
        /// </summary>
        public override long Position
        {
            get => 0;
            set => throw new System.NotImplementedException();
        }

        /// <summary>
        /// Creates a new KOM File format related stream.
        /// </summary>
        public KOMStream()
        {
        }

        /// <summary>
        /// Flushes the Stream. Does nothing really.
        /// </summary>
        public override void Flush()
        {
        }

        /// <summary>
        /// Reads specific amount of data from the Stream.
        /// Does nothing really.
        /// </summary>
        public override int Read(byte[] buffer, int offset, int count) => 0;

        /// <summary>
        /// The amount to seek to. Always at 0 as Seeks are not supported.
        /// </summary>
        public override long Seek(long offset, System.IO.SeekOrigin origin) => 0;

        /// <summary>
        /// Sets the length of the Stream.
        /// Does nothing really.
        /// </summary>
        /// <param name="value"></param>
        public override void SetLength(long value)
        {
        }

        /// <summary>
        /// Writes specific amount of data to the Stream.
        /// Does nothing really.
        /// </summary>
        public override void Write(byte[] buffer, int offset, int count)
        {
        }

        /// <summary>
        /// Writes the KOM File entry to file.
        /// </summary>
        public void WriteOutput(System.IO.BinaryReader reader, string out_path, EntryVer entry, int version, string xmldata, string KOMFileName)
        {
            if (version > 2)
            {
                if (!System.IO.Directory.Exists(out_path))
                {
                    System.IO.Directory.CreateDirectory(out_path);
                }
                var xmldatabuffer = System.Text.Encoding.ASCII.GetBytes(xmldata);
                if (!System.IO.File.Exists(out_path + System.IO.Path.DirectorySeparatorChar + "crc.xml"))
                {
                    var fs = System.IO.File.Create(out_path + System.IO.Path.DirectorySeparatorChar + "crc.xml");
                    fs.Write(xmldatabuffer, 0, xmldatabuffer.Length);
                    fs.Dispose();
                }
                var entrydata = reader.ReadBytes(entry.compressed_size);
                if (entry.algorithm == 0)
                {
                    var failure = false;
                    var entryfile = System.IO.File.Create(out_path + "\\" + entry.name);
                    try
                    {
                        ZlibHelper.DecompressData(entrydata, out var dec_entrydata);
                        entryfile.Write(dec_entrydata, 0, entry.uncompressed_size);
                    }
                    catch (System.ArgumentException)
                    {
                        throw new UnpackingError("Something failed...");
                    }
                    catch (Zlib.ZStreamException)
                    {
                        throw new UnpackingError("decompression failed...");
                    }
                    entryfile.Dispose();
                    if (failure)
                    {
                        System.IO.File.Move(out_path + "\\" + entry.name, out_path + "\\" + entry.name + "." + entry.uncompressed_size + "." + entry.algorithm);
                    }
                }
                else
                {
                    System.IO.FileStream entryfile;
                    if (entrydata.Length == entry.uncompressed_size)
                    {
                        entryfile = System.IO.File.Create(out_path + "\\" + entry.name);
                    }
                    else
                    {
                        // data was not decompressed properly so lets just dump it as is.
                        entryfile = System.IO.File.Create(out_path + "\\" + entry.name + "." + entry.uncompressed_size + "." + entry.algorithm);
                    }
#if VERSION_0x01050000
                    byte[] dec_entrydata = null;
                    var failure = false;
                    if (entry.algorithm == 3)
                    {
                        // algorithm 3 code.
                        byte[] zdec_entrydata = null;
                        try
                        {
                            ZlibHelper.DecompressData(entrydata, out zdec_entrydata);
                        }
                        catch (System.ArgumentException)
                        {
                            throw new UnpackingError("Something failed...");
                        }
                        catch (Zlib.ZStreamException)
                        {
                            throw new UnpackingError("decompression failed...");
                        }
                        // Decrypt the data from a encryption plugin.
                        KOMManager.encryptionplugins[0].DecryptEntry(zdec_entrydata, out dec_entrydata, SafeNativeMethods.GetFileBaseName(KOMFileName), entry.algorithm);
                    }
                    else
                    {
                        // algorithm 2 code.
                        // Decrypt the data from a encryption plugin.
                        KOMManager.encryptionplugins[0].DecryptEntry(entrydata, out byte[] decr_entrydata, SafeNativeMethods.GetFileBaseName(KOMFileName), entry.algorithm);
                        try
                        {
                            ZlibHelper.DecompressData(decr_entrydata, out dec_entrydata);
                        }
                        catch (System.ArgumentException)
                        {
                            throw new UnpackingError("Something failed...");
                        }
                        catch (Zlib.ZStreamException)
                        {
                            throw new UnpackingError("decompression failed...");
                        }
                    }
                    entryfile.Write(dec_entrydata, 0, entry.uncompressed_size);
                    entryfile.Dispose();
                    if (failure)
                    {
                        System.IO.File.Move(out_path + "\\" + entry.name, out_path + "\\" + entry.name + "." + entry.uncompressed_size + "." + entry.algorithm);
                    }
#else
                    if (entry.algorithm == 3)
                    {
                        // algorithm 3 code.
                    }
                    else
                    {
                        // algorithm 2 code.
                    }
                    // for now until I can decompress this crap.
                    entryfile.Write(entrydata, 0, entry.compressed_size);
                    entryfile.Dispose();
#endif
                }
            }
            else
            {
                // Write KOM V2 output to file.
                if (!System.IO.Directory.Exists(out_path))
                {
                    System.IO.Directory.CreateDirectory(out_path);
                }
                var entrydata = reader.ReadBytes(entry.compressed_size);
                var entryfile = System.IO.File.Create(out_path + "\\" + entry.name);
                byte[] dec_entrydata;
                try
                {
                    ZlibHelper.DecompressData(entrydata, out dec_entrydata);
                }
                catch (Zlib.ZStreamException)
                {
                    // copyright symbols... Really funny xor key...
                    var xorkey = System.Text.Encoding.UTF8.GetBytes("\xa9\xa9\xa9\xa9\xa9\xa9\xa9\xa9\xa9\xa9");
                    // xor this shit then try again...
                    BlowFish.XorBlock(ref entrydata, xorkey);
                    try
                    {
                        ZlibHelper.DecompressData(entrydata, out dec_entrydata);
                        System.IO.File.Create(out_path + "\\XoRNeeded.dummy").Dispose();
                    }
                    catch (Zlib.ZStreamException)
                    {
                        throw new UnpackingError("failed with zlib decompression of entries.");
                    }
                }
                entryfile.Write(dec_entrydata, 0, entry.uncompressed_size);
                entryfile.Dispose();
            }
        }

        /// <summary>
        /// Closes the Stream.
        /// </summary>
        public override void Close()
        {
        }

        internal int GetCRCVersion(string xmldata)
        {
            var xml = System.Xml.Linq.XElement.Parse(xmldata);
            if (xml.Element("File") != null)
            {
                // version 3 or 4.
                foreach (var fileElement in xml.Elements("File"))
                {
                    var MappedIDAttribute = fileElement.Attribute("MappedID");
                    return MappedIDAttribute != null ? 4 : 3;
                }
            }
            else
            {
                return 2;
            }
            return 0;
        }

        /// <summary>
        /// Converts the KOM crc.xml file to the provided version,
        /// if it is not already that version.
        /// </summary>
        public void ConvertCRC(int toVersion, string crcpath)
        {
            if (System.IO.File.Exists(crcpath))
            {
                var crcversion = GetCRCVersion(System.Text.Encoding.ASCII.GetString(System.IO.File.ReadAllBytes(crcpath)));
                if (crcversion != toVersion)
                {
                    foreach (var plugin in KOMManager.komplugins)
                    {
                        if (toVersion == plugin.SupportedKOMVersion)
                        {
                            plugin.ConvertCRC(crcversion, crcpath);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Updates the crc.xml file if the folder has new files
        /// not in the crc.xml, or removes files listed in crc.xml that are
        /// no longer in the folder.
        /// </summary>
        public void UpdateCRC(int crcversion, string crcpath, string checkpath)
        {
            var crcfile = new System.IO.FileInfo(crcpath);
            var di1 = new System.IO.DirectoryInfo(checkpath);
            foreach (var fi1 in di1.GetFiles())
            {
                if (!fi1.Name.Equals(crcfile.Name))
                {
                    var found = false;
                    // lookup the file entry in the crc.xml.
                    var xmldata = System.Text.Encoding.UTF8.GetString(
                       System.IO.File.ReadAllBytes(crcpath));
                    var xml = System.Xml.Linq.XElement.Parse(xmldata);
                    if (crcversion > 2)
                    {
                        foreach (var fileElement in xml.Elements("File"))
                        {
                            var nameAttribute = fileElement.Attribute("Name");
                            var name = nameAttribute?.Value ?? "no value";
                            if (name.Equals(fi1.Name))
                            {
                                found = true;
                            }
                        }
                    }
                    else
                    {
                        // TODO: Iterate through every entry in the kom v2 crc.xml file.
                    }
                    if (!found)
                    {
                        foreach (var plugin in KOMManager.komplugins)
                        {
                            if (crcversion == plugin.SupportedKOMVersion)
                            {
                                plugin.UpdateCRC(crcpath, checkpath);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Disposes the Stream.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
        }
    }
}
