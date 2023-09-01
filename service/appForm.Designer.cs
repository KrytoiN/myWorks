namespace service
{
    partial class appForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appForm));
            this.sqlApp = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contrlBtn = new System.Windows.Forms.Button();
            this.exCheck = new System.Windows.Forms.ComboBox();
            this.appControl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sqlApp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlApp
            // 
            this.sqlApp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.sqlApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlApp.Location = new System.Drawing.Point(10, 8);
            this.sqlApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sqlApp.Name = "sqlApp";
            this.sqlApp.Size = new System.Drawing.Size(421, 202);
            this.sqlApp.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.contrlBtn);
            this.groupBox1.Controls.Add(this.exCheck);
            this.groupBox1.Controls.Add(this.appControl);
            this.groupBox1.Location = new System.Drawing.Point(445, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complete application control";
            // 
            // contrlBtn
            // 
            this.contrlBtn.Location = new System.Drawing.Point(44, 111);
            this.contrlBtn.Name = "contrlBtn";
            this.contrlBtn.Size = new System.Drawing.Size(91, 34);
            this.contrlBtn.TabIndex = 5;
            this.contrlBtn.Text = "Show";
            this.contrlBtn.UseVisualStyleBackColor = true;
            this.contrlBtn.Click += new System.EventHandler(this.contrlBtn_Click);
            // 
            // exCheck
            // 
            this.exCheck.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exCheck.FormattingEnabled = true;
            this.exCheck.Location = new System.Drawing.Point(24, 82);
            this.exCheck.Name = "exCheck";
            this.exCheck.Size = new System.Drawing.Size(152, 23);
            this.exCheck.TabIndex = 0;
            // 
            // appControl
            // 
            this.appControl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appControl.FormattingEnabled = true;
            this.appControl.Items.AddRange(new object[] {
            "Выполнена",
            "Не выполнена"});
            this.appControl.Location = new System.Drawing.Point(24, 39);
            this.appControl.Name = "appControl";
            this.appControl.Size = new System.Drawing.Size(152, 23);
            this.appControl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Executor";
            // 
            // appForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(648, 235);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sqlApp);
            this.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "appForm";
            this.Text = "appForm";
            ((System.ComponentModel.ISupportInitialize)(this.sqlApp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sqlApp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox appControl;
        private System.Windows.Forms.Button contrlBtn;
        private System.Windows.Forms.ComboBox exCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}