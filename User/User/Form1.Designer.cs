namespace User
{
    partial class Form1
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
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassRep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chExpired = new System.Windows.Forms.CheckBox();
            this.chEnable = new System.Windows.Forms.CheckBox();
            this.chCanChange = new System.Windows.Forms.CheckBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(12, 12);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(154, 329);
            this.lstUsers.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "List all users";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "NEW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(317, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.label3);
            this.Settings.Controls.Add(this.txtPassRep);
            this.Settings.Controls.Add(this.label2);
            this.Settings.Controls.Add(this.label1);
            this.Settings.Controls.Add(this.chExpired);
            this.Settings.Controls.Add(this.chEnable);
            this.Settings.Controls.Add(this.chCanChange);
            this.Settings.Controls.Add(this.txtPass);
            this.Settings.Controls.Add(this.txtUsername);
            this.Settings.Location = new System.Drawing.Point(172, 12);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(233, 329);
            this.Settings.TabIndex = 4;
            this.Settings.TabStop = false;
            this.Settings.Text = "Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "RepeatPassword:";
            // 
            // txtPassRep
            // 
            this.txtPassRep.Location = new System.Drawing.Point(101, 71);
            this.txtPassRep.Name = "txtPassRep";
            this.txtPassRep.Size = new System.Drawing.Size(126, 20);
            this.txtPassRep.TabIndex = 12;
            this.txtPassRep.TextChanged += new System.EventHandler(this.txtPassRep_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username:";
            // 
            // chExpired
            // 
            this.chExpired.AutoSize = true;
            this.chExpired.Location = new System.Drawing.Point(101, 147);
            this.chExpired.Name = "chExpired";
            this.chExpired.Size = new System.Drawing.Size(119, 17);
            this.chExpired.TabIndex = 9;
            this.chExpired.Text = "Is password expired";
            this.chExpired.UseVisualStyleBackColor = true;
            // 
            // chEnable
            // 
            this.chEnable.AutoSize = true;
            this.chEnable.Location = new System.Drawing.Point(101, 123);
            this.chEnable.Name = "chEnable";
            this.chEnable.Size = new System.Drawing.Size(59, 17);
            this.chEnable.TabIndex = 8;
            this.chEnable.Text = "Enable";
            this.chEnable.UseVisualStyleBackColor = true;
            // 
            // chCanChange
            // 
            this.chCanChange.AutoSize = true;
            this.chCanChange.Location = new System.Drawing.Point(101, 100);
            this.chCanChange.Name = "chCanChange";
            this.chCanChange.Size = new System.Drawing.Size(132, 17);
            this.chCanChange.TabIndex = 7;
            this.chCanChange.Text = "Can change password";
            this.chCanChange.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(101, 45);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(126, 20);
            this.txtPass.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(101, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(126, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 373);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox Settings;
        private System.Windows.Forms.CheckBox chCanChange;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassRep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chExpired;
        private System.Windows.Forms.CheckBox chEnable;
    }
}

