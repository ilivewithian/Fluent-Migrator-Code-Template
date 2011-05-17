using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Migrator.Net_Templates
{
    public static class SystemTime
    {
        public static Func<DateTime> Now = () => DateTime.Now;
    }
}
