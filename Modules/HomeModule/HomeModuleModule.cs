using Core;
using Core.Models;
using Core.MVVM;
using HomeModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Navigation.Regions;

namespace HomeModule
{
    public class HomeModuleModule : ModuleBase
    {
        public HomeModuleModule(IRegionManager regionManager) : base(regionManager)
        {
        }

        public override void OnInitialized(IContainerProvider containerProvider)
        {
            RegionManager.RequestNavigate(RegionNames.ContentRegion, MenuName.HOME.ToString());
        }

        public override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>(MenuName.HOME.ToString());
        }
    }
}