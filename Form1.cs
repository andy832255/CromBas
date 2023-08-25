using System.Collections;
using System.Runtime.InteropServices;

namespace CromBas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //猜25次
        private void btnStart_Click(object sender, EventArgs e)
        {

            const int VK_ENTER = 0x0d;
            int sum = 0;
            int delay = 25;
            IntPtr hWnd;
            int stop = 0;
            if (string.IsNullOrEmpty(txtClue1.Text)) { MessageBox.Show("請輸入線索一"); return; }
            if (string.IsNullOrEmpty(txtClue2.Text)) { MessageBox.Show("請輸入線索二"); return; }
            if (string.IsNullOrEmpty(txtClue3.Text)) { MessageBox.Show("請輸入線索三"); return; }
            if (string.IsNullOrEmpty(txtDelay.Text)) { MessageBox.Show("請輸入延遲"); return; }
            try
            {
                delay = Convert.ToInt32(txtDelay.Text);

                if (MessageBox.Show("需等25次執行完成", "確定執行?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if ((hWnd = WindowsAPI.FindWindow("mabinogi", null)) != IntPtr.Zero)
                    {
                        WindowsAPI.SetForegroundWindow(hWnd);

                        int a = Convert.ToInt32(txtClue1.Text);
                        int b = Convert.ToInt32(txtClue2.Text);
                        int c = Convert.ToInt32(txtClue3.Text);

                        var Seasons = new List<string> { "山夏", "立春", "入夏", "秋收", "巴斯" };

                        var calculate = new List<int>() { a + b + c, a + b - c, a - b + c, a - b - c, a * b + c, a * b - c, a * b * c };
                        // 1 + 2 + 3
                        // 1 + 2 - 3
                        // 1 - 2 + 3
                        // 1 - 2 - 3
                        // 1 * 2 + 3
                        // 1 * 2 - 3
                        // 1 * 2 * 3
                        foreach (var x in calculate)
                        {
                            sum = x;
                            foreach (var y in Seasons)
                            {
                                Sleep(delay);
                                //SendKeys.Send(sum.ToString());

                                string str = sum.ToString();
                                for (int i = 0; i < str.Length; i++)
                                {
                                    InputOneKey((byte)GetKeyValues(str)[i]);
                                }
                                Sleep(delay);
                                SendKeys.Send(y);
                                Sleep(delay);
                                WindowsAPI.keybd_event(VK_ENTER, 0, 0, 0);
                                Sleep(delay);
                                WindowsAPI.keybd_event(VK_ENTER, 0, 0, 0);
                                stop++;
                                if (stop == 35) { WindowsAPI.keybd_event(VK_ENTER, 0, 2, 0); return; }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void InputOneKey(byte keyValue)
        {
            // 按下
            WindowsAPI.keybd_event(keyValue, 0, 0, 0);
            // 釋放      
            WindowsAPI.keybd_event(keyValue, 0, 2, 0);
        }

        #region WindowsAPI
        public static class WindowsAPI
        {
            [DllImport("user32.dll", SetLastError = true)]
            public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [DllImport("user32.dll", SetLastError = true)]
            public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);
            [DllImport("user32.dll")]
            public static extern int SendMessage(IntPtr hwnd, uint wMsg, IntPtr wParam, IntPtr lParam);
            [DllImport("USER32.DLL")]
            public static extern bool SetForegroundWindow(IntPtr hWnd);
            [DllImport("User32.dll", EntryPoint = "PostMessage")]
            public static extern int PostMessage(
                IntPtr hWnd,        // 信息发往的窗口的句柄
                uint Msg,            // 消息ID
                int wParam,         // 参数1
                int lParam            // 参数2
            );
            [DllImport("User32.dll", EntryPoint = "PostMessage")]
            public static extern int PostMessage(
                IntPtr hWnd,        // 信息发往的窗口的句柄
                uint Msg,            // 消息ID
                int wParam,         // 参数1
                IntPtr lParam            // 参数2
            );
            /// <summary>
            /// keybd_event
            /// </summary>
            /// <param name="bVk">虛擬鍵值</param>
            /// <param name="bScan"> 一般為0</param>
            /// <param name="dwFlags">這裡是整數型別 0 為按下，2為釋放</param>
            /// <param name="dwExtraInfo">這裡是整數型別 一般情況下設成為 0</param>
            [DllImport("user32.dll", EntryPoint = "keybd_event")]
            public static extern void keybd_event(
                byte bVk,
                byte bScan,
                int dwFlags,
                int dwExtraInfo
            );
        }
        #endregion

        #region 鍵盤按鍵的鍵碼值
        /// <summary>
        /// 枚舉類型，鍵盤按鍵的鍵碼值
        /// </summary>
        public enum KeyValueEnum : byte
        {
            //常用鍵：字母鍵A到Z
            vbKeyA = 65,
            vbKeyB = 66,
            vbKeyC = 67,
            vbKeyD = 68,
            vbKeyE = 69,
            vbKeyF = 70,
            vbKeyG = 71,
            vbKeyH = 72,
            vbKeyI = 73,
            vbKeyJ = 74,
            vbKeyK = 75,
            vbKeyL = 76,
            vbKeyM = 77,
            vbKeyN = 78,
            vbKeyO = 79,
            vbKeyP = 80,
            vbKeyQ = 81,
            vbKeyR = 82,
            vbKeyS = 83,
            vbKeyT = 84,
            vbKeyU = 85,
            vbKeyV = 86,
            vbKeyW = 87,
            vbKeyX = 88,
            vbKeyY = 89,
            vbKeyZ = 90,

            //// 數字鍵盤：0 - 9  //中文輸入法時無法使用
            //vbKey0 = 48,    // 0 鍵
            //vbKey1 = 49,    // 1 鍵
            //vbKey2 = 50,    // 2 鍵
            //vbKey3 = 51,    // 3 鍵
            //vbKey4 = 52,    // 4 鍵
            //vbKey5 = 53,    // 5 鍵
            //vbKey6 = 54,    // 6 鍵
            //vbKey7 = 55,    // 7 鍵
            //vbKey8 = 56,    // 8 鍵
            //vbKey9 = 57,    // 9 鍵

            // 小鍵盤按鍵
            vbKey0 = 0x60,    // 0 鍵
            vbKey1 = 0x61,    // 1 鍵
            vbKey2 = 0x62,    // 2 鍵
            vbKey3 = 0x63,    // 3 鍵
            vbKey4 = 0x64,    // 4 鍵
            vbKey5 = 0x65,    // 5 鍵
            vbKey6 = 0x66,    // 6 鍵
            vbKey7 = 0x67,    // 7 鍵
            vbKey8 = 0x68,    // 8 鍵
            vbKey9 = 0x69,    // 9 鍵
            vbKeyMultiply = 0x6A,   // MULTIPLICATIONSIGN(*)鍵
            vbKeyAdd = 0x6B,        // PLUS SIGN(+) 鍵
            vbKeySeparator = 0x6C,  // ENTER 鍵
            vbKeySubtract = 0x6D,   // MINUS SIGN(-) 鍵
            vbKeyDecimal = 0x6E,    // DECIMAL POINT(.) 鍵
            vbKeyDivide = 0x6F,     // DIVISION SIGN(/) 鍵

            // F1到F12按鍵
            vbKeyF1 = 0x70,   // F1 鍵
            vbKeyF2 = 0x71,   // F2 鍵
            vbKeyF3 = 0x72,   // F3 鍵
            vbKeyF4 = 0x73,   // F4 鍵
            vbKeyF5 = 0x74,   // F5 鍵
            vbKeyF6 = 0x75,   // F6 鍵
            vbKeyF7 = 0x76,   // F7 鍵
            vbKeyF8 = 0x77,   // F8 鍵
            vbKeyF9 = 0x78,   // F9 鍵
            vbKeyF10 = 0x79,  // F10 鍵
            vbKeyF11 = 0x7A,  // F11 鍵
            vbKeyF12 = 0x7B,  // F12 鍵

            // 其他常用按鍵
            vbKeyLButton = 0x1,    // 鼠標左鍵
            vbKeyRButton = 0x2,    // 鼠標右鍵
            vbKeyCancel = 0x3,     // CANCEL 鍵
            vbKeyMButton = 0x4,    // 鼠標中鍵
            vbKeyBack = 0x8,       // BACKSPACE 鍵
            vbKeyTab = 0x9,        // TAB 鍵
            vbKeyClear = 0xC,      // CLEAR 鍵
            vbKeyReturn = 0xD,     // ENTER 鍵
            vbKeyShift = 0x10,     // SHIFT 鍵
            vbKeyControl = 0x11,   // CTRL 鍵
            vbKeyAlt = 18,         // Alt 鍵  (鍵碼18)
            vbKeyMenu = 0x12,      // MENU 鍵
            vbKeyPause = 0x13,     // PAUSE 鍵
            vbKeyCapital = 0x14,   // CAPS LOCK 鍵
            vbKeyEscape = 0x1B,    // ESC 鍵
            vbKeySpace = 0x20,     // SPACEBAR 鍵
            vbKeyPageUp = 0x21,    // PAGE UP 鍵
            vbKeyEnd = 0x23,       // End 鍵
            vbKeyHome = 0x24,      // HOME 鍵
            vbKeyLeft = 0x25,      // LEFT ARROW 鍵
            vbKeyUp = 0x26,        // UP ARROW 鍵
            vbKeyRight = 0x27,     // RIGHT ARROW 鍵
            vbKeyDown = 0x28,      // DOWN ARROW 鍵
            vbKeySelect = 0x29,    // Select 鍵
            vbKeyPrint = 0x2A,     // PRINT SCREEN 鍵
            vbKeyExecute = 0x2B,   // EXECUTE 鍵
            vbKeySnapshot = 0x2C,  // SNAPSHOT 鍵
            vbKeyDelete = 0x2E,    // Delete 鍵
            vbKeyHelp = 0x2F,      // HELP 鍵
            vbKeyNumlock = 0x90   // NUM LOCK 鍵
        }
        #endregion

        /// <summary>
        /// 字符串轉換爲鍵碼值的集合
        /// </summary>
        /// <param name="str">待轉換的字符串</param>
        /// <returns>返回鍵碼集合</returns>
        public ArrayList GetKeyValues(string str)
        {
            ArrayList kvList = new ArrayList();
            for (int i = 0; i < str.Length; i++)
            {
                kvList.Add((byte)Enum.Parse(
                    typeof(KeyValueEnum), string.Concat("vbKey", str[i].ToString().ToUpper()) == "vbKey-" ? "vbKeySubtract" : string.Concat("vbKey", str[i].ToString().ToUpper()))); //負值處理
            }
            return kvList;
        }

        public void Sleep(int delay)
        {
            Thread.Sleep(delay);
        }

        //猜五次
        private void btnFive_Click(object sender, EventArgs e)
        {
            const int VK_ENTER = 0x0d;
            int sum = 0;
            int delay = 25;
            IntPtr hWnd;
            if (string.IsNullOrEmpty(txtClue1.Text)) { MessageBox.Show("請輸入線索一"); return; }
            if (string.IsNullOrEmpty(txtClue2.Text)) { MessageBox.Show("請輸入線索二"); return; }
            if (string.IsNullOrEmpty(txtClue3.Text)) { MessageBox.Show("請輸入線索三"); return; }
            if (string.IsNullOrEmpty(txtDelay.Text)) { MessageBox.Show("請輸入延遲"); return; }
            try
            {
                delay = Convert.ToInt32(txtDelay.Text);

                if ((hWnd = WindowsAPI.FindWindow("mabinogi", null)) != IntPtr.Zero)
                {
                    WindowsAPI.SetForegroundWindow(hWnd);

                    int a = Convert.ToInt32(txtClue1.Text);
                    int b = Convert.ToInt32(txtClue2.Text);
                    int c = Convert.ToInt32(txtClue3.Text);
                    if (rBtn1.Checked) { sum = a + b; }
                    else if (rBtn2.Checked) { sum = a - b; }
                    else if (rBtn3.Checked) { sum = a * b; }
                    if (rBtn4.Checked) { sum = sum + c; }
                    else if (rBtn5.Checked) { sum = sum - c; }
                    else if (rBtn6.Checked) { sum = sum * c; }

                    var Seasons = new List<string> { "山夏", "立春", "入夏", "秋收", "巴斯" };

                    foreach (var y in Seasons)
                    {
                        Sleep(delay);
                        //SendKeys.Send(sum.ToString());

                        string str = sum.ToString();
                        for (int i = 0; i < str.Length; i++)
                        {
                            InputOneKey((byte)GetKeyValues(str)[i]);
                        }
                        Sleep(delay);
                        SendKeys.Send(y);
                        Sleep(delay);
                        WindowsAPI.keybd_event(VK_ENTER, 0, 0, 0);
                        Sleep(delay);
                        WindowsAPI.keybd_event(VK_ENTER, 0, 0, 0);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}