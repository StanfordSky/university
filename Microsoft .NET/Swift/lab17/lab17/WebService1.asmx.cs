using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ClassLibraryData;
using ClassLibraryMethods;

namespace lab17
{
   
    /// <summary>
    /// Сводное описание для WebService
    /// </summary>
    [WebService(

        Description = "lab17 web serwice",
        Name = "lab17 ",
        Namespace = "http://microsoft.com/webservices/"

        )]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod(Description = "Get a list of Films")]
        public List<FilmDTO> GetFilms()
        {
            ServiceMethods methods = new ServiceMethods();
            return methods.GetFilms();
        }

        [WebMethod(Description = "Get a list of Producers")]

        public List<ProducerDTO> GetProducers()
        {
            ServiceMethods methods = new ServiceMethods();
            return methods.GetProducers();
        }

        [WebMethod(Description = "Add new Producer")]

        public void AddProducer(string firstName, string lastName)
        {
            ServiceMethods methods = new ServiceMethods();
            methods.AddProducer(firstName, lastName);
        }

        [WebMethod(Description = "Delete a Producer")]

        public void RemoveProducer(int id)
        {
            ServiceMethods methods = new ServiceMethods();
            methods.DeleteProducer(id);
        }
    }
}
