[assembly: Xamarin.Forms.Dependency(typeof(TemplatesInXF.Droid.Services.ExceptionHandlersService))]
namespace TemplatesInXF.Droid.Services
{
    using Android.App;
    using System.IO;
    using TemplatesInXF.Droid;
    using TemplatesInXF.Services;

    public class ExceptionHandlersService : IExceptionHandlersService
    {
        public void ShowExceptionFile()
        {
            const string errorFilename = "Fatal.log";
            string libraryPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string errorFilePath = Path.Combine(libraryPath, errorFilename);

            if (!File.Exists(errorFilePath))
            {
                return;
            }

            string errorText = File.ReadAllText(errorFilePath);
            new AlertDialog.Builder(ActivityProvider.CurrentActivity)
                .SetPositiveButton("Clear", (sender, args) =>
                {
                    File.Delete(errorFilePath);
                })
                .SetNegativeButton("Close", (sender, args) =>
                {
                    // User pressed Close.
                })
                .SetMessage(errorText)
                .SetTitle("Crash Report")
                .Show();
        }
    }
}