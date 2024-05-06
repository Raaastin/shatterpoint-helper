using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace Shatterpoint.Maui
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        public override bool DispatchKeyEvent(KeyEvent e)
        {
            if ((e.KeyCode == Keycode.Back) && (e.Action == KeyEventActions.Down))
            {
                return true;
            }
            return base.DispatchKeyEvent(e);
        }
    }
}
