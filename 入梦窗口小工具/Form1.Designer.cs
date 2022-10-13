
namespace QTA5
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.最小化 = new System.Windows.Forms.PictureBox();
            this.关闭 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.最小化)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.关闭)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 160);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "F1鼠标左键";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 158);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 25);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "100";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 191);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 25);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "10000";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(16, 193);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(105, 19);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "F3鼠标右键";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "游戏未运行";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "句柄";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(263, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 31);
            this.button2.TabIndex = 91;
            this.button2.TabStop = false;
            this.button2.Text = "显/隐";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 92);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(278, 25);
            this.textBox3.TabIndex = 92;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 93;
            this.label3.Text = "游戏类名:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(136, 125);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(278, 25);
            this.textBox4.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 95;
            this.label4.Text = "游戏标题:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 229);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "F2长按W";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(753, 102);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(89, 19);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "后台按键";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 96;
            this.label5.Text = "入梦窗口小工具";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.窗口移动_鼠标按下);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.窗口移动_鼠标移动);
            this.label5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.窗口移动_鼠标左键弹起);
            // 
            // 最小化
            // 
            this.最小化.BackgroundImage = global::QTA5.Properties.Resources.最小化常规;
            this.最小化.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.最小化.Location = new System.Drawing.Point(376, 4);
            this.最小化.Name = "最小化";
            this.最小化.Size = new System.Drawing.Size(32, 30);
            this.最小化.TabIndex = 98;
            this.最小化.TabStop = false;
            this.最小化.Click += new System.EventHandler(this.最小化_Click);
            this.最小化.MouseEnter += new System.EventHandler(this.最小化_点燃);
            this.最小化.MouseLeave += new System.EventHandler(this.最小化_MouseLeave);
            // 
            // 关闭
            // 
            this.关闭.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.关闭.BackColor = System.Drawing.Color.White;
            this.关闭.BackgroundImage = global::QTA5.Properties.Resources.X常规;
            this.关闭.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.关闭.Location = new System.Drawing.Point(415, 4);
            this.关闭.Margin = new System.Windows.Forms.Padding(4);
            this.关闭.Name = "关闭";
            this.关闭.Size = new System.Drawing.Size(32, 30);
            this.关闭.TabIndex = 97;
            this.关闭.TabStop = false;
            this.关闭.Click += new System.EventHandler(this.关闭_Click);
            this.关闭.MouseEnter += new System.EventHandler(this.常规_点燃);
            this.关闭.MouseLeave += new System.EventHandler(this.常规_离开);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::QTA5.Properties.Resources.QQ截图20210107183254;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(364, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 45);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDown_1);
            this.pictureBox4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseUp_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.最小化);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.关闭);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 271);
            this.panel1.TabIndex = 99;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.窗口移动_鼠标按下);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.窗口移动_鼠标移动);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.窗口移动_鼠标左键弹起);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1107, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "入梦窗口小工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.最小化)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.关闭)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox 最小化;
        public System.Windows.Forms.PictureBox 关闭;
        private System.Windows.Forms.Panel panel1;
    }
}

