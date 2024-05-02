using System;
using System.Collections.Generic;
using System.Management;

namespace EternalEternity.Addons
{
    public class RAM
    {
        public uint Speed { get; set; }
        public ByteSize Capacity { get; set; }
        public string Manufacturer { get; set; }
    }

    public class RAMInfo
    {
        public RAMInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
                foreach (ManagementObject mo in searcher.Get())
                {
                    RAM ram = new RAM();

                    ram.Speed = Convert.ToUInt32(mo.Properties["Speed"].Value);
                    ram.Capacity = ByteSize.FromBytes(Convert.ToDouble(mo.Properties["Capacity"].Value));
                    ram.Manufacturer = mo.Properties["Manufacturer"].Value?.ToString();

                    RAMs.Add(ram);
                }
            }
            catch { }
        }

        public List<RAM> RAMs { get; set; } = new List<RAM>();
    }
}
