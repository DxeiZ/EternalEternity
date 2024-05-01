using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EternalEternity.Addons
{
    public static class OS
    {
        public static void CopyToClipboard(string text)
        {
            try
            {
                Clipboard.SetText(text);
            }
            catch { }
        }

        public static void GoogleSearch(string term)
        {
            try
            {
                Process.Start("https://google.com/#q=" + term);
            }
            catch { }
        }

        public static string GetOS()
        {
            return (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductName", "");
        }

        public static string GetBitness()
        {
            string bitness = "";

            if (Environment.Is64BitOperatingSystem)
            {
                bitness = "You are working with 64-bit architecture";
            }
            else
            {
                bitness = "You are working with 32-bit architecture";
            }

            return bitness;
        }
    }
}
