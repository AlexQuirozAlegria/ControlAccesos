using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesos.DesktopUI
{
    internal static class StaticSession
    {
        private static string _jwtToken;

        public static string JwtToken
        {
            get => _jwtToken;
            set => _jwtToken = value;
        }
    }
}
