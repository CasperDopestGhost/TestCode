using System;
using System.Collections.Generic;
using System.Text;

namespace Homes
{
    public class HomeFactory
    {
        IHome home = null;

        public HomeFactory( IHome concreteHome)
        {
            home = concreteHome;
        }

        public Home BuildTheHome()
        {
          return  home.BuildHome();
        }

    }
}
