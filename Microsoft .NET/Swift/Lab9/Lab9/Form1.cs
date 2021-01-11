using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string _encoding;
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var writer = new System.IO.StreamWriter(
                    saveFileDialog1.FileName, false,
                                        System.Text.Encoding.GetEncoding(_encoding));
                    writer.Write(textBoxMain.Text);
                    writer.Close();

                }
                catch (Exception ex)
                { // отчет о других ошибках
                    MessageBox.Show(ex.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == String.Empty) return;
            // Чтение текстового файла
            try
            {
                var Reader = new System.IO.StreamReader(
                openFileDialog1.FileName, Encoding.GetEncoding(_encoding));
                textBoxMain.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message + "\nНет такого файла",
                         "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            { // отчет о других ошибках
                MessageBox.Show(ex.Message,
                     "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxMain.Clear();
            openFileDialog1.FileName = @"\TextFile1.txt";

            openFileDialog1.Filter =
                     "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Filter =
                     "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";

           
            
            comboBoxEncoding.Items.Add(Encoding.Default.WebName);
            comboBoxEncoding.Items.Add(Encoding.ASCII.WebName);
            comboBoxEncoding.Items.Add(Encoding.UTF8.WebName);          
            comboBoxEncoding.Items.Add(Encoding.Unicode.WebName);
            comboBoxEncoding.Items.Add(Encoding.UTF32.WebName);
            comboBoxEncoding.SelectedIndex = 0;
        }

        private void comboBoxEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {

            var old_encoding = _encoding;
            _encoding = comboBoxEncoding.SelectedItem.ToString();
            if (textBoxMain.Text != "")
            {
              
                byte[] byte_text = Encoding.GetEncoding(old_encoding).GetBytes(textBoxMain.Text);
                var encoded_text = Encoding.Convert(Encoding.GetEncoding(old_encoding), Encoding.GetEncoding(_encoding), byte_text);
                textBoxMain.Text = Encoding.GetEncoding(_encoding).GetString(encoded_text);
            }
        }
    }
}
