using memory;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FS22Companion
{
    public partial class Menu : Form
    {
        long globalArray = 0;

        public Dictionary<int, string> Seasons = new Dictionary<int, string>() 
        {
            { 0, "Spring" },
            { 1, "Summer" },
            { 2, "Autumn" },
            { 3, "Winter" }
        };

        bool right = false;
        bool left = true;

        public Menu()
        {
            InitializeComponent();
            //groupBox1.Paint += GroupBox_Paint;
            //groupBox2.Paint += GroupBox_Paint;
            //groupBox3.Paint += GroupBox_Paint;

            if (Process.GetProcessesByName(processName).Length > 0)
            {
                process = Process.GetProcessesByName(processName)[0];

                // FS is open
                globalArray = GetGlobalArray();

                Thread.Sleep(1000); // Give some time so that the game runs the injected code

                // Manage Money
                var moneyAddress = ReadInt64(globalArray);
                var money = (int)ReadDouble(moneyAddress);
                moneyTextBox.Text = money.ToString();

                setMoneyButton.Click += (sender, e) =>
                {
                    long newMoney;
                    if(Int64.TryParse(moneyTextBox.Text, out newMoney))
                    {
                        if (newMoney > 99999999) newMoney = 99999999;
                        IntPtr bytesWritten;
                        byte[] buffer = BitConverter.GetBytes((double)newMoney);
                        WriteProcessMemory(process.Handle, moneyAddress, buffer, buffer.Length, out bytesWritten);
                        money = (int)ReadDouble(moneyAddress);
                        moneyTextBox.Text = money.ToString();
                    }
                    else
                    {
                        CustomMessageBox.Show("Value was too large", MessageBoxButtons.OK);
                    }
                };
                addMoneyButton.Click += (sender, e) =>
                {
                    long newMoney;
                    if (Int64.TryParse(moneyTextBox.Text, out newMoney))
                    {
                        newMoney = money + newMoney;
                        if (newMoney > 99999999) newMoney = 99999999;
                        IntPtr bytesWritten;
                        byte[] buffer = BitConverter.GetBytes((double)newMoney);
                        WriteProcessMemory(process.Handle, moneyAddress, buffer, buffer.Length, out bytesWritten);
                        money = (int)ReadDouble(moneyAddress);
                        moneyTextBox.Text = money.ToString();
                    }
                    else
                    {
                        CustomMessageBox.Show("Value was too large", MessageBoxButtons.OK);
                    }
                };
                removeMoneyButton.Click += (sender, e) =>
                {
                    long newMoney;
                    if (Int64.TryParse(moneyTextBox.Text, out newMoney))
                    {
                        newMoney = money - newMoney;
                        if (newMoney > 99999999) newMoney = 99999999;
                        IntPtr bytesWritten;
                        byte[] buffer = BitConverter.GetBytes((double)newMoney);
                        WriteProcessMemory(process.Handle, moneyAddress, buffer, buffer.Length, out bytesWritten);
                        money = (int)ReadDouble(moneyAddress);
                        moneyTextBox.Text = money.ToString();
                    }
                    else
                    {
                        CustomMessageBox.Show("Value was too large", MessageBoxButtons.OK);
                    }
                };

                // Month
                var currentMonthAddress = ReadInt64(globalArray + 0x88);
                var currentMonth = (int)ReadDouble(currentMonthAddress) + 1;
                if (currentMonth >= 12)
                    monthComboBox.SelectedIndex = currentMonth - 12;
                else
                    monthComboBox.SelectedIndex = currentMonth;

                monthComboBox.SelectedIndexChanged += (sender, e) =>
                {
                    var newMonth = (double)monthComboBox.SelectedIndex - 1;
                    IntPtr bytesWritten;
                    byte[] buffer = BitConverter.GetBytes(newMonth);
                    WriteProcessMemory(process.Handle, currentMonthAddress, buffer, buffer.Length, out bytesWritten);
                    currentMonth = (int)ReadDouble(currentMonthAddress) + 1;
                    if (currentMonth >= 12)
                        monthComboBox.SelectedIndex = currentMonth - 12;
                    else
                        monthComboBox.SelectedIndex = currentMonth;
                };

                // Season
                var currentSeasonAddress = ReadInt64(globalArray + 0x18);
                seasonComboBox.SelectedIndex = (int)ReadDouble(currentSeasonAddress);

                seasonComboBox.SelectedIndexChanged += (sender, e) =>
                {
                    var newSeason = (double)seasonComboBox.SelectedIndex;
                    IntPtr bytesWritten;
                    byte[] buffer = BitConverter.GetBytes(newSeason);
                    WriteProcessMemory(process.Handle, currentSeasonAddress, buffer, buffer.Length, out bytesWritten);
                    seasonComboBox.SelectedIndex = (int)ReadDouble(currentSeasonAddress);
                };

                // Time
                var timeScaleAddress = ReadInt64(globalArray + 0x8);
                var timeScale = ReadDouble(timeScaleAddress);
                timeScaleTextBox.Text = timeScale.ToString();

                var currentTimeAddress = ReadInt64(globalArray + 0x10);
                var currentTime = ReadDouble(currentTimeAddress);
                currentTimeTextBox.Text = ConvertTime((int)currentTime);

                setTimeScaleButton.Click += (sender, e) =>
                {
                    var newTimeScale = (double)Int32.Parse(timeScaleTextBox.Text);
                    IntPtr bytesWritten;
                    byte[] buffer = BitConverter.GetBytes(newTimeScale);
                    WriteProcessMemory(process.Handle, timeScaleAddress, buffer, buffer.Length, out bytesWritten);
                    timeScale = ReadDouble(timeScaleAddress);
                    timeScaleTextBox.Text = timeScale.ToString();
                };

                setTimeButton.Click += (sender, e) =>
                {
                    var newTime = (double)ConvertTimeReverse(currentTimeTextBox.Text);
                    IntPtr bytesWritten;
                    byte[] buffer = BitConverter.GetBytes(newTime);
                    WriteProcessMemory(process.Handle, currentTimeAddress, buffer, buffer.Length, out bytesWritten);
                    currentTime = ReadDouble(currentTimeAddress);
                    currentTimeTextBox.Text = ConvertTime((int)currentTime);
                };


                // We need to stop updating the textboxes if the value is being updated
                timer.Tick += (sender, e) =>
                {
                    if(!moneyTextBox.Focused)
                    {
                        money = (int)ReadDouble(moneyAddress);
                        moneyTextBox.Text = money.ToString();
                    }

                    if(!seasonComboBox.Focused)
                    {
                        seasonComboBox.SelectedIndex = (int)ReadDouble(currentSeasonAddress);
                    }

                    if (!timeScaleTextBox.Focused)
                    {
                        timeScale = ReadDouble(timeScaleAddress);
                        timeScaleTextBox.Text = timeScale.ToString();
                    }

                    if (!currentTimeTextBox.Focused)
                    {
                        currentTime = ReadDouble(currentTimeAddress);
                        currentTimeTextBox.Text = ConvertTime((int)currentTime);
                    }
                };



                // GPS
                var playerRotAddress = ReadInt64(globalArray + 0xA0);
                var isInVehicleAddress = ReadInt64(globalArray + 0x98);
                var axisSideAddress = ReadInt64(globalArray + 0x90);
                bool GPSactive = false;
                double direction;
                bool previousIsInVehicle = false;
                bool isInVehicle = false;

                activateGPSButton.Click += (sender, e) =>
                {
                    GPSactive = true;
                };

                deactivateGPSButton.Click += (sender, e) =>
                {
                    GPSactive = false;
                };

                isInVehicleTimer.Tick += (sender, e) =>
                {
                    isInVehicle = ReadBinary(isInVehicleAddress) != 255;
                    if (previousIsInVehicle != isInVehicle)
                    {
                        if (isInVehicle)
                        {
                            isInVehicleButton.Text = "In Vehicle";
                            isInVehicleButton.FillColor = Color.LimeGreen;
                            DisableScript();
                            globalArray = GetGlobalArray();
                        }
                        else
                        {
                            isInVehicleButton.Text = "Not In Vehicle";
                            isInVehicleButton.FillColor = Color.Red;
                        }
                        previousIsInVehicle = isInVehicle;
                    }
                    if (GPSactive)
                    {
                        gpsActiveButton.Text = "GPS Active";
                        gpsActiveButton.FillColor = Color.LimeGreen;
                    }
                    else 
                    {
                        gpsActiveButton.Text = "GPS not Active";
                        gpsActiveButton.FillColor = Color.Red;
                    }
                };

                gpsTimer.Tick += (sender, e) =>
                {
                    if (isInVehicle)
                    {
                        direction = (ReadDouble(playerRotAddress) * 180 / 3.14159) % 360; // normalize the angle
                        if (direction < 0) direction = -direction;                            // normalize the angle
                        direction = 360 - direction;
                        directionLabel.Text = "Current Direction: " + (direction).ToString("0.0") + "º";

                        axisSideAddress = ReadInt64(globalArray + 0x90);

                        if(GPSactive)
                        {
                            var GPSDirection = Double.Parse(directionTextBox.Text);

                            if (GPSDirection != direction)
                            {
                                if(GPSDirection > direction && GPSDirection - direction <= 180)
                                {
                                    // Steer right
                                    steer(right, axisSideAddress, GPSDirection, direction);
                                }
                                else if (GPSDirection < direction && GPSDirection - direction <= 180)
                                {
                                    // Steer Left
                                    steer(left, axisSideAddress, GPSDirection, direction);
                                }
                                else if (GPSDirection > direction && GPSDirection - direction >= 180)
                                {
                                    // Steer left
                                    steer(left, axisSideAddress, GPSDirection, direction);
                                }
                                else if (GPSDirection < direction && GPSDirection - direction >= 180)
                                {
                                    // Steer right
                                    steer(right, axisSideAddress, GPSDirection, direction);
                                }
                            }
                        }
                    }
                };


            }
            else
            {
                if (CustomMessageBox.Show("FS22 not detected or not running", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    //Environment.Exit(0);
                }
            }

        }

        public void steer(bool left, long axisSideAddress, double GPSDirection, double direction)
        {
            if((direction >= 359.9 || direction <= 0.1) && (System.Math.Abs(GPSDirection - direction) <= 0.5 || (359.9 <= System.Math.Abs(GPSDirection - direction) && System.Math.Abs(GPSDirection - direction) <= 360.0)))
            {
                // Don't steer
            }
            else if (System.Math.Abs(GPSDirection - direction) <= 0.1)
            {
                var steerPercentage = 0.02;
                if (left) steerPercentage = -0.02;
                IntPtr bytesWritten;
                byte[] buffer = BitConverter.GetBytes(steerPercentage);
                WriteProcessMemory(process.Handle, axisSideAddress, buffer, buffer.Length, out bytesWritten);
            }
            else if (System.Math.Abs(GPSDirection - direction) <= 0.5)
            {
                var steerPercentage = 0.04;
                if (left) steerPercentage = -0.04;
                IntPtr bytesWritten;
                byte[] buffer = BitConverter.GetBytes(steerPercentage);
                WriteProcessMemory(process.Handle, axisSideAddress, buffer, buffer.Length, out bytesWritten);
            }
            else if (System.Math.Abs(GPSDirection - direction) <= 1.0)
            {
                var steerPercentage = 0.08;
                if (left) steerPercentage = -0.08;
                IntPtr bytesWritten;
                byte[] buffer = BitConverter.GetBytes(steerPercentage);
                WriteProcessMemory(process.Handle, axisSideAddress, buffer, buffer.Length, out bytesWritten);
            }
            else if (System.Math.Abs(GPSDirection - direction) <= 5.0)
            {
                var steerPercentage = 0.16;
                if (left) steerPercentage = -0.16;
                IntPtr bytesWritten;
                byte[] buffer = BitConverter.GetBytes(steerPercentage);
                WriteProcessMemory(process.Handle, axisSideAddress, buffer, buffer.Length, out bytesWritten);
            }
            else
            {
                var steerPercentage = 0.8;
                if (left) steerPercentage = -0.8;
                IntPtr bytesWritten;
                byte[] buffer = BitConverter.GetBytes(steerPercentage);
                WriteProcessMemory(process.Handle, axisSideAddress, buffer, buffer.Length, out bytesWritten);
            }
        }

        #region Extras
        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left + 3, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        public string ConvertTime(int time)
        {
            var hours = time / 3600000;
            var minutes = (time / 60000) - hours * 60;

            return hours.ToString() + ":" + minutes.ToString("00");
        }

        public int ConvertTimeReverse(string timeStr)
        {
            var array = timeStr.Split(':');
            return Int32.Parse(array[0]) * 3600000 + Int32.Parse(array[1]) * 60000;
        }

        #endregion

        #region DLLImports
        [DllImport("kernel32.dll")]
        protected static extern bool ReadProcessMemory(
        IntPtr hProcess,
        Int64 lpBaseAddress,
        byte[] lpBuffer,
        int dwSize,
        out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        protected static extern bool WriteProcessMemory(
        IntPtr hProcess,
        Int64 lpBaseAddress,
        byte[] lpBuffer,
        int dwSize,
        out IntPtr lpNumberOfBytesWritten);


        public int ReadInteger(long BaseAddress)
        {
            IntPtr bytesRead;
            byte[] buffer = new byte[4];
            ReadProcessMemory(process.Handle, BaseAddress, buffer, buffer.Length, out bytesRead);
            return BitConverter.ToInt32(buffer, 0);
        }
        public long ReadInt64(long BaseAddress)
        {
            IntPtr bytesRead;
            byte[] buffer = new byte[8];
            ReadProcessMemory(process.Handle, BaseAddress, buffer, buffer.Length, out bytesRead);
            return BitConverter.ToInt64(buffer, 0);
        }
        public float ReadFloat(long BaseAddress)
        {
            IntPtr bytesRead;
            byte[] buffer = new byte[4];
            ReadProcessMemory(process.Handle, BaseAddress, buffer, buffer.Length, out bytesRead);
            return BitConverter.ToSingle(buffer, 0);
        }
        public double ReadDouble(long BaseAddress)
        {
            IntPtr bytesRead;
            byte[] buffer = new byte[8];
            ReadProcessMemory(process.Handle, BaseAddress, buffer, buffer.Length, out bytesRead);
            return BitConverter.ToDouble(buffer, 0);
        }
        public string ReadString(long BaseAddress)
        {
            IntPtr bytesRead;
            byte[] buffer = new byte[8];
            ReadProcessMemory(process.Handle, BaseAddress, buffer, buffer.Length, out bytesRead);
            return BitConverter.ToString(buffer, 0);
        }
        public byte ReadBinary(long BaseAddress)
        {
            IntPtr bytesRead;
            byte[] buffer = new byte[1];
            ReadProcessMemory(process.Handle, BaseAddress, buffer, buffer.Length, out bytesRead);
            return buffer[0];
        }


        public void AllocNearAddr(IntPtr processHandle, out long Address, int Size, long nearAddr)
        {
            //MemoryAPI.SYSTEM_INFO SI = new MemoryAPI.SYSTEM_INFO();
            //MemoryAPI.GetSystemInfo(ref SI);
            long maxAddress = nearAddr + 0x7FFF0000;
            long currentAddress = nearAddr - 0x7FFF0000;

            MemoryAPI.MEMORY_BASIC_INFORMATION mem_basic_info = new MemoryAPI.MEMORY_BASIC_INFORMATION();

            while (currentAddress < maxAddress)
            {
                MemoryAPI.VirtualQueryEx(processHandle, (IntPtr)currentAddress, out mem_basic_info, Marshal.SizeOf(typeof(MemoryAPI.MEMORY_BASIC_INFORMATION)));
                string addressStr = currentAddress.ToString("X");
                if (addressStr.Length > 3)
                {
                    if (mem_basic_info.State == MemoryAPI.AllocType.Free && addressStr.Substring(addressStr.Length - 3) == "000")
                    {
                        //MessageBox.Show(currentAddress.ToString("X"));
                        currentAddress = Addr.RoundToNearest64KMultiple(currentAddress);
                        // We now need to check if the resulting address is free or not
                        MemoryAPI.VirtualQueryEx(processHandle, (IntPtr)currentAddress, out mem_basic_info, Marshal.SizeOf(typeof(MemoryAPI.MEMORY_BASIC_INFORMATION)));
                        if (mem_basic_info.State == MemoryAPI.AllocType.Free)
                            break;
                    }
                }
                currentAddress = (long)mem_basic_info.BaseAddress + (long)mem_basic_info.RegionSize;
            }

            //MessageBox.Show(currentAddress.ToString("X"));

            Address = MemoryAPI.VirtualAllocEx(processHandle, (IntPtr)currentAddress, Size, MemoryAPI.AllocType.Commit | MemoryAPI.AllocType.Reserve, MemoryAPI.Protect.ExecuteReadWrite);

            //MessageBox.Show(Address.ToString("X"));
        }

        public bool Dealloc(IntPtr processHandle, long Addr)
        {
            var success = MemoryAPI.VirtualFreeEx(processHandle, (IntPtr)Addr, 0, MemoryAPI.FreeType.Release);
            return success;
        }
        #endregion

        #region GetGlobalArray

        public static string processName = "FarmingSimulator2022Game";
        Process process;
        long baseAddress = 0;
        public long newmem = 0;

        public long GetGlobalArray()
        {
            long globalArray = 0;

            //Scanner Obj = new Scanner(process, process.Handle, "4D 8B 1A 49 83 FB FF");
            //Obj.setModule(process.MainModule);
            //baseAddress = (long)Obj.FindPattern();

            baseAddress = (long)process.MainModule.BaseAddress + 0x8EDD2;

            AllocNearAddr(process.Handle, out newmem, 0x2000, baseAddress);
            globalArray = newmem + 0x1000;

            if(newmem == 0 || baseAddress == 0)
            {
                CustomMessageBox.Show("Failed to execute the script", MessageBoxButtons.OK);
                return 0;
            }

            long ad1 = baseAddress; // get_Base
            long ad2 = newmem; // newmem

            // get_Base:
            byte[] bv1 = Jmp(ad2, ad1, false, true, false); // jmp newmem nop 2

            // newmem:
            byte[] bv2 = {
                0x51,
                0x81, 0x3D, 0x59, 0x10, 0x00, 0x00, 0x01, 0x01, 0x01, 0x01,
                0x0F, 0x84, 0x04, 0x01, 0x00, 0x00,
                0x80, 0x3D, 0x4C, 0x10, 0x00, 0x00, 0x01,
                0x0F, 0x84, 0x2A, 0x00, 0x00, 0x00,
                0x48, 0xB9, 0x6D, 0x6F, 0x6E, 0x65, 0x79, 0x00, 0x00, 0x00,
                0x48, 0x39, 0x48, 0x18,
                0x0F, 0x85, 0x16, 0x00, 0x00, 0x00,
                0xC6, 0x05, 0x2B, 0x10, 0x00, 0x00, 0x01,
                0x49, 0xBB, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0xE9, 0x1C, 0x04, 0x00, 0x00,
                0x80, 0x3D, 0x16, 0x10, 0x00, 0x00, 0x01,
                0x0F, 0x84, 0x3E, 0x00, 0x00, 0x00,
                0x48, 0xB9, 0x74, 0x69, 0x6D, 0x65, 0x53, 0x63, 0x61, 0x6C,
                0x48, 0x39, 0x48, 0x18,
                0x0F, 0x85, 0x2A, 0x00, 0x00, 0x00,
                0x48, 0xB9, 0x65, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x48, 0x39, 0x48, 0x20,
                0x0F, 0x85, 0x16, 0x00, 0x00, 0x00,
                0xC6, 0x05, 0xE1, 0x0F, 0x00, 0x00, 0x01,
                0x49, 0xBB, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0xE9, 0xD1, 0x03, 0x00, 0x00,
                0x80, 0x3D, 0xCC, 0x0F, 0x00, 0x00, 0x01,
                0x0F, 0x84, 0x2A, 0x00, 0x00, 0x00,
                0x48, 0xB9, 0x64, 0x61, 0x79, 0x54, 0x69, 0x6D, 0x65, 0x00,
                0x48, 0x39, 0x48, 0x18,
                0x0F, 0x85, 0x16, 0x00, 0x00, 0x00,
                0xC6, 0x05, 0xAB, 0x0F, 0x00, 0x00, 0x01,
                0x49, 0xBB, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0xE9, 0x9A, 0x03, 0x00, 0x00,
                0x80, 0x3D, 0x96, 0x0F, 0x00, 0x00, 0x01,
                0x0F, 0x84, 0x3E, 0x00, 0x00, 0x00,
                0x48, 0xB9, 0x63, 0x75, 0x72, 0x72, 0x65, 0x6E, 0x74, 0x53,
                0x48, 0x39, 0x48, 0x18,
                0x0F, 0x85, 0x2A, 0x00, 0x00, 0x00,
                0x48, 0xB9, 0x65, 0x61, 0x73, 0x6F, 0x6E, 0x00, 0x00, 0x00,
                0x48, 0x39, 0x48, 0x20,
                0x0F, 0x85, 0x16, 0x00, 0x00, 0x00,
                0xC6, 0x05, 0x61, 0x0F, 0x00, 0x00, 0x01,
                0x49, 0xBB, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0xE9, 0x4F, 0x03, 0x00, 0x00,
                0x81, 0x3D, 0x49, 0x0F, 0x00, 0x00, 0x01, 0x01, 0x01, 0x01,
                0x0F, 0x84, 0x39, 0x03, 0x00, 0x00,
                0x80, 0x3D, 0x3C, 0x0F, 0x00, 0x00, 0x01,
                0x0F, 0x84, 0x3E, 0x00, 0x00, 0x00,
                0x48, 0xB9, 0x6D, 0x61, 0x78, 0x52, 0x75, 0x6E, 0x6E, 0x69,
                0x48, 0x39, 0x48, 0x18,
                0x0F, 0x85, 0x2A, 0x00, 0x00, 0x00,
                0x48, 0xB9, 0x6E, 0x67, 0x53, 0x70, 0x65, 0x65, 0x64, 0x00,
                0x48, 0x39, 0x48, 0x20,
                0x0F, 0x85, 0x16, 0x00, 0x00, 0x00,
                0xC6, 0x05, 0x07, 0x0F, 0x00, 0x00, 0x01,
                0x49, 0xBB, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0xE9, 0xF4, 0x02, 0x00, 0x00,
                0x80, 0x3D, 0xF2, 0x0E, 0x00, 0x00, 0x01,
                0x0F, 0x84, 0x3E, 0x00, 0x00, 0x00,
                0x48, 0xB9, 0x6D, 0x61, 0x78, 0x57, 0x61, 0x6C, 0x6B, 0x69,
                0x48, 0x39, 0x48, 0x18,
                0x0F, 0x85, 0x2A, 0x00, 0x00, 0x00,
                0x48, 0xB9, 0x6E, 0x67, 0x53, 0x70, 0x65, 0x65, 0x64, 0x00,
                0x48, 0x39, 0x48, 0x20,
                0x0F, 0x85, 0x16, 0x00, 0x00, 0x00,
                0xC6, 0x05, 0xBD, 0x0E, 0x00, 0x00, 0x01,
                0x49, 0xBB, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0xE9, 0xA9, 0x02, 0x00, 0x00,
                0x80, 0x3D, 0xA8, 0x0E, 0x00, 0x00, 0x01,
                0x0F, 0x84, 0x3E, 0x00, 0x00, 0x00,
                0x48, 0xB9, 0x6A, 0x75, 0x6D, 0x70, 0x48, 0x65, 0x69, 0x67,
                0x48, 0x39, 0x48, 0x18,
                0x0F, 0x85, 0x2A, 0x00, 0x00, 0x00,
                0x48, 0xB9, 0x68, 0x74, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x48, 0x39, 0x48, 0x20,
                0x0F, 0x85, 0x16, 0x00, 0x00, 0x00,
                0xC6, 0x05, 0x73, 0x0E, 0x00, 0x00, 0x01,
                0x49, 0xBB, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0xE9, 0x5E, 0x02, 0x00, 0x00,
                0x80, 0x3D, 0x5E, 0x0E, 0x00, 0x00, 0x01,
                0x0F, 0x84, 0x3E, 0x00, 0x00, 0x00,
                0x48, 0xB9, 0x73, 0x75, 0x6E, 0x48, 0x65, 0x69, 0x67, 0x68,
                0x48, 0x39, 0x48, 0x18,
                0x0F, 0x85, 0x2A, 0x00, 0x00, 0x00,
                0x48, 0xB9, 0x74, 0x41, 0x6E, 0x67, 0x6C, 0x65, 0x00, 0x00,
                0x48, 0x39, 0x48, 0x20,
                0x0F, 0x85, 0x16, 0x00, 0x00, 0x00,
                0xC6, 0x05, 0x29, 0x0E, 0x00, 0x00, 0x01,
                0x49, 0xBB, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0xE9, 0x13, 0x02, 0x00, 0x00, 
                0x80, 0x3D, 0x14, 0x0E, 0x00, 0x00, 0x01, 
                0x0F, 0x84, 0x3E, 0x00, 0x00, 0x00, 
                0x48, 0xB9, 0x74, 0x61, 0x72, 0x67, 0x65, 0x74, 0x50, 0x6F, 
                0x48, 0x39, 0x48, 0x18, 
                0x0F, 0x85, 0x2A, 0x00, 0x00, 0x00, 
                0x48, 0xB9, 0x73, 0x69, 0x74, 0x69, 0x6F, 0x6E, 0x58, 0x00, 
                0x48, 0x39, 0x48, 0x20, 
                0x0F, 0x85, 0x16, 0x00, 0x00, 0x00, 
                0xC6, 0x05, 0xDF, 0x0D, 0x00, 0x00, 0x01, 
                0x49, 0xBB, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
                0xE9, 0xC8, 0x01, 0x00, 0x00, 
                0x80, 0x3D, 0xCB, 0x0D, 0x00, 0x00, 0x01, 
                0x0F, 0x84, 0x3E, 0x00, 0x00, 0x00,
                0x48, 0xB9, 0x74, 0x61, 0x72, 0x67, 0x65, 0x74, 0x50, 0x6F, 
                0x48, 0x39, 0x48, 0x18, 
                0x0F, 0x85, 0x2A, 0x00, 0x00, 0x00, 
                0x48, 0xB9, 0x73, 0x69, 0x74, 0x69, 0x6F, 0x6E, 0x59, 0x00, 
                0x48, 0x39, 0x48, 0x20, 
                0x0F, 0x85, 0x16, 0x00, 0x00, 0x00, 
                0xC6, 0x05, 0x96, 0x0D, 0x00, 0x00, 0x01, 
                0x49, 0xBB, 0x09, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
                0xE9, 0x7D, 0x01, 0x00, 0x00, 
                0x80, 0x3D, 0x81, 0x0D, 0x00, 0x00, 0x01, 
                0x0F, 0x84, 0x3E, 0x00, 0x00, 0x00, 
                0x48, 0xB9, 0x74, 0x61, 0x72, 0x67, 0x65, 0x74, 0x50, 0x6F, 
                0x48, 0x39, 0x48, 0x18, 
                0x0F, 0x85, 0x2A, 0x00, 0x00, 0x00, 
                0x48, 0xB9, 0x73, 0x69, 0x74, 0x69, 0x6F, 0x6E, 0x5A, 0x00, 
                0x48, 0x39, 0x48, 0x20, 
                0x0F, 0x85, 0x16, 0x00, 0x00, 0x00, 
                0xC6, 0x05, 0x4C, 0x0D, 0x00, 0x00, 0x01, 
                0x49, 0xBB, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
                0xE9, 0x32, 0x01, 0x00, 0x00, 
                0x80, 0x3D, 0x37, 0x0D, 0x00, 0x00, 0x01, 
                0x0F, 0x84, 0x3E, 0x00, 0x00, 0x00, 
                0x48, 0xB9, 0x63, 0x75, 0x72, 0x72, 0x65, 0x6E, 0x74, 0x50, 
                0x48, 0x39, 0x48, 0x18, 
                0x0F, 0x85, 0x2A, 0x00, 0x00, 0x00, 
                0x48, 0xB9, 0x65, 0x72, 0x69, 0x6F, 0x64, 0x00, 0x00, 0x00, 
                0x48, 0x39, 0x48, 0x20, 
                0x0F, 0x85, 0x16, 0x00, 0x00, 0x00, 
                0xC6, 0x05, 0x02, 0x0D, 0x00, 0x00, 0x01, 
                0x49, 0xBB, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
                0xE9, 0xE7, 0x00, 0x00, 0x00, 
                0x80, 0x3D, 0xED, 0x0C, 0x00, 0x00, 0x01, 
                0x0F, 0x84, 0x2A, 0x00, 0x00, 0x00, 
                0x48, 0xB9, 0x61, 0x78, 0x69, 0x73, 0x53, 0x69, 0x64, 0x65, 
                0x48, 0x39, 0x48, 0x18, 
                0x0F, 0x85, 0x16, 0x00, 0x00, 0x00, 
                0xC6, 0x05, 0xCC, 0x0C, 0x00, 0x00, 0x01, 
                0x49, 0xBB, 0x12, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
                0xE9, 0xB0, 0x00, 0x00, 0x00, 
                0x80, 0x3D, 0xB7, 0x0C, 0x00, 0x00, 0x01, 
                0x0F, 0x84, 0x52, 0x00, 0x00, 0x00, 
                0x48, 0xB9, 0x63, 0x6F, 0x6E, 0x74, 0x72, 0x6F, 0x6C, 0x6C, 
                0x48, 0x39, 0x48, 0x18, 
                0x0F, 0x85, 0x3E, 0x00, 0x00, 0x00, 
                0x48, 0xB9, 0x65, 0x64, 0x56, 0x65, 0x68, 0x69, 0x63, 0x6C, 
                0x48, 0x39, 0x48, 0x20, 
                0x0F, 0x85, 0x2A, 0x00, 0x00, 0x00, 
                0x48, 0xB9, 0x65, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
                0x48, 0x39, 0x48, 0x28, 
                0x0F, 0x85, 0x16, 0x00, 0x00, 0x00, 
                0xC6, 0x05, 0x6E, 0x0C, 0x00, 0x00, 0x01, 
                0x49, 0xBB, 0x13, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0xE9, 0x51, 0x00, 0x00, 0x00, 
                0x80, 0x3D, 0x59, 0x0C, 0x00, 0x00, 0x01, 
                0x0F, 0x84, 0x3E, 0x00, 0x00, 0x00, 
                0x48, 0xB9, 0x70, 0x6C, 0x61, 0x79, 0x65, 0x72, 0x52, 0x6F, 
                0x48, 0x39, 0x48, 0x18, 
                0x0F, 0x85, 0x2A, 0x00, 0x00, 0x00, 
                0x48, 0xB9, 0x74, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
                0x48, 0x39, 0x48, 0x20, 
                0x0F, 0x85, 0x16, 0x00, 0x00, 0x00, 
                0xC6, 0x05, 0x24, 0x0C, 0x00, 0x00, 0x01, 
                0x49, 0xBB, 0x14, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0xE9, 0x06, 0x00, 0x00, 0x00, 
                0x59,                             // BLOCK 3 
                0xE9, 0x1E, 0x00, 0x00, 0x00, 
                //0x48, 0xB9, 0x00, 0x10, 0x85, 0x61, 0xF6, 0x7F, 0x00, 0x00, // 48 B9 00 10 *96* 61 F6 7F 00 00 - substituted below
            };

            var dump = "0000" + globalArray.ToString("X") + "B948";

            if (dump.Length == 19) // Make sure we have 10 bytes
                dump = "0" + dump;

            byte[] hex = new byte[dump.Length / 2];
            for (int i = 0; i < hex.Length; i++)
            {
                hex[i] = Convert.ToByte(dump.Substring(i * 2, 2), 16); //Set each byte to 2 chars
            }
            Array.Reverse(hex);

            byte[] bv3 = hex;

            byte[] bv4 = {
                0x4E, 0x8D, 0x1C, 0xDD, 0x00, 0x00, 0x00, 0x00,
                0x4C, 0x01, 0xD9,
                0x4C, 0x89, 0x11,
                0x59,
                0xE9, 0x00, 0x00, 0x00, 0x00,
                0x4D, 0x8B, 0x1A,
                0x49, 0x83, 0xFB, 0xFF,
                //0xE9, 0x58, 0xEB, 0x1A, 0x00 }; // E9 58 EB *09* 00 - instead of this, use the Jmp() method
            };

            byte[] bv5 = Jmp(ad1 + 0x7, ad2 + 0x489, false, false, false); 

            byte[] bv2Merge = new byte[bv2.Length + bv3.Length + bv4.Length + bv5.Length]; // merge all byte arrays
            System.Buffer.BlockCopy(bv2, 0, bv2Merge, 0, bv2.Length);
            System.Buffer.BlockCopy(bv3, 0, bv2Merge, bv2.Length, bv3.Length);
            System.Buffer.BlockCopy(bv4, 0, bv2Merge, bv2.Length + bv3.Length, bv4.Length);
            System.Buffer.BlockCopy(bv5, 0, bv2Merge, bv2.Length + bv3.Length + bv4.Length, bv5.Length);

            IntPtr bytes1;
            IntPtr bytes2;

            WriteProcessMemory(process.Handle, ad2, bv2Merge, bv2Merge.Length, out bytes1);
            WriteProcessMemory(process.Handle, ad1, bv1, bv1.Length, out bytes2).ToString();

            return globalArray;
        }

        public void DisableScript()
        {
            baseAddress = (long)process.MainModule.BaseAddress + 0x8EDD2;

            if (baseAddress == 0 || newmem == 0)
            {
                CustomMessageBox.Show("The script was not disabled!", MessageBoxButtons.OK);
                return;
            }

            byte[] originalbytes = { 0x4D, 0x8B, 0x1A, 0x49, 0x83, 0xFB, 0xFF };

            IntPtr bytes;

            if (Process.GetProcessesByName("FarmingSimulator2022Game").Length > 0)
            {
                WriteProcessMemory(process.Handle, baseAddress, originalbytes, originalbytes.Length, out bytes);
            }

            var successDeallocating = Dealloc(process.Handle, newmem);

            if (!successDeallocating)
            {
                int error = Marshal.GetLastWin32Error();
                CustomMessageBox.Show("Deallocation failed. Error code: " + error.ToString(), MessageBoxButtons.OK);
                return;
            }
        }

        private byte[] Jmp(long to, long from, bool nop, bool nop2, bool isLong)
        {
            string dump = "";

            if (isLong)
                dump = (to - from - 5).ToString("X"); //Get original bytes
            else
                dump = ((int)(to - from - 5)).ToString("X"); //Get original bytes

            if (dump.Length == 7) //Make sure we have 4 bytes
                dump = "0" + dump;
            else if (dump.Length == 5)
                dump = "000" + dump;

            dump = dump + "E9"; //Add JMP

            if (nop)
                dump = "90" + dump; //Add NOP if needed

            if (nop2)
                dump = "9066" + dump; //Add NOP 2 if needed

            byte[] hex = new byte[dump.Length/2];
            for (int i = 0; i < hex.Length; i++)
            {
                hex[i] = Convert.ToByte(dump.Substring(i * 2, 2), 16); //Set each byte to 2 chars
            }
            Array.Reverse(hex); //Reverse byte array for use with Write()

            return hex;
        }

        #endregion

        private void GroupBox_Paint(object sender, PaintEventArgs e)
        {
        GroupBox box = sender as GroupBox;
        DrawGroupBox(box, e.Graphics, Color.White, Color.FromArgb(30, 81, 96));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DisableScript();
            globalArray = GetGlobalArray();
        }
    }
}
