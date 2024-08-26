namespace ToDoList.Client
{
    partial class frm_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Password1 = new class_Controls.txt_Password();
            this.txt_UserName1 = new class_Controls.txt_UserName();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(193, 110);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Password1
            // 
            this.txt_Password1.Location = new System.Drawing.Point(109, 69);
            this.txt_Password1.Name = "txt_Password1";
            this.txt_Password1.Size = new System.Drawing.Size(159, 20);
            this.txt_Password1.TabIndex = 1;
            this.txt_Password1.Text = "123456";
            this.txt_Password1.UseSystemPasswordChar = true;
            // 
            // txt_UserName1
            // 
            this.txt_UserName1.Location = new System.Drawing.Point(109, 28);
            this.txt_UserName1.Name = "txt_UserName1";
            this.txt_UserName1.Size = new System.Drawing.Size(159, 20);
            this.txt_UserName1.TabIndex = 0;
            this.txt_UserName1.Text = "admin";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 150);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Password1);
            this.Controls.Add(this.txt_UserName1);
            this.Name = "frm_Login";
            this.Text = "frm_Loin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private class_Controls.txt_UserName txt_UserName1;
        private class_Controls.txt_Password txt_Password1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Login;
    }
}