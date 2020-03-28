namespace TemplatesInXF.Base
{
    using System.Reactive.Disposables;
    using TemplatesInXF.Services;
    using Xamarin.Forms;

    public class BaseContentView : ContentView
    {
        protected readonly ILogService logService;
        protected CompositeDisposable disposables;

        public BaseContentView()
        {
            logService = DependencyService.Get<ILogService>();
            disposables = new CompositeDisposable();
        }

        ~BaseContentView()
        {
            disposables?.Dispose();
            disposables = null;
        }
    }
}
