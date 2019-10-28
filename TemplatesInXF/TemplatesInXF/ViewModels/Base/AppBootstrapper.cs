namespace TemplatesInXF.ViewModels.Base
{
    using Splat;

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
