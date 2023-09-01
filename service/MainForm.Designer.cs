namespace service
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbtn = new System.Windows.Forms.Button();
            this.appbtn = new System.Windows.Forms.Button();
            this.softbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pcbtn);
            this.panel1.Controls.Add(this.appbtn);
            this.panel1.Controls.Add(this.softbtn);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 208);
            this.panel1.TabIndex = 4;
            // 
            // pcbtn
            // 
            this.pcbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pcbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pcbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pcbtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcbtn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.pcbtn.Image = global::service.Properties.Resources.PC;
            this.pcbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pcbtn.Location = new System.Drawing.Point(22, 16);
            this.pcbtn.Name = "pcbtn";
            this.pcbtn.Size = new System.Drawing.Size(244, 51);
            this.pcbtn.TabIndex = 1;
            this.pcbtn.Text = "PC";
            this.pcbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pcbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.pcbtn.UseVisualStyleBackColor = true;
            this.pcbtn.Click += new System.EventHandler(this.pcbtn_Click);
            // 
            // appbtn
            // 
            this.appbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.appbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appbtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.appbtn.Image = global::service.Properties.Resources.Rc2sBMu0FmE;
            this.appbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.appbtn.Location = new System.Drawing.Point(22, 130);
            this.appbtn.Name = "appbtn";
            this.appbtn.Size = new System.Drawing.Size(244, 55);
            this.appbtn.TabIndex = 3;
            this.appbtn.Text = "Applications";
            this.appbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.appbtn.UseVisualStyleBackColor = true;
            this.appbtn.Click += new System.EventHandler(this.appbtn_Click);
            // 
            // softbtn
            // 
            this.softbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.softbtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.softbtn.Image = global::service.Properties.Resources.software;
            this.softbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.softbtn.Location = new System.Drawing.Point(22, 73);
            this.softbtn.Name = "softbtn";
            this.softbtn.Size = new System.Drawing.Size(244, 51);
            this.softbtn.TabIndex = 2;
            this.softbtn.Text = "Software";
            this.softbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.softbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.softbtn.UseVisualStyleBackColor = true;
            this.softbtn.Click += new System.EventHandler(this.softbtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(313, 247);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximumSize = new System.Drawing.Size(329, 286);
            this.MinimumSize = new System.Drawing.Size(329, 286);
            this.Name = "MainForm";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button pcbtn;
        private System.Windows.Forms.Button softbtn;
        private System.Windows.Forms.Button appbtn;
        private System.Windows.Forms.Panel panel1;
    }
}

