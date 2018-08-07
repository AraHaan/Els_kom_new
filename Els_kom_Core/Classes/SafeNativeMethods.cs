// Copyright (c) 2014-2018, Els_kom org.
// https://github.com/Elskom/
// All rights reserved.
// license: MIT, see LICENSE for more details.

namespace Els_kom_Core.Classes
{
    internal static class SafeNativeMethods
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true, EntryPoint = "FindResourceW")]
        internal static extern System.IntPtr FindResourceW(System.IntPtr hModule, System.IntPtr lpName, System.IntPtr lpType);
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true, EntryPoint = "SizeofResource")]
        internal static extern uint SizeofResource(System.IntPtr hModule, System.IntPtr hResInfo);
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true, EntryPoint = "LoadResource")]
        internal static extern System.IntPtr LoadResource(System.IntPtr hModule, System.IntPtr hResInfo);
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true, EntryPoint = "LockResource")]
        internal static extern System.IntPtr LockResource(System.IntPtr hResData);
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        internal static extern System.IntPtr LoadImage(System.IntPtr hInst, string lpszName, uint uType, int cxDesired, int cyDesired, uint fuLoad);
        [System.Runtime.InteropServices.DllImport("dbghelp.dll")]
        internal static extern bool MiniDumpWriteDump(System.IntPtr hProcess, int ProcessId, System.IntPtr hFile, Enums.MINIDUMP_TYPE DumpType, ref structs.MINIDUMP_EXCEPTION_INFORMATION ExceptionParam, System.IntPtr UserStreamParam, System.IntPtr CallackParam);

        private static string GetFileBaseName(string FileName)
        {
            var fi = new System.IO.FileInfo(FileName);
            // return file base name without path to file.
            return fi.Name;
        }

        /// <summary>
        /// Loads an Icon Error Checked.
        /// </summary>
        internal static System.Drawing.Icon _LoadIconErrorChecked(string resource, int Width, int Height)
        {
            var error = 0;
            System.Drawing.Icon retIcon = null;
            var hIcon = System.IntPtr.Zero;
            System.Reflection.Module hMod = null;
            try
            {
                hMod = System.Reflection.Assembly.GetEntryAssembly().GetModules()[0];
            }
            catch (System.Exception)
            {
            }
            if (hMod != null)
            {
                var hProc = System.Runtime.InteropServices.Marshal.GetHINSTANCE(hMod);
                hIcon = LoadImage(hProc, resource, (uint)Enums.LoadImageTypes.IMAGE_ICON, Width, Height, (uint)Enums.LoadImagefuLoad.LR_SHARED);
                error = System.Runtime.InteropServices.Marshal.GetLastWin32Error();
                if (error == 0 && hIcon != System.IntPtr.Zero)
                {
                    var iconold = System.Drawing.Icon.FromHandle(hIcon);
                    retIcon = new System.Drawing.Icon(iconold, Width, Height);
                }
            }
            else
            {
                // Forms Designer hack.
                // Load from a *.resx if it exists, otherwise make one.
                var iconfiles = new string[] {
                    ResourcesDir.iconpath,
                    ResourcesDir.iconpath.Replace("els_kom", "YR"),
                    ResourcesDir.iconpath.Replace("els_kom", "VP_Trans")
                };
                var iconfile = string.Empty;
                if (resource.Equals("#1"))
                {
                    iconfile = iconfiles[0];
                }
                else if (resource.Equals("#2"))
                {
                    iconfile = iconfiles[1];
                }
                else if (resource.Equals("#3"))
                {
                    iconfile = iconfiles[2];
                }
                if (!System.IO.File.Exists(ResourcesDir.resourcespath))
                {
                    var resx = new System.Resources.ResXResourceWriter(ResourcesDir.resourcespath);
                    foreach (var iconFile in iconfiles)
                    {
                        var iconstream = new System.IO.MemoryStream(System.IO.File.ReadAllBytes(iconFile));
                        var icon2Dump = new System.Drawing.Icon(iconstream);
                        resx.AddResource(GetFileBaseName(iconFile).Trim(".ico".ToCharArray()), icon2Dump);
                        icon2Dump.Dispose();
                    }
                    // write resource file.
                    resx.Dispose();
                }
                // now read it.
                var resxSet = new System.Resources.ResXResourceSet(ResourcesDir.resourcespath);
                // hopefully this works.
                var iconold = (System.Drawing.Icon)resxSet.GetObject(GetFileBaseName(iconfile).Trim(".ico".ToCharArray()));
                retIcon = new System.Drawing.Icon(iconold, Width, Height);
                hIcon = retIcon.Handle;
                resxSet.Dispose();
            }
            if (hIcon == System.IntPtr.Zero)
            {
                MessageManager.ShowError("LoadImage returned Error Code: " + error + ".", "Error!");
            }
            return retIcon;
        }
    }
}
