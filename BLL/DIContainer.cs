using DryIoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class DIContainer
    {
        public static void RegisterRepo(this IContainer container)
        {
            #region debug and test area
#if DEBUG || MYTESTS

#endif
            #endregion
        }


        public static void RegisterServices(this IRegistrator reg)
        {
            #region debug and test area
#if DEBUG || MYTESTS

#endif
            #endregion

        }


    }
}
