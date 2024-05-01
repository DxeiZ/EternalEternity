using EternalEternity;
using EternalEternity.Addons;
using System;
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
        string sysType;
        ByteSize temp = new ByteSize();
        uint memorySpeed;

        public Main()
        {
            InitializeComponent();

            if (Environment.Is64BitOperatingSystem) sysType = "64-bit";
            else sysType = "32-bit";
            label1.Text = $"{OS.GetOS()} {sysType}";

            CPUInfo cpuInfo = new CPUInfo();
            RAMInfo ramInfo = new RAMInfo();
            MotherboardInfo motherboardInfo = new MotherboardInfo();
            GPUInfo gpuInfo = new GPUInfo();
            StorageInfo storageInfo = new StorageInfo();
            AudioInfo audioInfo = new AudioInfo();
            BIOSInfo biosInfo = new BIOSInfo();

            foreach (CPU cpu in cpuInfo.CPUs)
            {
                label2.Text = $"{cpu.Name} (Çekirdekler: {cpu.Cores}, Mantıksal İşlemciler: {cpu.LogicalCpus})";
            }

            foreach (RAM ram in ramInfo.Modules)
            {
                temp += ram.Capacity;
                memorySpeed += ram.Speed;
            }
            label3.Text = $"{temp} @ {memorySpeed}Hmz";

            foreach (Motherboard mobo in motherboardInfo.Boards)
            {
                label4.Text = mobo.Manufacturer;
            }

            label5.Text = "";
            foreach (GPU gpu in gpuInfo.GPUs)
            {
                label5.Text += $"{gpu.Name} ({gpu.Memory}){Environment.NewLine}";
            }

            foreach (Disk disk in storageInfo.Disks)
            {
                if (disk.Capacity.ToString() != "b")
                {
                    label6.Text = $"{disk.Model} ({disk.Capacity})";
                }
                else
                {
                    label6.Text = disk.Model;
                }
            }

            if (biosInfo != null)
            {
                label7.Text = $"{biosInfo.Manufacturer} {biosInfo.Name}";
            }
            else
            {
                label7.Text = $"BIOS tespit edilemedi";
            }

            foreach (AudioDevice device in audioInfo.AudioDevices)
            {
                label8.Text = device.ProductName;
            }
        }

        private void ıconButton1_Click(object sender, EventArgs e) { Hide(); new System_Management().Show(); }
    }
}
