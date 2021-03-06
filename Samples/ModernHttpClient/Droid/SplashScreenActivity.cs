using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace Droid
{
    [Activity(Label = "Collection", MainLauncher = true, NoHistory = true, Icon = "@drawable/icon")]
    public class SplashScreenActivity
        : MvxSplashScreenActivity
    {
        public SplashScreenActivity()
            : base(Resource.Layout.splashscreen)
        {
        }
    }
}