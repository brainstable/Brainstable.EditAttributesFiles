namespace Brainstable.EditAttributesFiles
{
    partial class MainForm
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
            this.btn_LoadFile = new System.Windows.Forms.Button();
            this.lbl_PathFile = new System.Windows.Forms.Label();
            this.ofd_LoadFile = new System.Windows.Forms.OpenFileDialog();
            this.lbl_NameFile = new System.Windows.Forms.Label();
            this.lbl_ExtFile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_SizeFile = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Created = new System.Windows.Forms.Label();
            this.lbl_Changed = new System.Windows.Forms.Label();
            this.lbl_Opened = new System.Windows.Forms.Label();
            this.dtp_Created = new System.Windows.Forms.DateTimePicker();
            this.btn_Change = new System.Windows.Forms.Button();
            this.dtp_Changed = new System.Windows.Forms.DateTimePicker();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_LoadFile
            // 
            this.btn_LoadFile.Location = new System.Drawing.Point(12, 12);
            this.btn_LoadFile.Name = "btn_LoadFile";
            this.btn_LoadFile.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadFile.TabIndex = 0;
            this.btn_LoadFile.Text = "Load file";
            this.btn_LoadFile.UseVisualStyleBackColor = true;
            this.btn_LoadFile.Click += new System.EventHandler(this.Btn_LoadFile_Click);
            // 
            // lbl_PathFile
            // 
            this.lbl_PathFile.AutoSize = true;
            this.lbl_PathFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PathFile.Location = new System.Drawing.Point(108, 71);
            this.lbl_PathFile.Name = "lbl_PathFile";
            this.lbl_PathFile.Size = new System.Drawing.Size(16, 13);
            this.lbl_PathFile.TabIndex = 1;
            this.lbl_PathFile.Text = "...";
            // 
            // ofd_LoadFile
            // 
            this.ofd_LoadFile.FileName = "openFileDialog1";
            // 
            // lbl_NameFile
            // 
            this.lbl_NameFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_NameFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_NameFile.Location = new System.Drawing.Point(111, 12);
            this.lbl_NameFile.Name = "lbl_NameFile";
            this.lbl_NameFile.Size = new System.Drawing.Size(340, 23);
            this.lbl_NameFile.TabIndex = 2;
            this.lbl_NameFile.Text = "...";
            this.lbl_NameFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ExtFile
            // 
            this.lbl_ExtFile.AutoSize = true;
            this.lbl_ExtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ExtFile.Location = new System.Drawing.Point(108, 47);
            this.lbl_ExtFile.Name = "lbl_ExtFile";
            this.lbl_ExtFile.Size = new System.Drawing.Size(16, 13);
            this.lbl_ExtFile.TabIndex = 3;
            this.lbl_ExtFile.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Size";
            // 
            // lbl_SizeFile
            // 
            this.lbl_SizeFile.AutoSize = true;
            this.lbl_SizeFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_SizeFile.Location = new System.Drawing.Point(108, 95);
            this.lbl_SizeFile.Name = "lbl_SizeFile";
            this.lbl_SizeFile.Size = new System.Drawing.Size(16, 13);
            this.lbl_SizeFile.TabIndex = 7;
            this.lbl_SizeFile.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(445, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "_________________________________________________________________________";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "_________________________________________________________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Created";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Changed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Opened";
            // 
            // lbl_Created
            // 
            this.lbl_Created.AutoSize = true;
            this.lbl_Created.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Created.Location = new System.Drawing.Point(108, 131);
            this.lbl_Created.Name = "lbl_Created";
            this.lbl_Created.Size = new System.Drawing.Size(16, 13);
            this.lbl_Created.TabIndex = 13;
            this.lbl_Created.Text = "...";
            // 
            // lbl_Changed
            // 
            this.lbl_Changed.AutoSize = true;
            this.lbl_Changed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Changed.Location = new System.Drawing.Point(108, 157);
            this.lbl_Changed.Name = "lbl_Changed";
            this.lbl_Changed.Size = new System.Drawing.Size(16, 13);
            this.lbl_Changed.TabIndex = 14;
            this.lbl_Changed.Text = "...";
            // 
            // lbl_Opened
            // 
            this.lbl_Opened.AutoSize = true;
            this.lbl_Opened.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Opened.Location = new System.Drawing.Point(108, 188);
            this.lbl_Opened.Name = "lbl_Opened";
            this.lbl_Opened.Size = new System.Drawing.Size(16, 13);
            this.lbl_Opened.TabIndex = 15;
            this.lbl_Opened.Text = "...";
            // 
            // dtp_Created
            // 
            this.dtp_Created.Location = new System.Drawing.Point(317, 125);
            this.dtp_Created.Name = "dtp_Created";
            this.dtp_Created.Size = new System.Drawing.Size(134, 20);
            this.dtp_Created.TabIndex = 16;
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(12, 227);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 23);
            this.btn_Change.TabIndex = 17;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.Btn_Change_Click);
            // 
            // dtp_Changed
            // 
            this.dtp_Changed.Location = new System.Drawing.Point(317, 150);
            this.dtp_Changed.Name = "dtp_Changed";
            this.dtp_Changed.Size = new System.Drawing.Size(134, 20);
            this.dtp_Changed.TabIndex = 18;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(295, 227);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 19;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(376, 227);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 20;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 255);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.dtp_Changed);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.dtp_Created);
            this.Controls.Add(this.lbl_Opened);
            this.Controls.Add(this.lbl_Changed);
            this.Controls.Add(this.lbl_Created);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_SizeFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ExtFile);
            this.Controls.Add(this.lbl_NameFile);
            this.Controls.Add(this.lbl_PathFile);
            this.Controls.Add(this.btn_LoadFile);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditAttributesFiles 2019";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LoadFile;
        private System.Windows.Forms.Label lbl_PathFile;
        private System.Windows.Forms.OpenFileDialog ofd_LoadFile;
        private System.Windows.Forms.Label lbl_NameFile;
        private System.Windows.Forms.Label lbl_ExtFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_SizeFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Created;
        private System.Windows.Forms.Label lbl_Changed;
        private System.Windows.Forms.Label lbl_Opened;
        private System.Windows.Forms.DateTimePicker dtp_Created;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.DateTimePicker dtp_Changed;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Exit;
    }
}

