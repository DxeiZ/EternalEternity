using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using System.Text;
using DxSystemControl;

/*
 * 
 * Author: DxeiZ
 * Github: @DxeiZ
 * 
 */

namespace EternalEternity
{
    public partial class System_Management : Form
    {
        #region Main
        public System_Management() => InitializeComponent();
        private void System_Management_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        private void System_Management_Load(object sender, EventArgs e) => timer1.Start();
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateMemoryInfo();
            UpdatePowerInfo();
        }

        private string GetFormattedSize(ulong size) => $"{size / 1024.0 / 1024.0 / 1024.0:F2} GB";
        private void ıconButton3_Click(object sender, EventArgs e) { Hide(); new Main().Show(); }
        #endregion
        #region Audio Control
        [DllImport("user32")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private const int WM_APPCOMMAND = 0x319;
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;


        private void VolumeMuteOn()
        {
            SendAppCommand(APPCOMMAND_VOLUME_UP);
            SendAppCommand(APPCOMMAND_VOLUME_DOWN);
            SendAppCommand(APPCOMMAND_VOLUME_MUTE);
        }

        private void VolumeMuteOff()
        {
            SendAppCommand(APPCOMMAND_VOLUME_UP);
            SendAppCommand(APPCOMMAND_VOLUME_DOWN);
        }

        private void VolumeUp()
        {
            SendAppCommand(APPCOMMAND_VOLUME_UP);
        }

        private void VolumeDown()
        {
            SendAppCommand(APPCOMMAND_VOLUME_DOWN);
        }

        private void SendAppCommand(int nCommand)
        {
            IntPtr hWnd = this.Handle;
            SendMessage(hWnd, WM_APPCOMMAND, hWnd, (IntPtr)nCommand);
        }

        private void volumeOn_Click(object sender, EventArgs e)
        {
            VolumeMuteOff();
        }

        private void volumeOff_Click(object sender, EventArgs e)
        {
            VolumeMuteOn();
        }

        private void volumeAdd_Click(object sender, EventArgs e)
        {
            VolumeUp();
        }

        private void volumeDell_Click(object sender, EventArgs e)
        {
            VolumeDown();
        }
        #endregion
        #region DVD Control
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        public static extern int dvdDoorOpen(string icerik, StringBuilder durum, int deger, IntPtr neKadar);

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        public static extern int dvdDoorClose(string icerik, StringBuilder durum, int deger, IntPtr neKadar);


        private void dvdOpen_Click(object sender, EventArgs e)
        {
            dvdDoorOpen("Set cdaudio door open wait ", null, 0, IntPtr.Zero);
        }

        private void dvdClose_Click(object sender, EventArgs e)
        {
            dvdDoorOpen("Set cdaudio door Closed wait ", null, 0, IntPtr.Zero);
        }
        #endregion
        #region MessageBox Control
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);


        private void msgBox_Click(object sender, EventArgs e)
        {
            MessageBox((IntPtr)0, siticoneTextBox1.Text, "Eternal Eternity | Message Box", 0);
        }
        #endregion
        #region Empty Recycle Control
        [DllImport("Shell32.dll")]
        static extern int SHEmptyRecycleBin(IntPtr hWnd, string pszRootPath, uint dwFlags);

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            const uint SHERB_NOCONFIRMATION = 0x00000000;
            SHEmptyRecycleBin(IntPtr.Zero, null, SHERB_NOCONFIRMATION);
        }
        #endregion
        #region HDD Status
        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORYSTATUSEX
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public ulong ullTotalPhys;
            public ulong ullAvailPhys;
            public ulong ullTotalPageFile;
            public ulong ullAvailPageFile;
            public ulong ullTotalVirtual;
            public ulong ullAvailVirtual;
            public ulong ullAvailExtendedVirtual;

            public MEMORYSTATUSEX(uint dummy)
            {
                dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
                dwMemoryLoad = 0;
                ullTotalPhys = 0;
                ullAvailPhys = 0;
                ullTotalPageFile = 0;
                ullAvailPageFile = 0;
                ullTotalVirtual = 0;
                ullAvailVirtual = 0;
                ullAvailExtendedVirtual = 0;
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GlobalMemoryStatusEx(ref MEMORYSTATUSEX lpBuffer);

        private void UpdateMemoryInfo()
        {
            MEMORYSTATUSEX memStatus = new MEMORYSTATUSEX(0);
            if (GlobalMemoryStatusEx(ref memStatus))
            {
                siticoneProgressBar1.Value = (int)memStatus.dwMemoryLoad;
                siticoneLabel1.Text = $"{memStatus.dwMemoryLoad}%";

                siticoneTextBox2.Text = $"Toplam bellek miktarı: {GetFormattedSize(memStatus.ullTotalPhys)}";
                siticoneTextBox3.Text = $"Boş bellek miktarı: {GetFormattedSize(memStatus.ullAvailPhys)}";
                siticoneTextBox4.Text = $"Toplam page file miktarı: {GetFormattedSize(memStatus.ullTotalPageFile)}";
                siticoneTextBox5.Text = $"Boş page file miktarı: {GetFormattedSize(memStatus.ullAvailPageFile)}";
                siticoneTextBox6.Text = $"Toplam sanal bellek miktarı: {GetFormattedSize(memStatus.ullTotalVirtual)}";
                siticoneTextBox7.Text = $"Boş sanal bellek miktarı: {GetFormattedSize(memStatus.ullAvailVirtual)}";
            }
        }
        #endregion
        #region Batery Status
        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_POWER_STATUS
        {
            public byte ACLineStatus;
            public byte BatteryFlag;
            public byte BatteryLifePercent;
            public byte Reserved1;
            public uint BatteryLifeTime;
            public uint BatteryFullLifeTime;
        }

        [DllImport("kernel32.dll")]
        public static extern bool GetSystemPowerStatus(out SYSTEM_POWER_STATUS status);

        static string GetBatteryStatus(byte batteryFlag)
        {
            switch (batteryFlag)
            {
                case 1:
                    return "Şarj Ediliyor";
                case 2:
                    return "Deşarj Ediliyor";
                case 4:
                    return "Şarj Edilmiyor";
                case 8:
                    return "Yüksek Gerilim";
                case 128:
                    return "Şarj Ediliyor";
                default:
                    return "Bilinmeyen Durum";
            }
        }

        private string secToDate(int seconds)
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);

            string output = "";
            if (timeSpan.TotalSeconds < 0 && timeSpan.Days == 0 && timeSpan.Hours == 0 && timeSpan.Minutes == 0)
            {
                output = "1000 yıldan fazla";
            }
            else
            {
                if (timeSpan.Days >= 365)
                {
                    int years = timeSpan.Days / 365;
                    output += years + " yıl, ";
                }

                if (timeSpan.Days % 365 >= 30)
                {
                    int months = (timeSpan.Days % 365) / 30;
                    output += months + " ay, ";
                }

                if (timeSpan.Days % 30 > 0)
                {
                    int days = timeSpan.Days % 30;
                    output += days + " gün, ";
                }


                output += timeSpan.Hours + " saat, ";
                output += timeSpan.Minutes + " dakika, ";
                output += timeSpan.Seconds + " saniye";

                output = output.Trim().TrimEnd(',');
            }

            return output;
        }
        private void UpdatePowerInfo()
        {
            SYSTEM_POWER_STATUS status;
            if (GetSystemPowerStatus(out status))
            {
                siticoneProgressBar2.Value = status.BatteryLifePercent;
                siticoneLabel2.Text = $"{status.BatteryLifePercent}%";

                siticoneTextBox13.Text = $"AC Bağlantısı Durumu: {(status.ACLineStatus == 1 ? "Bağlı" : "Bağlı Değil")}";
                siticoneTextBox11.Text = $"Batarya Durumu: {GetBatteryStatus(status.BatteryFlag)}";
                siticoneTextBox9.Text = $"Kalan Pil Ömrü: {secToDate((int)status.BatteryLifeTime)}";
                siticoneTextBox8.Text = $"Tam Pil Ömrü: {secToDate((int)status.BatteryFullLifeTime)}";
            }
        }
        #endregion
    }
}