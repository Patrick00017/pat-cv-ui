using Core;
using Core.Models;
using Core.MVVM;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Navigation.Regions;
using Prism.Regions;
using Settings.Views;

namespace Settings
{
    public class SettingsModule : ModuleBase
    {
        public SettingsModule(IRegionManager regionManager) : base(regionManager)
        {
        }

        public override void OnInitialized(IContainerProvider containerProvider)
        {
            RegionManager.RequestNavigate(RegionNames.ContentRegion, MenuName.SETTINGS.ToString());
        }

        public override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>(MenuName.SETTINGS.ToString());
        }
    }
}