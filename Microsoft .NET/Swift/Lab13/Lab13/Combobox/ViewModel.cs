using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    public class ViewModel
    {
        public ObservableCollection<Producer> Producers { get; set; }

        
        public ViewModel(ObservableCollection<Producer> producers)
        {
            Producers = producers;

        }
    }
}
