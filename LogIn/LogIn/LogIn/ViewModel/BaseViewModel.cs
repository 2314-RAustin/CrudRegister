using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
using System.ComponentModel;

namespace LogIn
{
    //[ImplementPropertyChanged]
    public class BaseViewModel : IsNotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
        /////// <summary>
        /////// Call this to fire a <see cref="PropertyChanged"/> event
        /////// </summary>
        /////// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }


    }
}

