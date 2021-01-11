using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab9_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string s = "rfrfr";
            switch (s)
            {
                case "re":
                    break;
            }

        }
        private void Process()
        {
            var inp = textBoxInput.Text;
            textBoxOutput.Clear();
            var match_result = Regex.Match(inp, "switch[\\s]*\\([\\s]*[\\w]{1,}[\\s]*\\)[\\s]*\\{[\\s\\w:;\".]*\\}");//. должна обозначать любой символ но это не работает

            //var match_result = Regex.Match(inp, "switch\\( [\\][\\w]?\\)\\([\\d]?\\) \\{[\\w\\s]*\\}");
            if (match_result.Success)
            {
                textBoxOutput.Text = "Блок switch найден. Варианты выбора:\r\n";

                Regex rx1 = new Regex("case[\\s]*(\")[\\w\\s\\.]+\"[\\s]*:");
                Regex rx2 = new Regex("case[\\s]*[\\d]+[\\s]*:");
        
                var match1 = rx1.Match(inp);
                var match2 = rx2.Match(inp);
                while (match1.Success || match2.Success)
                {
                    

                    if (match1.Success)
                    {
                        var val = match1.Value.Replace("\r\n", "");
                        var t = val.Split('\"');
                        textBoxOutput.Text += t[1] + "\r\n";
                        inp = inp.Remove(match1.Index, match1.Length);
                    }
                    else
                    {
                        var val = match2.Value;
                        val = val.Replace(" ", "");
                        val = val.Remove(0, 4);
                        val = val.Remove(val.Length-1, 1);
                        textBoxOutput.Text += val + "\r\n";
                        inp = inp.Remove(match2.Index, match2.Length);

                    }
                   
                    match1 = rx1.Match(inp);
                    match2 = rx2.Match(inp);
                }
            }
            else
            {
                textBoxOutput.Text = "Блок switch для языка C#  не найден\r\n";
            }
        }
        private void buttonProcess_Click(object sender, EventArgs e)
        {
            Process();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == String.Empty) return;
            // Чтение текстового файла
            try
            {
                var Reader = new System.IO.StreamReader(
                openFileDialog1.FileName, Encoding.Default);
                textBoxInput.Text = Reader.ReadToEnd();
                Reader.Close();
                labelFile.Text = openFileDialog1.FileName;
                labelFile.ForeColor = Color.Black;
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
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            Process();
        }
    }
}
