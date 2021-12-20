using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;

namespace DotNet_13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        dbDataSet dbDataSet;
        DotNet_13.dbDataSetTableAdapters.MusicalInstrumentTableAdapter dbDataSetMusicalInstrumentTableAdapter;
        dbDataSetTableAdapters.TypeOfMusicalInstrumentTableAdapter dbDataSetTypeOfMusicalInstrumentTableAdapter;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            dbDataSet = FindResource("dbDataSet") as dbDataSet;
            // Load data into the table TypeOfMusicalInstrument. You can modify this code as needed.
            dbDataSetTypeOfMusicalInstrumentTableAdapter = new DotNet_13.dbDataSetTableAdapters.TypeOfMusicalInstrumentTableAdapter();
            dbDataSetTypeOfMusicalInstrumentTableAdapter.Fill(dbDataSet.TypeOfMusicalInstrument);
            System.Windows.Data.CollectionViewSource typeOfMusicalInstrumentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("typeOfMusicalInstrumentViewSource")));
            typeOfMusicalInstrumentViewSource.View.MoveCurrentToFirst();
            // Load data into the table MusicalInstrument. You can modify this code as needed.
            dbDataSetMusicalInstrumentTableAdapter = new DotNet_13.dbDataSetTableAdapters.MusicalInstrumentTableAdapter();
            dbDataSetMusicalInstrumentTableAdapter.Fill(dbDataSet.MusicalInstrument);
            System.Windows.Data.CollectionViewSource musicalInstrumentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("musicalInstrumentViewSource")));
            musicalInstrumentViewSource.View.MoveCurrentToFirst();
        }

        private void SavetypeOfMusInst_Click(object sender, RoutedEventArgs e)
        {
            dbDataSetTypeOfMusicalInstrumentTableAdapter.Update(dbDataSet.TypeOfMusicalInstrument);
        }

        private void DeletetypeOfMusInst_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < typeOfMusicalInstrumentDataGrid.SelectedItems.Count; i++)
            {
                var dataRowView = typeOfMusicalInstrumentDataGrid.SelectedItems[i] as DataRowView;
                if (dataRowView != null)
                {
                    DataRow dataRow = dataRowView.Row;
                    dataRow.Delete();
                }
            }
            dbDataSetTypeOfMusicalInstrumentTableAdapter.Update(dbDataSet.TypeOfMusicalInstrument);
        }

        private void DeleteMusInst_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < musicalInstrumentDataGrid.SelectedItems.Count; i++)
            {
                var dataRowView = musicalInstrumentDataGrid.SelectedItems[i] as DataRowView;
                if (dataRowView != null)
                {
                    DataRow dataRow = dataRowView.Row;
                    dataRow.Delete();
                }
            }
            dbDataSetMusicalInstrumentTableAdapter.Update(dbDataSet.MusicalInstrument);
        }

        private void SaveMusInst_Click(object sender, RoutedEventArgs e)
        {
            dbDataSetMusicalInstrumentTableAdapter.Update(dbDataSet.MusicalInstrument);
        }



        private void UploadPhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                DefaultExt = ".jpg",
                Filter = "Image Files(*.jpg; *.jpeg)|*.jpg; *.jpeg;"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                if (musicalInstrumentDataGrid.SelectedItems.Count > 0)
                {
                    if (musicalInstrumentDataGrid.SelectedItems[0] is DataRowView dataRowView)
                    {
                        if (dataRowView.Row is dbDataSet.MusicalInstrumentRow dataRow)
                        {
                            dataRow.Image = File.ReadAllBytes(openFileDialog.FileName);
                        }
                    }
                }
            }
        }
                
        private void RemovePhoto_Click(object sender, RoutedEventArgs e)
        {
            if (musicalInstrumentDataGrid.SelectedItems.Count > 0)
            {
                if (musicalInstrumentDataGrid.SelectedItems[0] is DataRowView dataRowView)
                {
                    if (dataRowView.Row is dbDataSet.MusicalInstrumentRow dataRow)
                    {
                        dataRow.Image = null;
                    }
                }
            }
        }

        private void LoadImage_OnClick(object sender, RoutedEventArgs e)
        {
            UploadPhoto_Click(sender,e);
        }
    }
}
