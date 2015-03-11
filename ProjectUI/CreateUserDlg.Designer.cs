namespace ProjectUI
{
    partial class CreateUserDlg
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ServerIp = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.txt_Instance = new System.Windows.Forms.TextBox();
            this.txt_AdminUser = new System.Windows.Forms.TextBox();
            this.txt_AdminUserPwd = new System.Windows.Forms.TextBox();
            this.txt_NewUser = new System.Windows.Forms.TextBox();
            this.txt_NewUserPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(65, 203);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(171, 203);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oracle服务器";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "实例";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "管理员用户";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "管理员用户密码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "新用户";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "新用户密码";
            // 
            // txt_ServerIp
            // 
            this.txt_ServerIp.Location = new System.Drawing.Point(101, 3);
            this.txt_ServerIp.Name = "txt_ServerIp";
            this.txt_ServerIp.Size = new System.Drawing.Size(100, 21);
            this.txt_ServerIp.TabIndex = 9;
            this.txt_ServerIp.Text = "127.0.0.1";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(101, 33);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(100, 21);
            this.txt_Port.TabIndex = 10;
            this.txt_Port.Text = "1521";
            // 
            // txt_Instance
            // 
            this.txt_Instance.Location = new System.Drawing.Point(101, 60);
            this.txt_Instance.Name = "txt_Instance";
            this.txt_Instance.Size = new System.Drawing.Size(100, 21);
            this.txt_Instance.TabIndex = 11;
            this.txt_Instance.Text = "orcl";
            // 
            // txt_AdminUser
            // 
            this.txt_AdminUser.Location = new System.Drawing.Point(101, 94);
            this.txt_AdminUser.Name = "txt_AdminUser";
            this.txt_AdminUser.ReadOnly = true;
            this.txt_AdminUser.Size = new System.Drawing.Size(100, 21);
            this.txt_AdminUser.TabIndex = 12;
            this.txt_AdminUser.Text = "system";
            // 
            // txt_AdminUserPwd
            // 
            this.txt_AdminUserPwd.Location = new System.Drawing.Point(101, 121);
            this.txt_AdminUserPwd.Name = "txt_AdminUserPwd";
            this.txt_AdminUserPwd.Size = new System.Drawing.Size(100, 21);
            this.txt_AdminUserPwd.TabIndex = 13;
            this.txt_AdminUserPwd.UseSystemPasswordChar = true;
            // 
            // txt_NewUser
            // 
            this.txt_NewUser.Location = new System.Drawing.Point(101, 145);
            this.txt_NewUser.Name = "txt_NewUser";
            this.txt_NewUser.Size = new System.Drawing.Size(100, 21);
            this.txt_NewUser.TabIndex = 13;
            // 
            // txt_NewUserPwd
            // 
            this.txt_NewUserPwd.Location = new System.Drawing.Point(101, 169);
            this.txt_NewUserPwd.Name = "txt_NewUserPwd";
            this.txt_NewUserPwd.Size = new System.Drawing.Size(100, 21);
            this.txt_NewUserPwd.TabIndex = 14;
            this.txt_NewUserPwd.UseSystemPasswordChar = true;
            // 
            // CreateUserDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txt_NewUserPwd);
            this.Controls.Add(this.txt_NewUser);
            this.Controls.Add(this.txt_AdminUserPwd);
            this.Controls.Add(this.txt_AdminUser);
            this.Controls.Add(this.txt_Instance);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_ServerIp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Name = "CreateUserDlg";
            this.Text = "创建用户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ServerIp;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.TextBox txt_Instance;
        private System.Windows.Forms.TextBox txt_AdminUser;
        private System.Windows.Forms.TextBox txt_AdminUserPwd;
        private System.Windows.Forms.TextBox txt_NewUser;
        private System.Windows.Forms.TextBox txt_NewUserPwd;
    }
}