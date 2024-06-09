using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementDataBaseLayer;

namespace LibraryManagementBackEndLayer
{
    public class clsAdmin
    {

        public static bool IsExist(string UserName)
        {
            return clsAdminDataAccess.IsExist(UserName);
        }
       


    }


    public class clsCustomers
    {


        



    }


    public class clsBooks
    {








    }


}
