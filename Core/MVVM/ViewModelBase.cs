using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MVVM
{
    public abstract class ViewModelBase : BindableBase, IDestructible
    {
        protected ViewModelBase() { }
        public virtual void Destroy() { }
    }
}
