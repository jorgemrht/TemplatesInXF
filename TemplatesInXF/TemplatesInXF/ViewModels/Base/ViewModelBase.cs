namespace TemplatesInXF.ViewModels.Base
{
    using ReactiveUI;
    using ReactiveUI.Fody.Helpers;
    using System;
    using System.Reactive.Disposables;
    using System.Threading.Tasks;

    public class ViewModelBase : ReactiveObject, IDisposable
    {
        protected CompositeDisposable Disposables;
        public bool Loading { [ObservableAsProperty] get; }

        protected ViewModelBase()
        {
            Disposables = new CompositeDisposable();
        }

        public void Dispose() => Disposables.Dispose();

        public virtual Task InitializeAsync(object navigationData) => Task.FromResult(false);
    }
}
