namespace developerHelper.a
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmd = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.show_shell_window = new System.Windows.Forms.CheckBox();
            this.cmd_sender = new System.Windows.Forms.Button();
            this.command = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cpu = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd
            // 
            this.cmd.Controls.Add(this.textBox1);
            this.cmd.Controls.Add(this.button1);
            this.cmd.Location = new System.Drawing.Point(10, 15);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(778, 73);
            this.cmd.TabIndex = 0;
            this.cmd.TabStop = false;
            this.cmd.Text = "cmd";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(645, 27);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.show_shell_window);
            this.groupBox1.Controls.Add(this.cmd_sender);
            this.groupBox1.Controls.Add(this.command);
            this.groupBox1.Location = new System.Drawing.Point(12, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "shell";
            // 
            // show_shell_window
            // 
            this.show_shell_window.AutoSize = true;
            this.show_shell_window.Checked = true;
            this.show_shell_window.CheckState = System.Windows.Forms.CheckState.Checked;
            this.show_shell_window.Location = new System.Drawing.Point(6, 71);
            this.show_shell_window.Name = "show_shell_window";
            this.show_shell_window.Size = new System.Drawing.Size(121, 24);
            this.show_shell_window.TabIndex = 2;
            this.show_shell_window.Text = "显示终端窗口";
            this.show_shell_window.UseVisualStyleBackColor = true;
            // 
            // cmd_sender
            // 
            this.cmd_sender.Location = new System.Drawing.Point(507, 28);
            this.cmd_sender.Name = "cmd_sender";
            this.cmd_sender.Size = new System.Drawing.Size(94, 29);
            this.cmd_sender.TabIndex = 1;
            this.cmd_sender.Text = "运行";
            this.cmd_sender.UseVisualStyleBackColor = true;
            this.cmd_sender.Click += new System.EventHandler(this.cmd_sender_Click);
            // 
            // command
            // 
            this.command.Location = new System.Drawing.Point(8, 30);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(483, 27);
            this.command.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cpu);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "状态";
            // 
            // cpu
            // 
            this.cpu.AutoSize = true;
            this.cpu.Location = new System.Drawing.Point(8, 23);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(115, 20);
            this.cpu.TabIndex = 0;
            this.cpu.Text = "cpu使用:获取中";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(626, 639);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "developer helper rd-20220715";
            this.cmd.ResumeLayout(false);
            this.cmd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox cmd;
        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox1;
        private Button cmd_sender;
        private TextBox command;
        private CheckBox show_shell_window;
        private GroupBox groupBox2;
        private Label cpu;
        private System.Windows.Forms.Timer timer1;
    }
}