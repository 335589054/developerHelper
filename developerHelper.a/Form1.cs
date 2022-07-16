using System.Diagnostics;

namespace developerHelper.a
{

    public partial class Form1 : Form
    {
        private static string CmdPath = @"C:\Windows\System32\cmd.exe";
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_sender_Click(object sender, EventArgs e)
        {
            using (Process p = new Process())
            {
                p.StartInfo.FileName = CmdPath;
                p.StartInfo.UseShellExecute = false;        //是否使用操作系统shell启动
                p.StartInfo.RedirectStandardInput = true;   //接受来自调用程序的输入信息
                p.StartInfo.RedirectStandardOutput = true;  //由调用程序获取输出信息
                p.StartInfo.RedirectStandardError = true;   //重定向标准错误输出
                p.StartInfo.CreateNoWindow = !show_shell_window.Checked;          //不显示程序窗口
                p.Start();//启动程序

                //向cmd窗口写入命令
                p.StandardInput.WriteLine(command.Text);
                p.StandardInput.AutoFlush = true;

                //获取cmd窗口的输出信息
                string output = p.StandardOutput.ReadToEnd();
                MessageBox.Show(output,"输出");
                p.WaitForExit();//等待程序执行完退出进程
                p.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            float cpucpp = ramCounter.NextValue();
            
            cpu.Text = "" +
                "内存使用率:" + cpucpp.ToString("f2");
           // MessageBox.Show(cpucpp.ToString());
        }
    }
}