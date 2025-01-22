using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace authorization_sokolova_22._102
{
    internal class Helper
    {
        public static Entities1 _context;

        public static Entities1 GetContext()
        {
            if (_context == null)
            {
                _context = new Entities1 ();
            }
            return _context;
        }

        public string GetRole(Roles role)
        {
            return role.name;
        }
    }
}
