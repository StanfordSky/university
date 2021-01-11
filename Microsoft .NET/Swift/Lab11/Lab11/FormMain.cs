using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Lab11.Models;

namespace Lab11
{
    public partial class FormMain : Form
    {
          private readonly SqlConnection _connection;
        public FormMain()
        {
            InitializeComponent();
          
            _connection = new SqlConnection("Data Source=localhost;Initial Catalog=DB_dotNet;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True");
        }


        private void toolStripButtonLoadProducer_Click(object sender, EventArgs e)
        {
            var Producers = Producer.List(_connection);
            listViewProducers.Items.Clear();
            for (int i = 0; i < Producers.Count; i++)
            {
                var p = Producers[i];
                ListViewItem listListViewItem = new ListViewItem(p.Id.ToString()); 
                listListViewItem.Tag = p;
                listListViewItem.SubItems.Add(p.FirstName);
                listListViewItem.SubItems.Add(p.LastName);
                listViewProducers.Items.Add(listListViewItem);
            }

        }
        private void toolStripButtonAddProducer_Click(object sender, EventArgs e)
        {
            FormProducer formProducer = new FormProducer()
            {
                Producer = new Producer()
            };
            if (formProducer.ShowDialog() == DialogResult.OK)
            {
            
                Producer.Insert(_connection, formProducer.Producer);
            }
        }
        private void toolStripButtonUpdateProducer_Click(object sender, EventArgs e)
        {
            try
            {
                FormProducer formProducer = new FormProducer
                {
                    Producer = (Producer)listViewProducers.SelectedItems[0].Tag
                };
                if (formProducer.ShowDialog() == DialogResult.OK)
                {
                   
                    listViewProducers.SelectedItems[0].SubItems[1].Text = formProducer.Producer.FirstName;
                    listViewProducers.SelectedItems[0].SubItems[2].Text = formProducer.Producer.LastName;
                    Producer.Update(_connection, formProducer.Producer);
                }
            }
            catch (System.ArgumentOutOfRangeException ex )
            {
                MessageBox.Show("Аргумент не выбран","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
        private void toolStripButtonDeleteProducer_Click(object sender, EventArgs e)
        {               
                Producer.Delete(_connection, ((Producer)listViewProducers.SelectedItems[0].Tag).Id);
            listViewProducers.Items.Remove(listViewProducers.SelectedItems[0]);
        }
        private void toolStripButtonLoad_Click(object sender, System.EventArgs e)
        {
            var Films = Film.List(_connection);
            listViewFilms.Items.Clear();
            for (int i = 0; i < Films.Count; i++)
            {
                var Film = Films[i];
                ListViewItem listListViewItem = new ListViewItem(Film.FilmId.ToString());               
                listListViewItem.Tag = Film;
                listListViewItem.SubItems.Add(Film.Title);              
                listListViewItem.SubItems.Add(Film.ProdusserId.ToString());
                listListViewItem.SubItems.Add(Film.Year.ToString());
                listViewFilms.Items.Add(listListViewItem);
            }
        }
        

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            FormFilm formFilm = new FormFilm(listViewProducers.Items.Count)
            {
                Film = new Film()
            };
            if (formFilm.ShowDialog() == DialogResult.OK)
            {
                ListViewItem listListViewItem = new ListViewItem(formFilm.Film.FilmId.ToString());
                listListViewItem.Tag = formFilm.Film;
                listListViewItem.SubItems.Add(formFilm.Film.Title);
                listListViewItem.SubItems.Add(formFilm.Film.ProdusserId.ToString());
                listListViewItem.SubItems.Add(formFilm.Film.Year.ToString());
                listViewFilms.Items.Add(listListViewItem);
                listViewFilms.SelectedItems.Clear();
                listViewFilms.Items[listViewFilms.Items.Count - 1].Selected = true;


               Film.Insert(_connection, formFilm.Film);
            }
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                FormFilm formFilm = new FormFilm(listViewProducers.Items.Count)
                {
                    Film = (Film)listViewFilms.SelectedItems[0].Tag
                };
                if (formFilm.ShowDialog() == DialogResult.OK)
                {

                    listViewFilms.SelectedItems[0].SubItems[1].Text = formFilm.Film.Title;
                    listViewFilms.SelectedItems[0].SubItems[2].Text = formFilm.Film.ProdusserId.ToString();
                    listViewFilms.SelectedItems[0].SubItems[3].Text = formFilm.Film.Year.ToString();
                    Film.Update(_connection, formFilm.Film);
                }
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Аргумент не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            Film.Delete(_connection, ((Film)listViewFilms.SelectedItems[0].Tag).FilmId);
        }

        private void listViewFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewFilms.SelectedItems.Count!=0)
            pictureBoxCover.Image = ((Film)listViewFilms.SelectedItems[0].Tag).Cover;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            toolStripButtonLoadProducer_Click(null,null);
        }
    }
      
    
}
