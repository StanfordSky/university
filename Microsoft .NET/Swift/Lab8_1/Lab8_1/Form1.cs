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

namespace Lab8_1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

            fileSystemWatcher1 = new FileSystemWatcher();
            fileSystemWatcher1.Path = "C:\\Users\\Professional";
     
            fileSystemWatcher1.NotifyFilter = NotifyFilters.LastWrite;
            fileSystemWatcher1.Changed += fileSystemWatcher1_Changed;



           
            fileSystemWatcher1.Changed += new FileSystemEventHandler(fileSystemWatcher1_Changed);


        }
        delegate void SetStringDelegate(string parameter);
        void SetResult(string result)
        {
            if (!InvokeRequired)
                textBoxMain.Text = result;
            else
                Invoke(new SetStringDelegate(SetResult), new object[] { result });
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == String.Empty) return;
            // Чтение текстового файла
            try
            {
                var Reader = new System.IO.StreamReader(
                openFileDialog1.FileName, Encoding.GetEncoding(1251));
                textBoxMain.Text = Reader.ReadToEnd();
                Reader.Close();
                string fileName = Path.GetFileName(openFileDialog1.FileName);
                fileSystemWatcher1.Filter = fileName;
                fileSystemWatcher1.EnableRaisingEvents = true;

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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var writer = new System.IO.StreamWriter(
                    saveFileDialog1.FileName, false,
                                        System.Text.Encoding.GetEncoding(1251));
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
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {


           try
           {
               var Reader = new System.IO.StreamReader(fileSystemWatcher1.Path+"\\"+
               fileSystemWatcher1.Filter, Encoding.GetEncoding(1251));
               
             var result= Reader.ReadToEnd();
               
               Reader.Close();
                SetResult(result);

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
    }
}
