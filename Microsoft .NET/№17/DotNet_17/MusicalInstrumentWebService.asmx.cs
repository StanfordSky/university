using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ClassLibraryData;
using ClassLibraryMethods;

namespace DotNet_17
{
    /// <summary>
    /// Summary description for MusicalInstrumentWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MusicalInstrumentWebService : System.Web.Services.WebService
    {

        [WebMethod(Description = "Получение списка музыкальных инструментов")]
        public List<MusicaInstrumentInfo> GetMusicalInstruments()
        {
            ServiceMethods methods = new ServiceMethods();
            return methods.GetMusicaInstruments();
        }

        [WebMethod(Description = "Получение списка типов музыкальных инструментов")]
        public List<TypeOfMusicaInstruentInfo> GetTypeOfMusicalInstruments()
        {
            ServiceMethods methods = new ServiceMethods();
            return methods.GetTypeOfMusicaInstruents();
        }

        [WebMethod(Description = "Добавление типа музыкального элемента")]
        public void AddTypeOfMusicalInstrument(string title)
        {
            ServiceMethods methods = new ServiceMethods();
            methods.AddTypeOfMusicalInstrument(title);
        }


        [WebMethod(Description = "Удаление типа музыкального элемента")]
        public void DeleteTypeOfMusicalInstrument(int id, string title)
        {
            ServiceMethods methods = new ServiceMethods();
            methods.DeleteTypeOfMusicalInstrument(id, title);
        }
    }
}
