namespace HanziDemo
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_stroke = new System.Windows.Forms.ComboBox();
            this.lst_char = new System.Windows.Forms.ListBox();
            this.lst_radical = new System.Windows.Forms.ListBox();
            this.lbl_char = new System.Windows.Forms.Label();
            this.lst_component = new System.Windows.Forms.ListBox();
            this.lst_character = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(229, 348);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.tb_input);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(221, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hanzi Input";
            // 
            // tb_input
            // 
            this.tb_input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_input.Location = new System.Drawing.Point(42, 209);
            this.tb_input.MaxLength = 1;
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(136, 29);
            this.tb_input.TabIndex = 1;
            this.tb_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 159);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please input chinese character here:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cbo_stroke);
            this.tabPage2.Controls.Add(this.lst_char);
            this.tabPage2.Controls.Add(this.lst_radical);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(221, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dictionary";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(114, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Characters";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Radicals";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "stroke";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_stroke
            // 
            this.cbo_stroke.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_stroke.FormattingEnabled = true;
            this.cbo_stroke.Location = new System.Drawing.Point(63, 18);
            this.cbo_stroke.Name = "cbo_stroke";
            this.cbo_stroke.Size = new System.Drawing.Size(45, 28);
            this.cbo_stroke.TabIndex = 1;
            this.cbo_stroke.SelectedIndexChanged += new System.EventHandler(this.cbo_stroke_SelectedIndexChanged);
            // 
            // lst_char
            // 
            this.lst_char.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_char.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_char.FormattingEnabled = true;
            this.lst_char.ItemHeight = 33;
            this.lst_char.Location = new System.Drawing.Point(114, 55);
            this.lst_char.Name = "lst_char";
            this.lst_char.Size = new System.Drawing.Size(101, 235);
            this.lst_char.TabIndex = 1;
            this.lst_char.SelectedIndexChanged += new System.EventHandler(this.lst_char_SelectedIndexChanged);
            // 
            // lst_radical
            // 
            this.lst_radical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_radical.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_radical.FormattingEnabled = true;
            this.lst_radical.ItemHeight = 33;
            this.lst_radical.Location = new System.Drawing.Point(6, 84);
            this.lst_radical.Name = "lst_radical";
            this.lst_radical.Size = new System.Drawing.Size(102, 202);
            this.lst_radical.TabIndex = 1;
            this.lst_radical.SelectedIndexChanged += new System.EventHandler(this.lst_radical_SelectedIndexChanged);
            // 
            // lbl_char
            // 
            this.lbl_char.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_char.BackColor = System.Drawing.Color.LightGray;
            this.lbl_char.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_char.Location = new System.Drawing.Point(12, 363);
            this.lbl_char.Name = "lbl_char";
            this.lbl_char.Size = new System.Drawing.Size(229, 229);
            this.lbl_char.TabIndex = 1;
            this.lbl_char.Text = "字";
            this.lbl_char.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_char.Click += new System.EventHandler(this.lbl_char_Click);
            // 
            // lst_component
            // 
            this.lst_component.Font = new System.Drawing.Font("KaiXinSong", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_component.FormattingEnabled = true;
            this.lst_component.ItemHeight = 29;
            this.lst_component.Location = new System.Drawing.Point(247, 40);
            this.lst_component.Name = "lst_component";
            this.lst_component.Size = new System.Drawing.Size(101, 149);
            this.lst_component.TabIndex = 2;
            this.lst_component.Click += new System.EventHandler(this.lst_component_Click);
            this.lst_component.SelectedIndexChanged += new System.EventHandler(this.lst_component_SelectedIndexChanged);
            // 
            // lst_character
            // 
            this.lst_character.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_character.Font = new System.Drawing.Font("KaiXinSong", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_character.FormattingEnabled = true;
            this.lst_character.ItemHeight = 29;
            this.lst_character.Location = new System.Drawing.Point(247, 298);
            this.lst_character.Name = "lst_character";
            this.lst_character.Size = new System.Drawing.Size(101, 294);
            this.lst_character.TabIndex = 2;
            this.lst_character.Click += new System.EventHandler(this.lst_character_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(354, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(788, 580);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(247, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Composition";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(247, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 90);
            this.label5.TabIndex = 5;
            this.label5.Text = "Characters containing this component";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(354, 582);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(788, 10);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 601);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lst_character);
            this.Controls.Add(this.lst_component);
            this.Controls.Add(this.lbl_char);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(935, 640);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HanziDemo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.ComboBox cbo_stroke;
        private System.Windows.Forms.ListBox lst_char;
        private System.Windows.Forms.ListBox lst_radical;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_char;
        private System.Windows.Forms.ListBox lst_component;
        private System.Windows.Forms.ListBox lst_character;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

