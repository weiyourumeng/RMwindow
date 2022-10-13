using KeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QTA5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = null;
            this.Size = new Size(panel1.Size.Width + 2, panel1.Size.Height + 2);
        }
        #region
        #region 图片移动
        private static bool IsDragging = false; //用于指示当前是不是在拖拽状态
        private Point StartPoint = new Point(0, 0); //记录鼠标按下去的坐标, new是为了拿到空间, 两个0无所谓的
        //记录动了多少距离,然后给窗体Location赋值,要设置Location,必须用一个Point结构体,不能直接给Location的X,Y赋值
        private Point OffsetPoint = new Point(0, 0);
        private void 窗口移动_鼠标按下(object sender, MouseEventArgs e)
        {   //如果按下去的按钮不是左键就return,节省运算资源
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            //按下鼠标后,进入拖动状态:
            IsDragging = true;
            //保存刚按下时的鼠标坐标
            StartPoint.X = e.X;
            StartPoint.Y = e.Y;
        }
        private void 窗口移动_鼠标移动(object sender, MouseEventArgs e)
        {//鼠标移动时调用,检测到IsDragging为真时
            if (IsDragging == true)
            {   //用当前坐标减去起始坐标得到偏移量Offset
                OffsetPoint.X = e.X - StartPoint.X;
                OffsetPoint.Y = e.Y - StartPoint.Y;
                //将Offset转化为屏幕坐标赋值给Location,设置Form在屏幕中的位置,如果不作PointToScreen转换,你自己看看效果就好
                Location = PointToScreen(OffsetPoint);
            }

        }
        private void 窗口移动_鼠标左键弹起(object sender, MouseEventArgs e)
        {   //左键抬起时,及时把拖动判定设置为false,否则,你也可以试试效果
            IsDragging = false;
        }
        #endregion
        [DllImport("user32.dll", EntryPoint = "FindWindowExA")]
        public static extern int FindWindowExA(int hWndChild, int a, string name1, string name12);
        int 句柄 = 0;
        public static bool 进程_是否存在(string newName)
        {
            string programName = newName.Replace(".exe", "");
            return Process.GetProcessesByName(programName).Length > 0 ? true : false;
        }
        //获取窗口标题
        [DllImport("user32", SetLastError = true)]
        public static extern int GetWindowText(
        IntPtr hWnd, //窗口句柄
        StringBuilder lpString, //标题
        int nMaxCount  //最大值
        );
        //获取类的名字
        [DllImport("user32.dll")]
        private static extern int GetClassName(
            IntPtr hWnd, //句柄
            StringBuilder lpString, //类名
            int nMaxCount //最大值
        );
        //根据坐标获取窗口句柄
        [DllImport("user32")]
        private static extern IntPtr WindowFromPoint(
        Point Point  //坐标
        );
        [DllImport("user32.dll", EntryPoint = "ShowWindow")]
        private static extern int 窗口_置状态(IntPtr hwnd, int nCmdShow);
        [DllImport("user32.dll", EntryPoint = "IsWindowVisible")]
        private static extern bool 窗口_是否可见(IntPtr hWnd);
        [DllImport("User32.dll", EntryPoint = "SetForegroundWindow")]
        private static extern bool 窗口_置焦点(IntPtr hWnd);
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        public static void 窗口_激活显示(IntPtr hwnd)
        {
            ShowWindowAsync(hwnd, 1);//显示
            窗口_置焦点(hwnd);//当到最前端
        }

        [DllImport("kernel32")]
        //读配置文件方法的6个参数：所在的分区（section）、键值、     初始缺省值、     StringBuilder、   参数长度上限、配置文件路径
        private static extern int GetPrivateProfileString(string section, string key, string deVal, StringBuilder retVal,int size, string filePath);
        [DllImport("kernel32")]
        //写配置文件方法的4个参数：所在的分区（section）、  键值、     参数值、        配置文件路径
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        public static void 写配置项(string path, string section, string key, string value)
        {
            //写配置项参数
            string strPath = Environment.CurrentDirectory + path;//"\\binbinconfig.ini";
            WritePrivateProfileString(section, key, value, strPath);
        }
        public static string 读配置项(string path, string section, string key)
        {
            StringBuilder sb = new StringBuilder(255);
            string strPath = Environment.CurrentDirectory + path;//"\\binbinconfig.ini"
            //最好初始缺省值设置为非空，因为如果配置文件不存在，取不到值，程序也不会报错
            GetPrivateProfileString(section, key, null, sb, 255, strPath);
            return sb.ToString();

        }
        [DllImport("user32.dll", EntryPoint = "FindWindowExA")]
        public static extern int 窗口_取句柄(int hWndChild, int a, string name1, string name12);
        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        private static extern void keybd_event(byte bVk, //虚拟键值
  byte bScan,// 一般为0
  int dwFlags, //这里是整数类型 0 为按下，2为释放
  int dwExtraInfo //这里是整数类型 一般情况下设成为0
   );
        [DllImport("User32.dll", EntryPoint = "PostMessageA")]
        private static extern int PostMessageA(IntPtr hWnd, int Msg, int wParam, int lParam);
        public static void 鼠标_消息(IntPtr HWD, int 键, int 控制)
        {
            if (键 == 1)
            {
                if (控制 == 1)
                {
                    PostMessageA(HWD, 513, 1, 0);//左键按下
                    //程序_延时(10);
                    PostMessageA(HWD, 514, 0, 0);//左键放开
                }
                else if (控制 == 2)
                {
                    PostMessageA(HWD, 513, 1, 0);
                    //程序_延时(10);
                    PostMessageA(HWD, 514, 0, 0);
                    //程序_延时(10);
                    PostMessageA(HWD, 515, 0, 0);

                }
                else if (控制 == 3)
                {
                    PostMessageA(HWD, 513, 1, 0);
                }
                else if (控制 == 4)
                {
                    PostMessageA(HWD, 514, 0, 0);
                }

            }
            if (键 == 2)
            {
                if (控制 == 1)
                {
                    PostMessageA(HWD, 516, 2, 0);
                    //程序_延时(10);
                    PostMessageA(HWD, 517, 2, 0);
                }
                else if (控制 == 2)
                {
                    PostMessageA(HWD, 516, 2, 0);
                    //程序_延时(10);
                    PostMessageA(HWD, 517, 2, 0);
                    //程序_延时(10);
                    PostMessageA(HWD, 518, 0, 0);
                }
                else if (控制 == 3)
                {
                    PostMessageA(HWD, 516, 2, 0);
                }
                else if (控制 == 4)
                {
                    PostMessageA(HWD, 517, 2, 0);
                }

            }
            if (键 == 3)
            {
                if (控制 == 1)
                {
                    PostMessageA(HWD, 519, 16, 0);
                    //程序_延时(10);
                    PostMessageA(HWD, 520, 0, 0);
                }
                else if (控制 == 2)
                {
                    PostMessageA(HWD, 519, 16, 0);
                    // 程序_延时(10);
                    PostMessageA(HWD, 520, 0, 0);
                    // 程序_延时(10);
                    PostMessageA(HWD, 521, 0, 0);

                }
                else if (控制 == 3)
                {
                    PostMessageA(HWD, 519, 16, 0);
                }
                else if (控制 == 4)
                {
                    PostMessageA(HWD, 520, 0, 0);
                }


            }
        }
        public static void 键盘_单机(byte keyy, int dwFlags)//键代码,0 为按下，2为释放
        {
            keybd_event(keyy, 0, dwFlags, 0);
        }
        private bool wloop = true;//W标志位
        private bool leftloop = false;//连点器标志位
        private bool ringthloop = false;
        enum MouseEventFlag : uint
        {
            Move = 0x0001,
            LeftDown = 0x0002,
            LeftUp = 0x0004,
            RightDown = 0x0008,
            RightUp = 0x0010,
            MiddleDown = 0x0020,
            MiddleUp = 0x0040,
            XDown = 0x0080,
            XUp = 0x0100,
            Wheel = 0x0800,
            VirtualDesk = 0x4000,
            Absolute = 0x8000
        }
        [DllImport("user32.dll")]
        static extern void mouse_event(MouseEventFlag flags, int dx, int dy, int data, int extraInfo);
        public static void 目录_创建(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            di.Create();
        }
        /// <summary>
        /// 鼠标_单机
        /// </summary>
        /// <param name="mes">1 = 鼠标左键单击；2,鼠标左键弹起；3 = 鼠标右键单击；4鼠标右键弹起</param>
        public static void 鼠标_单击(int mes)
        {
            if (mes == 1)
            {
                mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, 0);


            }
            if (mes == 2)
            {

                mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, 0);

            }
            if (mes == 3)
            {
                mouse_event(MouseEventFlag.RightDown, 0, 0, 0, 0);

            }
            if (mes == 4)
            {

                mouse_event(MouseEventFlag.RightUp, 0, 0, 0, 0);
            }
        }

        键盘钩子 k_hook = new 键盘钩子();//实例化键盘钩子
       public static void 程序_延时(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)
            {
             Application.DoEvents();//转让控制权
            }
        }
        #endregion
        public string 功能配置路径 = "\\RuMengRxing.ini";
        public void 初始化()
        {
            写配置项(功能配置路径, "Set", "textBox3", textBox3.Text);
            写配置项(功能配置路径, "Set", "textBox2", textBox2.Text);
            写配置项(功能配置路径, "Set", "textBox1", textBox1.Text);
           
        }
        public  void 配置初始化()
        {
            if (Directory.Exists(Environment.CurrentDirectory ) == false)
            {
                目录_创建(Environment.CurrentDirectory + "");
                if (File.Exists(Environment.CurrentDirectory + "\\RuMengRxing.ini") == false)
                {
                    File.WriteAllText(Environment.CurrentDirectory + "\\RuMengRxing.ini", null, Encoding.Default);
                    程序_延时(100);
                    初始化();
                }
            }
            else
            {
                if (File.Exists(Environment.CurrentDirectory + "\\RuMengRxing.ini") == false)
                {
                    File.WriteAllText(Environment.CurrentDirectory + "\\RuMengRxing.ini", null, Encoding.Default);
                    程序_延时(100);
                    初始化();
                }
                if (读配置项(功能配置路径, "Set", "checkBox1") == "1")
                {
                    checkBox1.Checked = true;
                }
                if (读配置项(功能配置路径, "Set", "checkBox2") == "1")
                {
                    checkBox2.Checked = true;
                }
                if (读配置项(功能配置路径, "Set", "checkBox3") == "1")
                {
                    checkBox3.Checked = true;
                }
                textBox4.Text = 读配置项(功能配置路径, "Set", "textBox4");
                textBox3.Text = 读配置项(功能配置路径, "Set", "textBox3");
                textBox2.Text = 读配置项(功能配置路径, "Set", "textBox2");
                textBox1.Text = 读配置项(功能配置路径, "Set", "textBox1");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            配置初始化();
            写配置项(功能配置路径, "Set", "Hwd", this.Handle.ToString());
            k_hook.KeyDownEvent += new KeyEventHandler(inthook);//添加键盘事件
            k_hook.Start();//安装键盘钩子 
            try
            {
                int formHandle = FindWindowExA(0, 0, textBox3.Text, textBox4.Text);
                label2.Text = formHandle.ToString();
                hwwd = (IntPtr)formHandle;
            }
            catch 
            {
                MessageBox.Show("请重启软件再试");
            }
        }
        private void inthook(object sender, KeyEventArgs e)//消息循环
        {
            if (checkBox1.Checked == true)
            {

                if (e.KeyData == (Keys.D1 | Keys.Alt))
                {
                    连点();

                }
            }
            if (checkBox2.Checked == true)
            {
                if (e.KeyData == (Keys.D2 | Keys.Alt))
                {
                    前进();
                }
            }
            if (checkBox3.Checked == true)
            {
                if (e.KeyData == (Keys.D3 | Keys.Alt))
                {
                    右键连点();
                }
            }

        }
        private void 前进()
        {
            if (wloop == true)
            {
                Console.WriteLine("前进");
                wloop = false;
                checkBox2.Text = "F2前进开始";
              
                //new Thread(qianjinLoop).Start();
               keybd_event((byte)Keys.W, 0, 0, 0);


            }
            else
            {
                checkBox2.Text = "F2前进关闭";
                Console.WriteLine("前进停止");
                wloop = true;
               keybd_event((byte)Keys.W, 0, 2, 0);
             
            }
        }
        private void 右键连点()
        {
            if (ringthloop)
            {
                ringthloop = false;
                checkBox3.Text = "F3关闭开镜";
            }
            else
            {
                ringthloop = true;
                checkBox3.Text = "F3开始开镜";
                new Thread(workLeftMouseClickringthloop).Start();
            }
        }
        private void 连点()
        {
            if (leftloop)
            {
                leftloop = false;
                checkBox1.Text = "F1连点器关闭";
            }
            else
            {
                leftloop = true;
                checkBox1.Text = "F1连点器开始";
                new Thread(workLeftMouseClickLoop).Start();
            }
        }

        private void workLeftMouseClickringthloop()//鼠标右键单击循环
        {
            while (ringthloop)
            {
                if (checkBox4.Checked==true)
                {
                    鼠标_消息((IntPtr)句柄, 2, 3);
                    Thread.Sleep(int.Parse(textBox2.Text));
                    鼠标_消息((IntPtr)句柄, 2, 4);
                    Thread.Sleep(int.Parse(textBox2.Text));

                }
                else
                {
                    鼠标_单击(3);
                    Thread.Sleep(int.Parse(textBox2.Text));
                    鼠标_单击(4);
                    Thread.Sleep(int.Parse(textBox2.Text));
                }
              
            }
        }
        private void workLeftMouseClickLoop()//鼠标左键单击循环
        {
            while (leftloop)
            {
                鼠标_单击(1);
                Thread.Sleep(int.Parse(textBox1.Text));
                鼠标_单击(2);
               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                int formHandle = FindWindowExA(0, 0, textBox3.Text, textBox4.Text);
                label2.Text = formHandle.ToString();
                hwwd = (IntPtr)formHandle;
            }
            catch
            {
            }
            if (hwwd == (IntPtr)0)
            {
                label1.Text = "窗口未运行:";
            }
            else
            {
                if (窗口_是否可见(hwwd) == true)
                {
                    label1.Text = "窗口句柄:";
                }
                else
                {
                    
                    label1.Text = "窗口隐藏:";
                    Console.WriteLine(hwwd);
                }                
            }

        }     
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (hwwd != (IntPtr)0)
            {
                if (窗口_是否可见(hwwd))
                    窗口_置状态(hwwd, 0);
                else 窗口_置状态(hwwd, 1);
                窗口_激活显示(this.Handle);
            }

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //写配置项(功能配置路径, "Set", "textBox3", textBox3.Text);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            写配置项(功能配置路径, "Set", "textBox1", textBox1.Text);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            写配置项(功能配置路径, "Set", "textBox2", textBox2.Text);
        }
        private void pictureBox4_MouseDown_1(object sender, MouseEventArgs e)
        {
            
            Cursor = Cursors.Cross; //改变鼠标样式为十字架
        }
        IntPtr hwwd = (IntPtr)0;
        private void pictureBox4_MouseUp_1(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;//改变鼠标样式为默认
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            Point p = new Point(x, y);
            IntPtr formHandle = WindowFromPoint(p);//得到窗口句柄
            StringBuilder title = new StringBuilder(256);
            GetWindowText(formHandle, title, title.Capacity);//得到窗口的标题
            StringBuilder className = new StringBuilder(256);
            GetClassName(formHandle, className, className.Capacity);//得到窗口的句柄
            label1.Text = "窗口句柄:";
            hwwd = formHandle;
            label2.Text =  formHandle.ToString();
            textBox3.Text=  className.ToString();//类名
            写配置项(功能配置路径, "Set", "textBox3", textBox3.Text);
            textBox4.Text = title.ToString();//标题
            写配置项(功能配置路径, "Set", "textBox4", textBox4.Text);

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                写配置项(功能配置路径, "Set", "checkBox1", "1");
            }
            else 写配置项(功能配置路径, "Set", "checkBox1", "0");
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                写配置项(功能配置路径, "Set", "checkBox3", "1");
            }
            else 写配置项(功能配置路径, "Set", "checkBox3", "0");
        }
        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                写配置项(功能配置路径, "Set", "checkBox2", "1");
            }
            else 写配置项(功能配置路径, "Set", "checkBox2", "0");
        }

        private void 最小化_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void 关闭_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void 常规_离开(object sender, EventArgs e)
        {
            关闭.BackgroundImage = Properties.Resources.X常规;
        }
        private void 常规_点燃(object sender, EventArgs e)
        {
            关闭.BackgroundImage = Properties.Resources.X点燃;

        }
        private void 最小化_点燃(object sender, EventArgs e)
        {
            最小化.BackgroundImage = Properties.Resources.最小化点燃;
        }

        private void 最小化_MouseLeave(object sender, EventArgs e)
        {
            最小化.BackgroundImage = Properties.Resources.最小化常规;
        }
    }
}
