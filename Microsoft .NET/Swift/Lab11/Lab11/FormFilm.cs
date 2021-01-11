using Lab11.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class FormFilm : Form
    {
        private int _producers_count;
        private Film _film;
        public  Film Film
        {
            get { return _film; }
            set
            {
                _film = value;
                textBoxTitle.Text = _film.Title;
                if (_film.Year != 0) numericUpDownYear.Value = _film.Year;
                else numericUpDownYear.Value = 2020;
                comboBoxProducer.SelectedIndex = _film.ProdusserId-1;

            }
        }
        public FormFilm(int producers_count)
        {

            
          
            InitializeComponent();
            _producers_count = producers_count;
            for (int i = 0; i < _producers_count; i++)
            {
                comboBoxProducer.Items.Add((i + 1).ToString());
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Film.Title = textBoxTitle.Text;
            Film.Year = (int)numericUpDownYear.Value;
            Film.ProdusserId = Convert.ToInt32(comboBoxProducer.SelectedIndex+1);
        }

        private void FormFilm_Load(object sender, EventArgs e)
        {
           
            
        }

        private void buttonCoverSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Все изображения (*.JPG;*.PNG;*.JPEG;*.PNG)|*.JPG;*.PNG;*.JPEG;*.PNG";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    labelCoverFilename.Text = openFileDialog1.FileName;
                    _film.Cover = new Bitmap(openFileDialog1.FileName);
                    
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
    }
}
