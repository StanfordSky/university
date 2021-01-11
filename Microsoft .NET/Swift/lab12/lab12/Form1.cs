using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_dotNetDataSet.Film". При необходимости она может быть перемещена или удалена.
            this.filmTableAdapter.Fill(this.dB_dotNetDataSet.Film);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_dotNetDataSet.Producer". При необходимости она может быть перемещена или удалена.
            this.producerTableAdapter.Fill(this.dB_dotNetDataSet.Producer);

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormFilm(-1);
            form.ShowDialog();
            filmTableAdapter.Fill(dB_dotNetDataSet.Film);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filmBindingSource.RemoveCurrent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            producerTableAdapter.Update(dB_dotNetDataSet.Producer);
            filmTableAdapter.Update(dB_dotNetDataSet.Film);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmBindingSource.EndEdit();
            this.filmTableAdapter.Update(dB_dotNetDataSet.Film);
        }

        private void loadFilmsTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.filmTableAdapter.Fill(dB_dotNetDataSet.Film);
        }

        private void loadProducersTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.producerTableAdapter.Fill(dB_dotNetDataSet.Producer);
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            var form = new FormFilm(filmBindingSource.Position);
            form.ShowDialog();
            filmTableAdapter.Fill(dB_dotNetDataSet.Film);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(pd_PrintSingle);
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Font PrintFont;
        private void pd_PrintSingle(object sender, PrintPageEventArgs ev)
        {
            float leftMargin = ev.MarginBounds.Left;
            float yPos = ev.MarginBounds.Top;
            string line;
            DataRowView dataRowView = (DataRowView)filmBindingSource.Current;
            DB_dotNetDataSet.FilmRow row = (DB_dotNetDataSet.FilmRow)dataRowView.Row;

            PrintFont = new Font("Arial", 20, FontStyle.Bold);
            line = "Информация о фильме:";
            ev.Graphics.DrawString(line, PrintFont, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += PrintFont.GetHeight(ev.Graphics);


            PrintFont = new Font("Arial", 14);
            line = $"ID = {row.id}\r\n" +
                   $"Название= {row.Title}\r\n" +
                   $"Год = {row.year}\r\n" +
                   $"id режисера = {row.producer.ToString()}\r\n";
                  

            ev.Graphics.DrawString(line, PrintFont, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += PrintFont.GetHeight(ev.Graphics) * 10;

            try
            {
                using (var ms = new MemoryStream(row.cover))
                {
                    ev.Graphics.DrawImage(Image.FromStream(ms), new Point((int)leftMargin, (int)yPos));
                }
            }
            catch (Exception)
            { }

            ev.HasMorePages = false;
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog preview = new PrintPreviewDialog();
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(pd_PrintSingle);
                preview.Document = pd;
                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
