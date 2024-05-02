using EternalEternity;
using EternalEternity.Addons;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * 
 * Author: DxeiZ
 * Github: @DxeiZ
 * 
 */

namespace DxSystemControl
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            CPUInfo cpuInfo = new CPUInfo();
            RAMInfo ramInfo = new RAMInfo();
            MotherboardInfo motherboardInfo = new MotherboardInfo();
            GPUInfo gpuInfo = new GPUInfo();
            StorageInfo storageInfo = new StorageInfo();
            AudioInfo audioInfo = new AudioInfo();
            BIOSInfo biosInfo = new BIOSInfo();

            #region İşletim sistemi bilgisi
            string sysType = Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit";
            getOS.Text = $"{OS.GetOS()} {sysType}";
            #endregion
            #region CPU bilgisi
            CPU cpu = cpuInfo.CPUs.FirstOrDefault();
            if (cpu != null)
            {
                getCPU.Text = $"{cpu.Name} (Çekirdekler: {cpu.Cores}, Mantıksal İşlemciler: {cpu.LogicalCpus})";
            }
            #endregion
            #region RAM bilgisi
            StringBuilder ramText = new StringBuilder();
            foreach (RAM ram in ramInfo.RAMs)
            {
                ramText.AppendLine($"{ram.Manufacturer} {ram.Capacity}@{ram.Speed}MHz");
            }
            getRAM.Text = ramText.ToString();
            #endregion
            #region Anakart bilgisi
            Motherboard motherboard = motherboardInfo.Boards.FirstOrDefault();
            if (motherboard != null)
            {
                getMotherboard.Text = motherboard.Manufacturer;
            }
            #endregion
            #region GPU bilgisi
            StringBuilder gpuText = new StringBuilder();
            foreach (GPU gpu in gpuInfo.GPUs)
            {
                gpuText.AppendLine($"{gpu.Name} ({gpu.Memory})");
            }
            getGPU.Text = gpuText.ToString();
            #endregion
            #region Depolama bilgisi
            StringBuilder storageText = new StringBuilder();
            foreach (Disk disk in storageInfo.Disks)
            {
                if (disk.Capacity.Bytes != 0)
                {
                    storageText.AppendLine($"{disk.Model} ({disk.Capacity})");
                }
            }
            getStorage.Text = storageText.ToString();
            #endregion
            #region BIOS bilgisi
            getBIOS.Text = biosInfo != null ? $"{biosInfo.Manufacturer} {biosInfo.Name}" : "BIOS tespit edilemedi";
            #endregion
            #region Ses cihazı bilgisi
            StringBuilder audioText = new StringBuilder();
            foreach (AudioDevice device in audioInfo.AudioDevices)
            {
                audioText.AppendLine(device.ProductName);
            }
            getAudio.Text = audioText.ToString();
            #endregion
        }

        private void systemControlBtn_Click(object sender, EventArgs e) { Hide(); new System_Management().Show(); }
    }
}
