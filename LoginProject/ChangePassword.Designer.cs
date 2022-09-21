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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OldPasswordInput = new System.Windows.Forms.TextBox();
            this.NewPasswordInput = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordInput = new System.Windows.Forms.TextBox();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.CancelPasswordChange = new System.Windows.Forms.Button();
            this.oldCheck = new System.Windows.Forms.CheckBox();
            this.newCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Старый пароль";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Новый пароль";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Повторный пароль";
            // 
            // OldPasswordInput
            // 
            this.OldPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldPasswordInput.Location = new System.Drawing.Point(171, 12);
            this.OldPasswordInput.Name = "OldPasswordInput";
            this.OldPasswordInput.PasswordChar = '*';
            this.OldPasswordInput.Size = new System.Drawing.Size(143, 26);
            this.OldPasswordInput.TabIndex = 12;
            // 
            // NewPasswordInput
            // 
            this.NewPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPasswordInput.Location = new System.Drawing.Point(171, 40);
            this.NewPasswordInput.Name = "NewPasswordInput";
            this.NewPasswordInput.PasswordChar = '*';
            this.NewPasswordInput.Size = new System.Drawing.Size(143, 26);
            this.NewPasswordInput.TabIndex = 13;
            // 
            // ConfirmPasswordInput
            // 
            this.ConfirmPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmPasswordInput.Location = new System.Drawing.Point(171, 69);
            this.ConfirmPasswordInput.Name = "ConfirmPasswordInput";
            this.ConfirmPasswordInput.PasswordChar = '*';
            this.ConfirmPasswordInput.Size = new System.Drawing.Size(143, 26);
            this.ConfirmPasswordInput.TabIndex = 14;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePasswordButton.Location = new System.Drawing.Point(14, 110);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(104, 38);
            this.ChangePasswordButton.TabIndex = 15;
            this.ChangePasswordButton.Text = "Сменить";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // CancelPasswordChange
            // 
            this.CancelPasswordChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelPasswordChange.Location = new System.Drawing.Point(225, 110);
            this.CancelPasswordChange.Name = "CancelPasswordChange";
            this.CancelPasswordChange.Size = new System.Drawing.Size(104, 38);
            this.CancelPasswordChange.TabIndex = 16;
            this.CancelPasswordChange.Text = "Отмена";
            this.CancelPasswordChange.UseVisualStyleBackColor = true;
            this.CancelPasswordChange.Click += new System.EventHandler(this.CancelPasswordChange_Click);
            // 
            // oldCheck
            // 
            this.oldCheck.AutoSize = true;
            this.oldCheck.Location = new System.Drawing.Point(298, 18);
            this.oldCheck.Name = "oldCheck";
            this.oldCheck.Size = new System.Drawing.Size(15, 14);
            this.oldCheck.TabIndex = 17;
            this.oldCheck.UseVisualStyleBackColor = true;
            this.oldCheck.CheckedChanged += new System.EventHandler(this.oldCheck_CheckedChanged);
            // 
            // newCheck
            // 
            this.newCheck.AutoSize = true;
            this.newCheck.Location = new System.Drawing.Point(298, 46);
            this.newCheck.Name = "newCheck";
            this.newCheck.Size = new System.Drawing.Size(15, 14);
            this.newCheck.TabIndex = 18;
            this.newCheck.UseVisualStyleBackColor = true;
            this.newCheck.CheckedChanged += new System.EventHandler(this.newCheck_CheckedChanged);
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
            this.Text = "Смена пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OldPasswordInput;
        private System.Windows.Forms.TextBox NewPasswordInput;
        private System.Windows.Forms.TextBox ConfirmPasswordInput;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button CancelPasswordChange;
        private System.Windows.Forms.CheckBox oldCheck;
        private System.Windows.Forms.CheckBox newCheck;
    }
}