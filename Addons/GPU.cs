using System;
using System.Collections.Generic;
using System.Management;

namespace EternalEternity.Addons
{
    public class GPU
    {
        public string Name { get; set; }
        public ByteSize Memory { get; set; }
    }

    public class GPUInfo
    {
        public GPUInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
                foreach (ManagementObject mo in searcher.Get())
                {
                    GPU gpu = new GPU();
                    gpu.Name = Convert.ToString(mo.Properties["Name"].Value);
                    gpu.Memory = ByteSize.FromBytes(Convert.ToDouble(mo.Properties["AdapterRAM"].Value));

                    GPUs.Add(gpu);
                }
            }
            catch { }
        }

        public List<GPU> GPUs = new List<GPU>();
    }
}
