using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryData;

namespace ClassLibraryMethods
{
    public class ServiceMethods
    {

        public List<FilmDTO> GetFilms()
        {
            List<FilmDTO> Films = new List<FilmDTO>();
            var dataset = new DB_dotNetDataSet();
            var FilmsAdapter = new ClassLibraryData.DB_dotNetDataSetTableAdapters.FilmTableAdapter();
            FilmsAdapter.Fill(dataset.Film);
            var ProducersAdapter = new ClassLibraryData.DB_dotNetDataSetTableAdapters.ProducerTableAdapter();
            ProducersAdapter.Fill(dataset.Producer);

            Films = (from item in dataset.Film
                     select new FilmDTO()
                     {
                         Title = item.Title,
                         year = item.year,
                         producer = item.producer

                     }).ToList();

            return Films;
        }

        public List<ProducerDTO> GetProducers()
        {
            List<ProducerDTO> Producers = new List<ProducerDTO>();
            var dataset = new DB_dotNetDataSet();
            var ProducersAdapter = new ClassLibraryData.DB_dotNetDataSetTableAdapters.ProducerTableAdapter();
            ProducersAdapter.Fill(dataset.Producer);

            Producers = (from item in dataset.Producer
                       select new ProducerDTO()
                       {
                         id = item.id,
                         FirstName = item.FirstName,
                         LastName = item.LastName,
                         FullName = item.FullName
                      
                       }).ToList();


            return Producers;
        }

        public void AddProducer(string firstName,string lastName)
        {
            var dataset = new DB_dotNetDataSet();
              var ProducersAdapter = new ClassLibraryData.DB_dotNetDataSetTableAdapters.ProducerTableAdapter();
            ProducersAdapter.Fill(dataset.Producer);
            ProducersAdapter.Insert(firstName, lastName);
        }

        public void DeleteProducer(int id)
        {
            var dataset = new DB_dotNetDataSet();
            var ProducersAdapter = new ClassLibraryData.DB_dotNetDataSetTableAdapters.ProducerTableAdapter();
            ProducersAdapter.Fill(dataset.Producer);
            ProducersAdapter.DeleteQuery(id);
        }
    }
}