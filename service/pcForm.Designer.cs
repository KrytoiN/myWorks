namespace service
{
    partial class pcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pcForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateText = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.pcShow = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numberChk = new System.Windows.Forms.ComboBox();
            this.softBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pcBtn = new System.Windows.Forms.Button();
            this.statusChk = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcShow)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.updateText);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Location = new System.Drawing.Point(477, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "updateValues";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value";
            // 
            // updateText
            // 
            this.updateText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateText.Location = new System.Drawing.Point(29, 37);
            this.updateText.Multiline = true;
            this.updateText.Name = "updateText";
            this.updateText.Size = new System.Drawing.Size(141, 20);
            this.updateText.TabIndex = 1;
            // 
            // updateBtn
            // 
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateBtn.Location = new System.Drawing.Point(50, 63);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(98, 32);
            this.updateBtn.TabIndex = 0;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // pcShow
            // 
            this.pcShow.BackgroundColor = System.Drawing.SystemColors.Control;
            this.pcShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pcShow.Location = new System.Drawing.Point(12, 11);
            this.pcShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcShow.Name = "pcShow";
            this.pcShow.Size = new System.Drawing.Size(442, 334);
            this.pcShow.TabIndex = 3;
            this.pcShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pcShow_CellClick_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numberChk);
            this.groupBox2.Controls.Add(this.softBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(477, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Software Accounting";
            // 
            // numberChk
            // 
            this.numberChk.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberChk.FormattingEnabled = true;
            this.numberChk.Location = new System.Drawing.Point(29, 35);
            this.numberChk.Name = "numberChk";
            this.numberChk.Size = new System.Drawing.Size(141, 23);
            this.numberChk.TabIndex = 3;
            // 
            // softBtn
            // 
            this.softBtn.Location = new System.Drawing.Point(29, 63);
            this.softBtn.Name = "softBtn";
            this.softBtn.Size = new System.Drawing.Size(141, 32);
            this.softBtn.TabIndex = 2;
            this.softBtn.Text = "Show softaware";
            this.softBtn.UseVisualStyleBackColor = true;
            this.softBtn.Click += new System.EventHandler(this.softBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "numberPC";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pcBtn);
            this.groupBox3.Controls.Add(this.statusChk);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(477, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 101);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status PC";
            // 
            // pcBtn
            // 
            this.pcBtn.Location = new System.Drawing.Point(29, 63);
            this.pcBtn.Name = "pcBtn";
            this.pcBtn.Size = new System.Drawing.Size(141, 32);
            this.pcBtn.TabIndex = 2;
            this.pcBtn.Text = "Show PC";
            this.pcBtn.UseVisualStyleBackColor = true;
            this.pcBtn.Click += new System.EventHandler(this.pcBtn_Click);
            // 
            // statusChk
            // 
            this.statusChk.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusChk.FormattingEnabled = true;
            this.statusChk.Location = new System.Drawing.Point(29, 35);
            this.statusChk.Name = "statusChk";
            this.statusChk.Size = new System.Drawing.Size(141, 23);
            this.statusChk.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "statusPC";
            // 
            // pcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 363);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pcShow);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "pcForm";
            this.Text = "pcForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcShow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox updateText;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridView pcShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox numberChk;
        private System.Windows.Forms.Button softBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox statusChk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pcBtn;
    }
}