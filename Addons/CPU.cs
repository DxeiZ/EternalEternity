using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace EternalEternity.Addons
{
    public class CPU
    {
        public string Name { get; set; }
        public UInt32 Cores { get; set; }
        public UInt32 LogicalCpus { get; set; }
    }

    public class CPUInfo
    {
        public CPUInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                foreach (ManagementObject mo in searcher.Get())
                {
                    CPU cpu = new CPU();

                    cpu.Name = Convert.ToString(mo.Properties["Name"].Value);
                    cpu.Cores = Convert.ToUInt32(mo.Properties["NumberOfCores"].Value);
                    cpu.LogicalCpus = Convert.ToUInt32(mo.Properties["NumberOfLogicalProcessors"].Value);

                    if (string.IsNullOrEmpty(cpu.Name)) cpu.Name = GetCPUNameAlternative();

                    CPUs.Add(cpu);
                }
            }
            catch { }
        }

        public List<CPU> CPUs = new List<CPU>();

        private string GetCPUNameAlternative()
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\CentralProcessor\0", false))
            {
                return key.GetValue("ProcessorNameString").ToString();
            }
        }
    }
    }
