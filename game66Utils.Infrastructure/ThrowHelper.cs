using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Infrastructure.DataLayer;

namespace game66Utils.Infrastructure
{
    public static class ThrowHelper
    {
        public static void CheckNull(this object obj, string paramName)
        {
            if (obj == null)
                throw new ArgumentNullException(paramName);
        }
    }
}
