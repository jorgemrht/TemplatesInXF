namespace TemplatesInXF
{
    using TemplatesInXF.Features;
    using TemplatesInXF.Services;
    using Xamarin.Forms;

    public partial class App : Application
    {
        private readonly ICacheService cacheService;
        private readonly ILogService logService;
        private readonly IExceptionHandlersService exceptionHandlersService;

        public App()
        {
            cacheService = DependencyService.Get<ICacheService>();
            logService = DependencyService.Get<ILogService>();
            exceptionHandlersService = DependencyService.Get<IExceptionHandlersService>();

            InitLocalization();
            InitializeComponent();

            NavigationPage navigationPage = new NavigationPage(new OnboardingView() { ViewModel = new OnboardingViewModel() });
            NavigationPage.SetHasNavigationBar(navigationPage.CurrentPage, false);
            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
            logService.Start();
            cacheService.Start();

            #if DEBUG || MOCK
            exceptionHandlersService.ShowExceptionFile();
            #endif
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        private void InitLocalization()
        {
        }
    }
}

