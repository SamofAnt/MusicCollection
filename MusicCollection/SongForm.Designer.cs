namespace MusicCollection
{
    partial class SongForm
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
            this.NameTB = new System.Windows.Forms.TextBox();
            this.DurationDP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.MusicDiskLB = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddSongBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(72, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NameTB.Location = new System.Drawing.Point(161, 32);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(197, 26);
            this.NameTB.TabIndex = 1;
            // 
            // DurationDP
            // 
            this.DurationDP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DurationDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DurationDP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DurationDP.Location = new System.Drawing.Point(161, 75);
            this.DurationDP.Name = "DurationDP";
            this.DurationDP.ShowUpDown = true;
            this.DurationDP.Size = new System.Drawing.Size(200, 26);
            this.DurationDP.TabIndex = 2;
            this.DurationDP.Value = new System.DateTime(2022, 2, 12, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Длительность";
            // 
            // MusicDiskLB
            // 
            this.MusicDiskLB.FormattingEnabled = true;
            this.MusicDiskLB.Location = new System.Drawing.Point(161, 112);
            this.MusicDiskLB.Name = "MusicDiskLB";
            this.MusicDiskLB.Size = new System.Drawing.Size(200, 95);
            this.MusicDiskLB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(34, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Музыкальный диск";
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CancelBtn.Location = new System.Drawing.Point(307, 272);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(113, 35);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddSongBtn
            // 
            this.AddSongBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddSongBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.AddSongBtn.Location = new System.Drawing.Point(188, 272);
            this.AddSongBtn.Name = "AddSongBtn";
            this.AddSongBtn.Size = new System.Drawing.Size(113, 35);
            this.AddSongBtn.TabIndex = 7;
            this.AddSongBtn.Text = "Добавить";
            this.AddSongBtn.UseVisualStyleBackColor = true;
            this.AddSongBtn.Click += new System.EventHandler(this.AddSongBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.UpdateBtn.Location = new System.Drawing.Point(69, 272);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(113, 35);
            this.UpdateBtn.TabIndex = 8;
            this.UpdateBtn.Text = "Обновить";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // SongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 319);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddSongBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MusicDiskLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DurationDP);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label1);
            this.Name = "SongForm";
            this.Text = "SongForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AddSongBtn;
        public System.Windows.Forms.TextBox NameTB;
        public System.Windows.Forms.ListBox MusicDiskLB;
        public System.Windows.Forms.DateTimePicker DurationDP;
        private System.Windows.Forms.Button UpdateBtn;
    }
}