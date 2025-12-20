using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MVVM
{
    public abstract class ModuleBase : IModule
    {
        protected IRegionManager RegionManager {  get; set; }

        public ModuleBase(IRegionManager regionManager) {
            RegionManager = regionManager;
        }
        public abstract void OnInitialized(IContainerProvider containerProvider);

        public abstract void RegisterTypes(IContainerRegistry containerRegistry);
    }
}
