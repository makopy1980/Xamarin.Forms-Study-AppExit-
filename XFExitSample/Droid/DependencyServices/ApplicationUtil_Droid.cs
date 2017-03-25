using System;
using Android.OS;
using XFExitSample.DependencyServices;
using XFExitSample.DependencyServices.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(ApplicationUtil_Droid))]

namespace XFExitSample.DependencyServices.Droid
{
    public class ApplicationUtil_Droid : IApplicationUtil
    {
        /// <summary>
        /// アプリ終了
        /// </summary>
        public void Exit()
        {
            //System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
            Process.KillProcess(Process.MyPid());
        }
    }
}
