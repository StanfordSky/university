using ClassLibraryData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMethods
{
    public class ServiceMethods
    {
        public List<MusicaInstrumentInfo> GetMusicaInstruments()
        {
            List<MusicaInstrumentInfo> mobilki = new List<MusicaInstrumentInfo>();
            dbMusInstDataSet dataSet = new dbMusInstDataSet();
            ClassLibraryData.dbMusInstDataSetTableAdapters.MusicalInstrumentTableAdapter musicalInstrummentAdapter = new ClassLibraryData.dbMusInstDataSetTableAdapters.MusicalInstrumentTableAdapter();
            musicalInstrummentAdapter.Fill(dataSet.MusicalInstrument);
            ClassLibraryData.dbMusInstDataSetTableAdapters.TypeOfMusicalInstrumentTableAdapter producerAdapter = new ClassLibraryData.dbMusInstDataSetTableAdapters.TypeOfMusicalInstrumentTableAdapter();
            producerAdapter.Fill(dataSet.TypeOfMusicalInstrument);
            mobilki = dataSet.MusicalInstrument.Select(musicalInstrumment => new MusicaInstrumentInfo
            {
                id = musicalInstrumment.ID,
                TypeOfMusInstFK = musicalInstrumment.TypeOfMusInstFK,
                Name = musicalInstrumment.Name
            }).ToList();
            return mobilki;
        }
        public List<TypeOfMusicaInstruentInfo> GetTypeOfMusicaInstruents()
        {
            List<TypeOfMusicaInstruentInfo> producer = new List<TypeOfMusicaInstruentInfo>();
            dbMusInstDataSet dataSet = new dbMusInstDataSet();
            ClassLibraryData.dbMusInstDataSetTableAdapters.TypeOfMusicalInstrumentTableAdapter typeOfMusInstAdapter = new ClassLibraryData.dbMusInstDataSetTableAdapters.TypeOfMusicalInstrumentTableAdapter();
            typeOfMusInstAdapter.Fill(dataSet.TypeOfMusicalInstrument);
            producer = dataSet.TypeOfMusicalInstrument.Select(Producer => new TypeOfMusicaInstruentInfo
            {
                TypeOfMusInstID = Producer.TypeOfMusInstID,
                Name = Producer.Name
            }).ToList();
            return producer;
        }
        public void AddTypeOfMusicalInstrument(string title)
        {
            dbMusInstDataSet dataSet = new dbMusInstDataSet();
            ClassLibraryData.dbMusInstDataSetTableAdapters.TypeOfMusicalInstrumentTableAdapter typeOfMusInstAdapter = new ClassLibraryData.dbMusInstDataSetTableAdapters.TypeOfMusicalInstrumentTableAdapter();
            typeOfMusInstAdapter.Insert(title);
        }
        public void DeleteTypeOfMusicalInstrument(int id, string title)
        {
            dbMusInstDataSet dataSet = new dbMusInstDataSet();
            ClassLibraryData.dbMusInstDataSetTableAdapters.TypeOfMusicalInstrumentTableAdapter producerAdapter = new ClassLibraryData.dbMusInstDataSetTableAdapters.TypeOfMusicalInstrumentTableAdapter();
            producerAdapter.Delete(id, title);
        }
    }
}
