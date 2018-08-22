// Copyright (c) 2014-2018, Els_kom org.
// https://github.com/Elskom/
// All rights reserved.
// license: MIT, see LICENSE for more details.

namespace Els_kom_Core.Classes
{
    /// <summary>
    /// This Class holds all the KOM entry Information.
    /// </summary>
    public class EntryVer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntryVer"/> class for unpacking files from KOM V2.
        /// </summary>
        /// <param name="name">The Entry file name.</param>
        /// <param name="uncompressed_size">The original file size.</param>
        /// <param name="compressed_size">The current, compressed file size.</param>
        /// <param name="relative_offset">The relative offset of the entry file.</param>
        public EntryVer(string name, int uncompressed_size, int compressed_size, int relative_offset)
        {
            this.Version = 2;
            this.Name = name;
            this.Uncompressed_size = uncompressed_size;
            this.Compressed_size = compressed_size;
            this.Relative_offset = relative_offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntryVer"/> class for packing files to KOM V2.
        /// </summary>
        /// <param name="entrydata">The input file data that is to be compressed.</param>
        /// <param name="name">The Entry file name.</param>
        /// <param name="uncompressed_size">The current, file size.</param>
        /// <param name="compressed_size">The target, compressed file size.</param>
        /// <param name="relative_offset">The relative offset of the entry file.</param>
        public EntryVer(byte[] entrydata, string name, int uncompressed_size, int compressed_size, int relative_offset)
        {
            this.Version = 2;
            this.Entrydata = entrydata;
            this.Name = name;
            this.Uncompressed_size = uncompressed_size;
            this.Compressed_size = compressed_size;
            this.Relative_offset = relative_offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntryVer"/> class unpacking files from KOM V3.
        /// </summary>
        /// <param name="name">The Entry file name.</param>
        /// <param name="uncompressed_size">The original file size.</param>
        /// <param name="compressed_size">The current, compressed file size.</param>
        /// <param name="checksum">The input file crc32 checksum.</param>
        /// <param name="file_time">The input file time.</param>
        /// <param name="algorithm">The input file's compression algorithm.</param>
        public EntryVer(string name, int uncompressed_size, int compressed_size, int checksum, int file_time, int algorithm)
        {
            this.Version = 3;
            this.Name = name;
            this.Uncompressed_size = uncompressed_size;
            this.Compressed_size = compressed_size;
            this.Checksum = checksum;
            this.File_time = file_time;
            this.Algorithm = algorithm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntryVer"/> class for packing files to KOM V3.
        /// </summary>
        /// <param name="entrydata">The input file data that is to be compressed.</param>
        /// <param name="name">The Entry file name.</param>
        /// <param name="uncompressed_size">The current, file size.</param>
        /// <param name="compressed_size">The target, compressed file size.</param>
        /// <param name="checksum">The input file crc32 checksum.</param>
        /// <param name="file_time">The input file time.</param>
        /// <param name="algorithm">The input file's compression algorithm.</param>
        public EntryVer(byte[] entrydata, string name, int uncompressed_size, int compressed_size, int checksum, int file_time, int algorithm)
        {
            this.Version = 3;
            this.Entrydata = entrydata;
            this.Name = name;
            this.Uncompressed_size = uncompressed_size;
            this.Compressed_size = compressed_size;
            this.Checksum = checksum;
            this.File_time = file_time;
            this.Algorithm = algorithm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntryVer"/> class for unpacking files from KOM V4.
        /// </summary>
        /// <param name="name">The Entry file name.</param>
        /// <param name="uncompressed_size">The original file size.</param>
        /// <param name="compressed_size">The current, compressed file size.</param>
        /// <param name="checksum">The input file crc32 checksum.</param>
        /// <param name="file_time">The input file time.</param>
        /// <param name="algorithm">The input file's compression algorithm.</param>
        /// <param name="mappedID">The input file's mapped id.</param>
        public EntryVer(string name, int uncompressed_size, int compressed_size, int checksum, int file_time, int algorithm, string mappedID)
        {
            this.Version = 4;
            this.Name = name;
            this.Uncompressed_size = uncompressed_size;
            this.Compressed_size = compressed_size;
            this.Checksum = checksum;
            this.File_time = file_time;
            this.Algorithm = algorithm;
            this.MappedID = mappedID;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntryVer"/> class for packing files to KOM V4.
        /// </summary>
        /// <param name="entrydata">The input file data that is to be compressed.</param>
        /// <param name="name">The Entry file name.</param>
        /// <param name="uncompressed_size">The current, file size.</param>
        /// <param name="compressed_size">The target, compressed file size.</param>
        /// <param name="checksum">The input file crc32 checksum.</param>
        /// <param name="file_time">The input file time.</param>
        /// <param name="algorithm">The input file's compression algorithm.</param>
        /// <param name="mappedID">The input file's mapped id.</param>
        public EntryVer(byte[] entrydata, string name, int uncompressed_size, int compressed_size, int checksum, int file_time, int algorithm, string mappedID)
        {
            this.Version = 4;
            this.Entrydata = entrydata;
            this.Name = name;
            this.Uncompressed_size = uncompressed_size;
            this.Compressed_size = compressed_size;
            this.Checksum = checksum;
            this.File_time = file_time;
            this.Algorithm = algorithm;
            this.MappedID = mappedID;
        }

        /// <summary>
        /// Gets the entry File name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the entry unpacked size.
        /// </summary>
        public int Uncompressed_size { get; private set; }

        /// <summary>
        /// Gets the entry Compressed Size.
        /// </summary>
        public int Compressed_size { get; private set; }

        /// <summary>
        /// Gets the entry Relative offset.
        /// </summary>
        public int Relative_offset { get; private set; }

        /// <summary>
        /// Gets entry file data for packing.
        /// </summary>
        public byte[] Entrydata { get; private set; }

        // KOM V3 Members.

        /// <summary>
        /// Gets entry Checksum.
        /// </summary>
        public int Checksum { get; private set; }

        /// <summary>
        /// Gets entry File time.
        /// </summary>
        public int File_time { get; private set; }

        /// <summary>
        /// Gets entry Algorithm.
        /// </summary>
        public int Algorithm { get; private set; }

        // KOM V4 Members.

        /// <summary>
        /// Gets entry Mapped ID.
        /// </summary>
        public string MappedID { get; private set; }

        /// <summary>
        /// Gets entry KOM Version number.
        /// </summary>
        internal int Version { get; private set; }
    }
}
