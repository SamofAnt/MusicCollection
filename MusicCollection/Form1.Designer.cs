namespace MusicCollection
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Songs = new System.Windows.Forms.ToolStripMenuItem();
            this.AllSongsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NewSongMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateSongMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSongMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MusicDisksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StylesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SongsCB = new System.Windows.Forms.ToolStripComboBox();
            this.SongsForDeleteCB = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Songs,
            this.MusicDisksMenuItem,
            this.StylesMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Songs
            // 
            this.Songs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllSongsMenuItem,
            this.toolStripSeparator1,
            this.NewSongMenuItem,
            this.UpdateSongMenuItem,
            this.DeleteSongMenuItem});
            this.Songs.Name = "Songs";
            this.Songs.Size = new System.Drawing.Size(54, 20);
            this.Songs.Text = "Песни";
            // 
            // AllSongsMenuItem
            // 
            this.AllSongsMenuItem.Name = "AllSongsMenuItem";
            this.AllSongsMenuItem.Size = new System.Drawing.Size(204, 22);
            this.AllSongsMenuItem.Text = "Все песни";
            this.AllSongsMenuItem.Click += new System.EventHandler(this.AllSongsMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // NewSongMenuItem
            // 
            this.NewSongMenuItem.Name = "NewSongMenuItem";
            this.NewSongMenuItem.Size = new System.Drawing.Size(204, 22);
            this.NewSongMenuItem.Text = "Добавить новую песню";
            this.NewSongMenuItem.Click += new System.EventHandler(this.NewSongMenuItem_Click);
            // 
            // UpdateSongMenuItem
            // 
            this.UpdateSongMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SongsCB});
            this.UpdateSongMenuItem.Name = "UpdateSongMenuItem";
            this.UpdateSongMenuItem.Size = new System.Drawing.Size(204, 22);
            this.UpdateSongMenuItem.Text = "Редактировать песню";
            // 
            // DeleteSongMenuItem
            // 
            this.DeleteSongMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SongsForDeleteCB});
            this.DeleteSongMenuItem.Name = "DeleteSongMenuItem";
            this.DeleteSongMenuItem.Size = new System.Drawing.Size(204, 22);
            this.DeleteSongMenuItem.Text = "Удалить песню";
            // 
            // MusicDisksMenuItem
            // 
            this.MusicDisksMenuItem.Name = "MusicDisksMenuItem";
            this.MusicDisksMenuItem.Size = new System.Drawing.Size(132, 20);
            this.MusicDisksMenuItem.Text = "Музыкальные диски";
            // 
            // StylesMenuItem
            // 
            this.StylesMenuItem.Name = "StylesMenuItem";
            this.StylesMenuItem.Size = new System.Drawing.Size(53, 20);
            this.StylesMenuItem.Text = "Стили";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.Location = new System.Drawing.Point(12, 95);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView.Size = new System.Drawing.Size(776, 354);
            this.dataGridView.TabIndex = 1;
            // 
            // SongsCB
            // 
            this.SongsCB.Name = "SongsCB";
            this.SongsCB.Size = new System.Drawing.Size(121, 23);
            this.SongsCB.SelectedIndexChanged += new System.EventHandler(this.SongsCB_SelectedIndexChanged);
            // 
            // SongsForDeleteCB
            // 
            this.SongsForDeleteCB.Name = "SongsForDeleteCB";
            this.SongsForDeleteCB.Size = new System.Drawing.Size(121, 23);
            this.SongsForDeleteCB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SongsForDeleteCB_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Songs;
        private System.Windows.Forms.ToolStripMenuItem AllSongsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem NewSongMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateSongMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteSongMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MusicDisksMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StylesMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripComboBox SongsCB;
        private System.Windows.Forms.ToolStripComboBox SongsForDeleteCB;
    }
}

