using System;
using XFExitSample.DependencyServices;
using XFExitSample.DependencyServices.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(ApplicationUtil_iOS))]

namespace XFExitSample.DependencyServices.iOS
{
    public class ApplicationUtil_iOS : IApplicationUtil
    {
        /// <summary>
        /// アプリ終了
        /// </summary>
        public void Exit()
        {
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }
    }
}
