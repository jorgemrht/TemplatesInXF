using Splat;

namespace TemplatesInXF.ViewModels.Base
{
    public class AppBootstrapper : IEnableLogger
    {
        public static AppBootstrapper Instance { get; } = new AppBootstrapper();

        public AppBootstrapper() { }

        private void RegisterDependencies()
        {

        }

        public void Build() => RegisterDependencies();
    }
}
