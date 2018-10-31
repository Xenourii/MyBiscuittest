using MyBiscuitTest.Services;

namespace MyBiscuitTest.Droid.Services
{
    public class PlatformInfo : IPlatformInfo
    {
        public string AndroidVersion()
        {
            return Android.OS.Build.VERSION.Release;
        }
    }
}