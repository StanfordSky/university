using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HtmlAgilityPack;
using System.Net;

namespace RGR
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private DB_AnimalsDataSet dB_AnimalsDataSet;
        private DB_AnimalsDataSetTableAdapters.AnimalTableAdapter DB_AnimalsDataSetAnimalTableAdapter;


     

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dB_AnimalsDataSet = (DB_AnimalsDataSet)FindResource("dB_AnimalsDataSet");

            // Загрузить данные в таблицу Producer. Можно изменить этот код как требуется.
            DB_AnimalsDataSetAnimalTableAdapter = new RGR.DB_AnimalsDataSetTableAdapters.AnimalTableAdapter();
            DB_AnimalsDataSetAnimalTableAdapter.Fill(dB_AnimalsDataSet.Animal);
            System.Windows.Data.CollectionViewSource animalViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("animalViewSource")));
            animalViewSource.View.MoveCurrentToFirst();
        }






        
       

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            RGR.DB_AnimalsDataSet dB_AnimalsDataSet = ((RGR.DB_AnimalsDataSet)(this.FindResource("dB_AnimalsDataSet")));
            // Загрузить данные в таблицу Animal. Можно изменить этот код как требуется.
            RGR.DB_AnimalsDataSetTableAdapters.AnimalTableAdapter dB_AnimalsDataSetAnimalTableAdapter = new RGR.DB_AnimalsDataSetTableAdapters.AnimalTableAdapter();
            dB_AnimalsDataSetAnimalTableAdapter.Fill(dB_AnimalsDataSet.Animal);
            System.Windows.Data.CollectionViewSource animalViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("animalViewSource")));
            animalViewSource.View.MoveCurrentToFirst();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            DB_AnimalsDataSetAnimalTableAdapter.Update(dB_AnimalsDataSet.Animal);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < animalDataGrid.SelectedItems.Count; i++)
            {
                var dataRowView = animalDataGrid.SelectedItems[i] as DataRowView;
                if (dataRowView != null)
                {
                    DataRow dataRow = dataRowView.Row;
                    dataRow.Delete();
                }
            }
            DB_AnimalsDataSetAnimalTableAdapter.Update(dB_AnimalsDataSet.Animal);
        }

        private Image CreateImageByURL(string url)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + System.IO.Path.GetFileName(url);
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri(url), path);
            }

            Image tmp = new Image();

            tmp.Source = new BitmapImage(new Uri(@"" + path));
            return tmp;
        }
        public byte[] getJPGFromImageControl(BitmapImage imageC)
        {
            MemoryStream memStream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageC));
            encoder.Save(memStream);
            return memStream.ToArray();
        }
        private string GetTextName(HtmlNode p)
        {
            var variable = "";
         
           
            foreach (var i in p.ChildNodes)
            {
                variable += i.InnerText;
            }
            variable = variable.Replace("\r\n", "");
           
            return variable;
        }
        bool checkExist(string ru_name)
        {
            foreach(DB_AnimalsDataSet.AnimalRow row in dB_AnimalsDataSet.Animal.Rows)
            {
                if (ru_name == row.Name_Rus) return true;
            }
            return false;
        }
        private void Parse_Click(object sender, RoutedEventArgs e)
        {
            var web = new HtmlWeb();
            var htmlDoc = new HtmlDocument();
            var siteurl = "https://www.moscowzoo.ru/";
            var url = "https://www.moscowzoo.ru/animals/";
            htmlDoc.LoadHtml(web.Load(url).Text);
            var sp_list_xpath = "/html/body/div/section/div/div/div/ul[2]";
            HtmlNode SpeciesListNode = htmlDoc.DocumentNode.SelectSingleNode(sp_list_xpath);
            var count = 0;
            if (SpeciesListNode != null)
            {
                HtmlNodeCollection ItemList = SpeciesListNode.ChildNodes;

                foreach( var item in ItemList)
                {
                    if (item.NodeType == HtmlAgilityPack.HtmlNodeType.Text) continue;
                    var a_child = item.ChildNodes[1];

                    var imgURL = (a_child.ChildNodes.Where(x => x.Name == "img").ToArray())[0].Attributes["src"].Value;
                    var animal_photo = CreateImageByURL(siteurl + imgURL);



                    var itemUrl = a_child.Attributes["href"].Value;//item.ChildNodes.First().Attributes["href"].Value;
                    itemUrl = itemUrl.Replace("/animals/", "");
               

                    var animalPage = new HtmlDocument();
                    animalPage.LoadHtml(web.Load(url+ itemUrl).Text);

                
                   var p_s = animalPage.DocumentNode.SelectNodes("//div[contains(@class, 'content-text')]//p");
                   // var p_s = Animal_info_Node.ChildNodes.Where(x => x.Name == "p").ToArray();
                    var rus_name = GetTextName(p_s[1]);
                    var lat_name = GetTextName(p_s[2]);
                    var eng_name = GetTextName(p_s[3]);
                    rus_name = rus_name.Replace("Русское название – ", "");
                    lat_name = lat_name.Replace("Латинское название – ", "");
                    eng_name = eng_name.Replace("Английское название – ", "");


                    if (!checkExist(rus_name))
                    {
                        var row = dB_AnimalsDataSet.Animal.NewAnimalRow();

                        row.Name_Rus = rus_name;
                        row.Name_Latin = lat_name;
                        row.Name_Eng = eng_name;
                        row.photo = getJPGFromImageControl(animal_photo.Source as BitmapImage);

                        dB_AnimalsDataSet.Animal.Rows.Add(row);
                       // count++;
                       // if (count > 3) break;
                    }


                }
            }
        }

        private void LoadImage_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {

                DefaultExt = "All files",
                Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|All files|*.*"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                if (animalDataGrid.SelectedItems.Count > 0)
                {
                    var dataRowView = animalDataGrid.SelectedItems[0] as DataRowView;
                    if (dataRowView != null)
                    {
                        var dataRow = dataRowView.Row as DB_AnimalsDataSet.AnimalRow;
                        if (dataRow != null)
                        {
                            dataRow.photo = File.ReadAllBytes(openFileDialog.FileName);
                        }
                    }
                }
            }
        }
    }
}

