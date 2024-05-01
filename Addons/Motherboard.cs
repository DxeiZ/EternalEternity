using System;
using System.Collections.Generic;
using System.Management;

namespace EternalEternity.Addons
{
    public class Motherboard { public string Manufacturer { get; set; } }
    public class MotherboardInfo
    {
        public MotherboardInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
                foreach (ManagementObject managementObject in searcher.Get())
                {
                    Motherboard motherboard = new Motherboard();
                    motherboard.Manufacturer = Convert.ToString(managementObject.Properties["Manufacturer"].Value);

                    Boards.Add(motherboard);
                }
            }
            catch { }
        }

        public List<Motherboard> Boards = new List<Motherboard>();
    }
}
