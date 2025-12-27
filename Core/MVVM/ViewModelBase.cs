using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.MVVM
{
    public abstract class ViewModelBase : BindableBase, IDestructible, INotifyPropertyChanged
    {
        protected ViewModelBase() { }
        public virtual void Destroy() { }

        public event PropertyChangedEventHandler PropertyChanged;

        public void onPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
