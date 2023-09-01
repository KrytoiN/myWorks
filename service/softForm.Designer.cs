namespace service
{
    partial class softForm
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
            this.softShow = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateText = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.date2 = new System.Windows.Forms.ComboBox();
            this.date1 = new System.Windows.Forms.ComboBox();
            this.repBtn = new System.Windows.Forms.Button();
            this.destBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.softShow)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // softShow
            // 
            this.softShow.BackgroundColor = System.Drawing.SystemColors.Control;
            this.softShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.softShow.Location = new System.Drawing.Point(12, 11);
            this.softShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.softShow.Name = "softShow";
            this.softShow.Size = new System.Drawing.Size(442, 343);
            this.softShow.TabIndex = 4;
            this.softShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.softShow_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateText);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Location = new System.Drawing.Point(478, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 89);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "updateValues";
            // 
            // updateText
            // 
            this.updateText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateText.Location = new System.Drawing.Point(29, 21);
            this.updateText.Multiline = true;
            this.updateText.Name = "updateText";
            this.updateText.Size = new System.Drawing.Size(228, 20);
            this.updateText.TabIndex = 1;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(89, 47);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(98, 32);
            this.updateBtn.TabIndex = 0;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearBtn);
            this.groupBox2.Controls.Add(this.date2);
            this.groupBox2.Controls.Add(this.date1);
            this.groupBox2.Controls.Add(this.repBtn);
            this.groupBox2.Controls.Add(this.destBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.typeBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(478, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 236);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reports";
            // 
            // date2
            // 
            this.date2.FormattingEnabled = true;
            this.date2.Location = new System.Drawing.Point(151, 128);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(121, 22);
            this.date2.TabIndex = 9;
            // 
            // date1
            // 
            this.date1.FormattingEnabled = true;
            this.date1.Location = new System.Drawing.Point(8, 128);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(121, 22);
            this.date1.TabIndex = 8;
            this.date1.SelectedIndexChanged += new System.EventHandler(this.date1_SelectedIndexChanged);
            // 
            // repBtn
            // 
            this.repBtn.Location = new System.Drawing.Point(22, 173);
            this.repBtn.Name = "repBtn";
            this.repBtn.Size = new System.Drawing.Size(107, 35);
            this.repBtn.TabIndex = 7;
            this.repBtn.Text = "Show report";
            this.repBtn.UseVisualStyleBackColor = true;
            this.repBtn.Click += new System.EventHandler(this.repBtn_Click);
            // 
            // destBox
            // 
            this.destBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destBox.FormattingEnabled = true;
            this.destBox.Location = new System.Drawing.Point(66, 35);
            this.destBox.Name = "destBox";
            this.destBox.Size = new System.Drawing.Size(121, 23);
            this.destBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // typeBox
            // 
            this.typeBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(66, 77);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(121, 23);
            this.typeBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип лицензии";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Назначение лицензии";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Срок действия лицензии";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(151, 173);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(107, 35);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // softForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 376);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.softShow);
            this.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "softForm";
            this.Text = "softForm";
            ((System.ComponentModel.ISupportInitialize)(this.softShow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView softShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox updateText;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button repBtn;
        private System.Windows.Forms.ComboBox destBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox date2;
        private System.Windows.Forms.ComboBox date1;
        private System.Windows.Forms.Button clearBtn;
    }
}