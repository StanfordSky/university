using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Лаба_9
{
    public partial class Form1 : Form
    {
        private byte[] text;
        private Encoding currentEncoding;
        public Form1()
        {
            InitializeComponent();
            var encodings = Encoding.GetEncodings();
            foreach(var encoding in encodings)
            {
                encodingComboBox.Items.Add(encoding.Name);
            }            
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            try
            {
                Stream fs = new FileStream(pathTextBox.Text, FileMode.Open);
                using (StreamReader sr = new StreamReader(fs, true))
                {
                    currentEncoding = sr.CurrentEncoding;
                    text = currentEncoding.GetBytes(sr.ReadToEnd());
                }
                contentTextBox.Lines = File.ReadAllLines(pathTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllLines(pathTextBox.Text, contentTextBox.Lines, Encoding.GetEncoding(encodingComboBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changeEncodingButton_Click(object sender, EventArgs e)
        {
            try
            {                
                Encoding encoding = Encoding.GetEncoding(encodingComboBox.Text);
                contentTextBox.Lines = encoding.GetString(Encoding.Convert(currentEncoding, encoding, text)).Split('\n');             
                currentEncoding = encoding;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
