using ShipCrash.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShipCrash.Tests
{
    public static class AppContainer
    {
        private static App app;

        public static void CreateApp()
        {
            if (app == null)
                app = new App();
        }
    }
}
