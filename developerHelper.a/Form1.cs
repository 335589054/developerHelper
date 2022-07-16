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
                p.StartInfo.UseShellExecute = false;        //�Ƿ�ʹ�ò���ϵͳshell����
                p.StartInfo.RedirectStandardInput = true;   //�������Ե��ó����������Ϣ
                p.StartInfo.RedirectStandardOutput = true;  //�ɵ��ó����ȡ�����Ϣ
                p.StartInfo.RedirectStandardError = true;   //�ض����׼�������
                p.StartInfo.CreateNoWindow = !show_shell_window.Checked;          //����ʾ���򴰿�
                p.Start();//��������

                //��cmd����д������
                p.StandardInput.WriteLine(command.Text);
                p.StandardInput.AutoFlush = true;

                //��ȡcmd���ڵ������Ϣ
                string output = p.StandardOutput.ReadToEnd();
                MessageBox.Show(output,"���");
                p.WaitForExit();//�ȴ�����ִ�����˳�����
                p.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            float cpucpp = ramCounter.NextValue();
            
            cpu.Text = "" +
                "�ڴ�ʹ����:" + cpucpp.ToString("f2");
           // MessageBox.Show(cpucpp.ToString());
        }
    }
}