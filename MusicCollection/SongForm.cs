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
    public partial class SongForm : Form
    {
        private AppDbContext _context;
        EFGenericRepository<MusicDisk> disksRepo;
        EFGenericRepository<Songs> songRepo;
        public Songs CurrentSong { get; set; }
        public SongForm(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
            disksRepo = new EFGenericRepository<MusicDisk>(_context);
            songRepo = new EFGenericRepository<Songs>(_context); 
            MusicDiskLB.Items.AddRange(disksRepo.GetAll().Select(d => d.NameDisk).ToArray());
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSongBtn_Click(object sender, EventArgs e)
        {
            Songs song = new Songs();
            song.NameSong = NameTB.Text;
            song.Duration = new TimeSpan(DurationDP.Value.Hour, DurationDP.Value.Minute, DurationDP.Value.Second);
            var musicDisk = disksRepo.GetAll().FirstOrDefault(d => d.NameDisk == MusicDiskLB.SelectedItem.ToString()).Id;
            song.MusicDiskId = musicDisk;
            songRepo.Add(song);
            this.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            CurrentSong.NameSong = NameTB.Text;
            CurrentSong.Duration = new TimeSpan(DurationDP.Value.Hour, DurationDP.Value.Minute, DurationDP.Value.Second);
            var musicDisk = disksRepo.GetAll().FirstOrDefault(d => d.NameDisk == MusicDiskLB.SelectedItem.ToString()).Id;
            CurrentSong.MusicDiskId = musicDisk;
            songRepo.Update(CurrentSong);
            this.Close();
        }
    }
}
