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
        private int _ID;
        private string _Full_Name {  get; set; }
        private string _UserName { get; set; }
        private string _Password { get; set; }
        private int _AdminLevel { get; set; }


        public clsAdmin()
        {
            _ID = -1;
            _Full_Name = string.Empty;
            _UserName = string.Empty;
            _Password = string.Empty;
            _AdminLevel = 0;
        }

        private clsAdmin(int ID, string FullName, string UserName, string Password, int AdminLevel)
        {
            this._ID = ID;
            this._Full_Name = FullName;
            this._UserName = UserName;
            this._Password = Password;
            this._AdminLevel = AdminLevel;
        }




        public static bool IsExist(string UserName)
        {
            return clsAdminDataAccess.IsExist(UserName);
        }
       

        public static bool GetAdminObjectByUserNameAndPassword(string UserName, string Password)
        {
            int ID = -1, AdminLevel = 0;
            string FullName = string.Empty;

            return clsAdminDataAccess.GetAdminObjectByUserNameAndPassword(UserName, Password, ref ID, ref FullName, ref AdminLevel);

        }




















    }


    public class clsCustomer
    {

        private string _Full_Name { get; set; }
        private string _Phone { get; set; }
        private string _Address { get; set; }
        private string _Details { get; set; }


        public clsCustomer()
        {
            _Full_Name = "";
            _Phone = "";
            _Address = "";
            _Details = "";
        }

        private clsCustomer(string FullName,string  Phone,string Address,string Details)
        {
            this._Full_Name = FullName;
            this._Phone = Phone;
            this._Address = Address;
            this._Details = Details;
        }





    }


    public class clsBook
    {

        private long _UID {  get; set; }
        private string _Name { get; set; }
        private DateTime _PublishDate { get; set; }
        private int _Version { get; set; }
        private string _PublishHouse { get; set; }
        private int _Copies { get; set; }
        private int _AdminID { get; set; }
        private int _CategoryID { get; set; }
        private int _SubCategoryID { get; set; }
        private string _Location { get; set; }


        public clsBook()
        {
            _UID = 0;
            _Name = "";
            _PublishDate = DateTime.Now;
            _Version = 0;
            _PublishHouse = "";
            _Copies = 0;
            _AdminID = 0;
            _CategoryID = 0;
            _SubCategoryID = 0;
            _Location = "";
        }


        private clsBook(long  UID,string Name , DateTime PublishDate,int Version,string PublishHouse
            ,int Copies,int AdminID,int CategoryID,int SubCategoryID,string Location)
        {
            this._UID = UID;
            this._Name = Name;
            this._PublishDate = PublishDate;
            this._Version = Version;
            this._PublishHouse = PublishHouse;
            this._Copies = Copies;
            this._AdminID = AdminID;
            this._CategoryID = CategoryID;
            this._SubCategoryID = SubCategoryID;
            this._Location = Location;
        }




    }








}
