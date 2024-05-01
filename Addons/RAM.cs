using System;
using System.Collections.Generic;
using System.Management;

namespace EternalEternity.Addons
{
    public class RAM
    {
        public ByteSize Capacity { get; set; }
        public UInt32 Speed { get; set; }
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
                    RAM module = new RAM();

                    module.Capacity = ByteSize.FromBytes(Convert.ToDouble(mo.Properties["Capacity"].Value));
                    module.Speed = Convert.ToUInt32(mo.Properties["Speed"].Value);

                    Modules.Add(module);
                }
            }
            catch { }
        }
        public List<RAM> Modules = new List<RAM>();
    }
}
