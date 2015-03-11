using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation
{
    public class PluginLoader : IMvxPluginLoader
    {
        public void EnsureLoaded()
        {
            var manager = Mvx.Resolve<IMvxPluginManager>();
            manager.EnsurePlatformAdaptionLoaded<PluginLoader>();
        }
    }
}
