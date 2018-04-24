using System;
using System.Collections.Generic;
using System.Text;

namespace Homes
{
    public class Ranch:IHome
    {
        public Home BuildHome()
        {
            Home ranch = new Home() { stories = 1, bathrooms = 3, bedrooms = 4 };

            return ranch;
        }
    }
}
