using FlightsSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2407_Q9_Search_Flight_No
{
    public class MainWindowViewModel
    {
        public Flight1 Ft { get; set; }

        public MainWindowViewModel()
        {
            Ft = new Flight1();
        }      

    }
}
