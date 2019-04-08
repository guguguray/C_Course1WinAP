namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkBox1 = new System.Windows.Forms.CheckBox();
            this.chkBox2 = new System.Windows.Forms.CheckBox();
            this.chkBox3 = new System.Windows.Forms.CheckBox();
            this.chkBox4 = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.txtAcc);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "會員資訊";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密碼:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb2);
            this.groupBox2.Controls.Add(this.rdb1);
            this.groupBox2.Location = new System.Drawing.Point(19, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 39);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "性別";
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(17, 16);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(35, 16);
            this.rdb1.TabIndex = 0;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "男";
            this.rdb1.UseVisualStyleBackColor = true;
            this.rdb1.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(70, 16);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(35, 16);
            this.rdb2.TabIndex = 1;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "女";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(63, 37);
            this.txtAcc.MaxLength = 20;
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(100, 22);
            this.txtAcc.TabIndex = 3;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(63, 65);
            this.txtPwd.MaxLength = 20;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(100, 22);
            this.txtPwd.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkBox4);
            this.groupBox3.Controls.Add(this.chkBox3);
            this.groupBox3.Controls.Add(this.chkBox2);
            this.groupBox3.Controls.Add(this.chkBox1);
            this.groupBox3.Location = new System.Drawing.Point(194, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 136);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "興趣";
            // 
            // chkBox1
            // 
            this.chkBox1.AutoSize = true;
            this.chkBox1.Location = new System.Drawing.Point(32, 25);
            this.chkBox1.Name = "chkBox1";
            this.chkBox1.Size = new System.Drawing.Size(48, 16);
            this.chkBox1.TabIndex = 0;
            this.chkBox1.Text = "登山";
            this.chkBox1.UseVisualStyleBackColor = true;
            // 
            // chkBox2
            // 
            this.chkBox2.AutoSize = true;
            this.chkBox2.Location = new System.Drawing.Point(32, 48);
            this.chkBox2.Name = "chkBox2";
            this.chkBox2.Size = new System.Drawing.Size(48, 16);
            this.chkBox2.TabIndex = 1;
            this.chkBox2.Text = "旅行";
            this.chkBox2.UseVisualStyleBackColor = true;
            // 
            // chkBox3
            // 
            this.chkBox3.AutoSize = true;
            this.chkBox3.Location = new System.Drawing.Point(32, 71);
            this.chkBox3.Name = "chkBox3";
            this.chkBox3.Size = new System.Drawing.Size(48, 16);
            this.chkBox3.TabIndex = 2;
            this.chkBox3.Text = "音樂";
            this.chkBox3.UseVisualStyleBackColor = true;
            // 
            // chkBox4
            // 
            this.chkBox4.AutoSize = true;
            this.chkBox4.Location = new System.Drawing.Point(32, 94);
            this.chkBox4.Name = "chkBox4";
            this.chkBox4.Size = new System.Drawing.Size(48, 16);
            this.chkBox4.TabIndex = 3;
            this.chkBox4.Text = "唱歌";
            this.chkBox4.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(506, 29);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(259, 260);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "送出";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkBox4;
        private System.Windows.Forms.CheckBox chkBox3;
        private System.Windows.Forms.CheckBox chkBox2;
        private System.Windows.Forms.CheckBox chkBox1;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
    }
}