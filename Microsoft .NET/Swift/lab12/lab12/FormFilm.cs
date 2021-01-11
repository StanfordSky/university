using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab12
{
    public partial class FormFilm : Form
    {
        public FormFilm(int pos)

        {
            InitializeComponent();

            this.filmTableAdapter.Fill(this.dB_dotNetDataSet.Film);
            this.producerTableAdapter.Fill(this.dB_dotNetDataSet.Producer);
         
            if (pos == -1)
            {
               filmBindingSource.AddNew();
               filmBindingSource.MoveLast();
            }
            else filmBindingSource.Position = pos;
            producerComboBox.DataSource = producerBindingSource;
            producerComboBox.DisplayMember = "FullName";
            producerComboBox.ValueMember = "id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_dotNetDataSet);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ChangePhoto(openFileDialog.FileName);
            }
        }
        private void ChangePhoto(string fileName )
        {
            Image img = Image.FromFile(fileName);
            coverPictureBox.Image = img;

            DataRowView drw = (DataRowView)filmBindingSource.Current;
            DB_dotNetDataSet.FilmRow row = (DB_dotNetDataSet.FilmRow)drw.Row;
            MemoryStream memStream = new MemoryStream();
            img.Save(memStream, img.RawFormat);

            row.cover = memStream.ToArray();
            memStream.Close();
            filmTableAdapter.Update(row);
        }

        private void toolStripMenuItemLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ChangePhoto(openFileDialog.FileName);
            }
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            DataRowView drw = (DataRowView)filmBindingSource.Current;
            DB_dotNetDataSet.FilmRow row = (DB_dotNetDataSet.FilmRow)drw.Row;
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (coverPictureBox.Image != null)
                {
                    FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                    coverPictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fs.Close();
                   
                }
            }
        }

        private void yearLabel1_Click(object sender, EventArgs e)
        {

        }

        private void yearNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
