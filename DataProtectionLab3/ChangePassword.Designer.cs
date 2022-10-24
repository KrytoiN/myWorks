namespace DataProtectionLab1
{
    partial class ChangePassword
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
            this.newCheck = new System.Windows.Forms.CheckBox();
            this.oldCheck = new System.Windows.Forms.CheckBox();
            this.CancelPasswordChange = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.ConfirmPasswordInput = new System.Windows.Forms.TextBox();
            this.NewPasswordInput = new System.Windows.Forms.TextBox();
            this.OldPasswordInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newCheck
            // 
            this.newCheck.AutoSize = true;
            this.newCheck.Location = new System.Drawing.Point(300, 45);
            this.newCheck.Name = "newCheck";
            this.newCheck.Size = new System.Drawing.Size(15, 14);
            this.newCheck.TabIndex = 28;
            this.newCheck.UseVisualStyleBackColor = true;
            this.newCheck.CheckedChanged += new System.EventHandler(this.newCheck_CheckedChanged);
            // 
            // oldCheck
            // 
            this.oldCheck.AutoSize = true;
            this.oldCheck.Location = new System.Drawing.Point(300, 17);
            this.oldCheck.Name = "oldCheck";
            this.oldCheck.Size = new System.Drawing.Size(15, 14);
            this.oldCheck.TabIndex = 27;
            this.oldCheck.UseVisualStyleBackColor = true;
            this.oldCheck.CheckedChanged += new System.EventHandler(this.oldCheck_CheckedChanged);
            // 
            // CancelPasswordChange
            // 
            this.CancelPasswordChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelPasswordChange.Location = new System.Drawing.Point(227, 109);
            this.CancelPasswordChange.Name = "CancelPasswordChange";
            this.CancelPasswordChange.Size = new System.Drawing.Size(104, 38);
            this.CancelPasswordChange.TabIndex = 26;
            this.CancelPasswordChange.Text = "Отмена";
            this.CancelPasswordChange.UseVisualStyleBackColor = true;
            this.CancelPasswordChange.Click += new System.EventHandler(this.CancelPasswordChange_Click_1);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePasswordButton.Location = new System.Drawing.Point(16, 109);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(104, 38);
            this.ChangePasswordButton.TabIndex = 25;
            this.ChangePasswordButton.Text = "Сменить";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click_1);
            // 
            // ConfirmPasswordInput
            // 
            this.ConfirmPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmPasswordInput.Location = new System.Drawing.Point(173, 68);
            this.ConfirmPasswordInput.Name = "ConfirmPasswordInput";
            this.ConfirmPasswordInput.PasswordChar = '*';
            this.ConfirmPasswordInput.Size = new System.Drawing.Size(143, 26);
            this.ConfirmPasswordInput.TabIndex = 24;
            // 
            // NewPasswordInput
            // 
            this.NewPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPasswordInput.Location = new System.Drawing.Point(173, 39);
            this.NewPasswordInput.Name = "NewPasswordInput";
            this.NewPasswordInput.PasswordChar = '*';
            this.NewPasswordInput.Size = new System.Drawing.Size(143, 26);
            this.NewPasswordInput.TabIndex = 23;
            // 
            // OldPasswordInput
            // 
            this.OldPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldPasswordInput.Location = new System.Drawing.Point(173, 11);
            this.OldPasswordInput.Name = "OldPasswordInput";
            this.OldPasswordInput.PasswordChar = '*';
            this.OldPasswordInput.Size = new System.Drawing.Size(143, 26);
            this.OldPasswordInput.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Повторный пароль";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Новый пароль";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Старый пароль";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 159);
            this.Controls.Add(this.newCheck);
            this.Controls.Add(this.oldCheck);
            this.Controls.Add(this.CancelPasswordChange);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.ConfirmPasswordInput);
            this.Controls.Add(this.NewPasswordInput);
            this.Controls.Add(this.OldPasswordInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(357, 198);
            this.MinimumSize = new System.Drawing.Size(357, 198);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox newCheck;
        private System.Windows.Forms.CheckBox oldCheck;
        private System.Windows.Forms.Button CancelPasswordChange;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.TextBox ConfirmPasswordInput;
        private System.Windows.Forms.TextBox NewPasswordInput;
        private System.Windows.Forms.TextBox OldPasswordInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}