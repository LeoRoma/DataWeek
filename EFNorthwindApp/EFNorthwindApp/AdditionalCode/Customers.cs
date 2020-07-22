using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EFNorthwindApp
{
    public partial class Customers
    {
        public override string ToString()
        {
            return $"{CustomerId}, - {ContactName} - {City}";
        }

    }
}
