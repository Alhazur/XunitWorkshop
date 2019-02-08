using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleXunitWorkshop
{
    public class Golf
    {
        public bool VaildAngle(double angle)
        {
            if (angle >= 90 || angle <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
