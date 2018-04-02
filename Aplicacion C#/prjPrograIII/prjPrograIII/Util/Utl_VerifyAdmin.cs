using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace prjPrograIII.Util
{
    static class Utl_VerifyAdmin
    {

        /// <summary>
        /// Used to check if the application is running on admin rights
        /// </summary>
        /// <returns></returns>
        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                    .IsInRole(WindowsBuiltInRole.Administrator);
        }

    }
}
