using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicCollection
{
    public partial class Form1 : Form
    {
        private AppDbContext db = new AppDbContext();
        EFGenericRepository<Songs> songRepo;
        public Form1()
        {
            InitializeComponent();
            songRepo = new EFGenericRepository<Songs>(db);
            dataGridView.DataSource = db.DisksSongs.ToArray();
            SongsCB.Items.AddRange(songRepo.GetAll().Select(s => s.NameSong).ToArray());
            SongsForDeleteCB.Items.AddRange(songRepo.GetAll().Select(s => s.NameSong).ToArray());
        }

        private void NewSongMenuItem_Click(object sender, EventArgs e)
        {
            SongForm songForm = new SongForm(db);
            songForm.ShowDialog();
            dataGridView.DataSource = db.DisksSongs.ToArray();
            SongsCB.Items.Clear();
            SongsForDeleteCB.Items.Clear();
            SongsCB.Items.AddRange(songRepo.GetAll().Select(s => s.NameSong).ToArray());
            SongsForDeleteCB.Items.AddRange(songRepo.GetAll().Select(s => s.NameSong).ToArray());
        }

        private void SongsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SongForm songForm = new SongForm(db);
            var song = songRepo.GetAll().FirstOrDefault(s => s.NameSong == SongsCB.SelectedItem.ToString());
            songForm.CurrentSong = song;
            songForm.NameTB.Text = song.NameSong;
            songForm.DurationDP.Value = DateTime.Now.Date + song.Duration;
            songForm.MusicDiskLB.SelectedItem = song.MusicDisk.NameDisk;
            songForm.ShowDialog();
            SongsCB.Text = String.Empty;
            dataGridView.DataSource = db.DisksSongs.ToArray();
            SongsCB.Items.Clear();
            SongsForDeleteCB.Items.Clear();
            SongsCB.Items.AddRange(songRepo.GetAll().Select(s => s.NameSong).ToArray());
            SongsForDeleteCB.Items.AddRange(songRepo.GetAll().Select(s => s.NameSong).ToArray());
        }

        private void SongsForDeleteCB_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                songRepo.Delete(songRepo.Filter(s=>s.NameSong == SongsForDeleteCB.SelectedItem.ToString()).FirstOrDefault());
                SongsForDeleteCB.Text = String.Empty;
            }
            dataGridView.DataSource = db.DisksSongs.ToArray();
            SongsCB.Items.Clear();
            SongsForDeleteCB.Items.Clear();
            SongsCB.Items.AddRange(songRepo.GetAll().Select(s => s.NameSong).ToArray());
            SongsForDeleteCB.Items.AddRange(songRepo.GetAll().Select(s => s.NameSong).ToArray());
        }

        private void AllSongsMenuItem_Click(object sender, EventArgs e) => dataGridView.DataSource = songRepo.GetAll().Select(s=> new {s.NameSong, s.Duration}).ToList();
    }
}
