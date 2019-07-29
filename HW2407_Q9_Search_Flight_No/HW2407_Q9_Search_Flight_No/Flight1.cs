using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2407_Q9_Search_Flight_No
{
    public class Flight1 : INotifyPropertyChanged
    {
        private string origin_Country_Code;
        public string Origin_Country_Code
        {
            get
            {
                return this.origin_Country_Code;
            }
            set
            {
                this.origin_Country_Code = value;
                OnPropertyChanged("Origin_Country_Code");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }


        public override string ToString()
        {
            return $"Origin_Country_Code number {Origin_Country_Code}";
        }
    }
}
