using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BankDataLayer;
using System.Security.Policy;
using System.Xml.Linq;

namespace BankBussinessLayer
{
    public class clsClient
    {

        public string AccNO {  get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int PINCode { get; set; }

        public string Phone { get; set; }

        public int Balance { get; set; }

        public string ImagePath {  get; set; }

        public clsClient()
        {
            this.AccNO = "";
            this.Name = "";
            this.Email = "";
            this.PINCode = -1;
            this.Phone = "";
            this.Balance = -1;
            this.ImagePath = "";

        }

        private clsClient( string accNO, string name, string email, int pINCode, string phone, int balance,string imagePath)
        {
            AccNO = accNO;
            Name = name;
            Email = email;
            PINCode = pINCode;
            Phone = phone;
            Balance = balance;
            ImagePath = imagePath;
        }

        public static DataTable GetAllClients(bool OrderByASC = true)
        {
            return BankDataLayer.clsClientInfo.GetAllClients(OrderByASC);
        }

        public static int AddNewClient(string AccountNumber, string Name, string Phone, string Email, int PINCode, int Balance,string ImagePath,string Username)
        {
            return clsClientInfo.AddNewClient(AccountNumber, Name, Phone, Email, PINCode, Balance, ImagePath,Username);
        }

        public static DataTable FindClientByAccNO(string AccountNumber)
        {
            
           return clsClientInfo.FindClientByAccNO(AccountNumber);

        }

        public static DataTable FindClientByBalance(string Balance)
        {
            
           return clsClientInfo.FindClientByBalance(Balance);

        }

        public static DataTable FindClientByName(string Name)
        {
            
           return clsClientInfo.FindClientByName(Name);

        }

        public static DataTable GetAllClientsAndOrderBalances(bool OrderBalancesACS)
        {
            return clsClientInfo.GetAllClientsAndOrderBalances(OrderBalancesACS);
        }

        


        public static clsClient GetClientInfo(string AccNO)
        {
            if(IsClientExist(AccNO))
            {
                DataTable dt = clsClientInfo.FindClientByAccNO(AccNO);

                foreach(DataRow row in dt.Rows)
                {
                    string accNo = row["AccountNO"].ToString();
                    string name = row["Name"].ToString();
                    string phone = row["Phone"].ToString();
                    string email = row["Email"].ToString();
                    int pINCode = Convert.ToInt32(row["PINCode"]);
                    int balance = Convert.ToInt32(row["Balance"]);
                    string imagePath = row["ImagePath"].ToString();

                    return new clsClient(accNo,name,email,pINCode,phone,balance, imagePath);

                }
            }

            return null;
        }

        public static bool IsClientExist(string accountNo)
        {
            return clsClientInfo.IsClientExist(accountNo);
        }

        public bool UpdateClient(clsClient ClientToUpdate)
        {
            return clsClientInfo.UpdateClientInfo(ClientToUpdate.AccNO,ClientToUpdate.Name,ClientToUpdate.Phone,ClientToUpdate.Email,ClientToUpdate.PINCode,ClientToUpdate.Balance,ClientToUpdate.ImagePath);

        }

        public bool DepositOp(double Amount)
        {
            return clsClientInfo.DepositBalance(this.AccNO, Amount);
        }

        public bool WithdrawOp(double Amount)
        {
            return clsClientInfo.WithdrawBalance(this.AccNO, Amount);
        }

        public static bool DeleteClient(string AccountNumber)
        {
            return clsClientInfo.DeleteClient(AccountNumber);
        }

        public static string GetTotalOfBalances()
        {
            return clsClientInfo.CalcTotalBalances().ToString();
        }

    }

    public class clsUser
    {

        public enum enPermissions
        {
            enAll = -1,
            enClientList = 1,
            enTransactions = 2,
            enManageUsers = 4,
            enLoginRegister = 8
        }

        public enPermissions AllPermissions;

        public int ID;
        public string Name;
        public string Email;
        public string Phone;
        public string Username;
        public string Password;
        public string ImagePath;
        public string Address;
        public int Permissions;

        private clsUser( string Username, string Name, string Email, string Phone, string Password, int Permissions, string imagePath, string address)
        {
            this.ID = ID;
            this.Name = Name;
            this.Email = Email;
            this.Phone = Phone;
            this.Username = Username;
            this.Password = Password;
            this.Permissions = Permissions;
            this.ImagePath = imagePath;
            this.Address = address;
        }

        private clsUser( string name, string email, string phone, string username, string password, string imagePath, string address, int permissions)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Username = username;
            Password = password;
            ImagePath = imagePath;
            Address = address;
            Permissions = permissions;
        }

        public clsUser()
        {
            this.ID = -1;
            this.Name = "";
            this.Email = "";
            this.Phone = "";
            this.Username = "";
            this.Password = "";
            this.Address = "";
            this.ImagePath = "";
            this.Permissions = 0;
        }

        public bool IsUserHasPermissions(clsUser.enPermissions permissions)
        {
            return (this.Permissions & (int)permissions) == (int)permissions;
        }


        private static clsUser CurrentUser;

        public static clsUser FindByUsername(string username)
        {
            string Name = "", Email = "", Password = "", Phone = "", ImagePath = "", Address = "";
            int Permissions = 0, ID = -1;

            if (clsUsersInfo.FindByUsername(username, Password, ref ID, ref Name, ref Phone,ref ImagePath,ref Address, ref Email, ref Permissions))
            {
                CurrentUser = new clsUser( username, Name, Email, Phone, Password, Permissions, ImagePath, Address);
                return CurrentUser;
            }
            return new clsUser() ;
        }

        public static DataTable GetAllTransferLogs(bool Find = false, string sAccNO = "",bool SortByASC = true)
        {
            return clsUsersInfo.GetAllTransferLogList(Find,sAccNO, SortByASC);
        }

        public static DataTable GetAllUsers(string Username,bool Find = false,bool SortedASC = true,string OrderBy = "",string SearchText = "")
        {
            DataTable dt1 = clsUsersInfo.GetAllUsers(Find, SortedASC, OrderBy, SearchText);
            if (Username != "admin")
            {

                foreach (DataRow datarow in dt1.Rows)
                {
                    if (datarow["Username"].ToString() != Username)
                        datarow["Password"] = "****";
                }
            }

            return dt1;
        }

        public static bool FindByUsernameAndPass(string username, string Password)
        {

            string Name = "", Email = "", Phone = "", ImagePath = "",Address = "";
            int Permissions = 0, ID = -1;

            if (clsUsersInfo.FindByUsernameAndPass(username, Password, ref ID, ref Name, ref Phone,ref ImagePath,ref Address, ref Email, ref Permissions))
            {
                CurrentUser = new clsUser( username, Name, Email, Phone, Password, Permissions,ImagePath,Address);
                return true;
            }

            return false;
        }

        public bool SaveLoginRecord()
        {
            return clsUsersInfo.SaveLoginLog(this.Username, this.Password, DateTime.Now, this.Permissions);
        }

        public static DataTable GetAllLoginLogs(bool Find = false, bool SortedASC = true, string OrderBy = "",string Username = "")
        {
            return clsUsersInfo.GetAllLoginLogs(Find, SortedASC, OrderBy,Username);
        }

        public static bool SaveRecordTransferLogToTable(DateTime OpDate, string Username, string sAccNO, string rAccNO, Double Amount, Double sBalance, Double rBalance)
        {
            return clsUsersInfo.SaveTransferLog(OpDate, Username, sAccNO, rAccNO, Amount, sBalance, rBalance);
        }

        public static bool AddNewUser(string Username,string Name, string Email,string Phone,string Password,int Permissions,string ImagePath,string Address)
        {
            return clsUsersInfo.AddNewUser(Username, Name, Phone, Email, Permissions, Password, ImagePath, Address); 
        }
        
        public static DataTable FindUsersByName(string Name)
        {

            return clsUsersInfo.FindUserByName(Name);

        }

        public static clsUser GetUserInfo(string Username)
        {
            if (IsUsersExist(Username))
            {
                DataTable dt = clsUsersInfo.FindUserByUsername(Username);

                foreach (DataRow row in dt.Rows)
                {
                    
                    string username = row["Username"].ToString();
                    string name = row["Name"].ToString();
                    string phone = row["Phone"].ToString();
                    string email = row["Email"].ToString();
                    string password = row["Password"].ToString();
                    int permissions = Convert.ToInt32(row["Permissions"]);
                    string imagePath = row["ImagePath"].ToString();
                    string address = row["Address"].ToString();

                    return new clsUser(username, name,  email, phone, password, permissions, imagePath, address);

                }
            }

            return null;
        }

        public static bool IsUsersExist(string Username)
        {
            return clsUsersInfo.IsUserExist(Username);
        }
        
        public static bool UpdateUser(clsUser UserToUpdate)
        {
            return clsUsersInfo.UpdateUserInfo(UserToUpdate.Username, UserToUpdate.Name, UserToUpdate.Phone, UserToUpdate.Email, UserToUpdate.Permissions, UserToUpdate.Password, UserToUpdate.ImagePath, UserToUpdate.Address);

        }

        public static bool DeleteUser(string Username)
        {
            if(Username == "admin")
            {
                return false;
            }
            return clsUsersInfo.DeleteUser(Username);
        }



    }

    public class clsCurrency
    {

        public string CurrencyName;
        public string CurrencyCode;
        public string Country;
        public decimal CurrencyRate;

        public clsCurrency()
        {
            this.CurrencyRate = 0;
            this.CurrencyName = "";
            this.CurrencyCode = "";
            this.Country = "";
        }

        private clsCurrency(string currencyName, string currencyCode, string country, decimal currencyRate)
        {
            CurrencyName = currencyName;
            CurrencyCode = currencyCode;
            Country = country;
            CurrencyRate = currencyRate;
        }

        public static DataTable GetAllCurrencies(bool FindCurrency = false, bool SortedASC = true, string FindBy = "", string SearchText = "")
        {
            return clsCurrencies.GetAllCurrencies(FindCurrency, SortedASC, FindBy, SearchText);
        }


        public static clsCurrency GetCurrencyInfo(string CurrencyCode)
        {
            string Country = "", CurrencyName = "";
            decimal CurrencyRate = 0;

            clsCurrencies.GetCurrencyInfo(CurrencyCode, ref Country, ref CurrencyName, ref CurrencyRate);

            return new clsCurrency(CurrencyName, CurrencyCode, Country, CurrencyRate);
        }

        public static bool UpdateCurrencyRate(string CurrencyCode, decimal CurrencyRate)
        {
            return clsCurrencies.UpdateCurrencyRate(CurrencyCode, CurrencyRate);
        }

        public static decimal GetCurrencyRate(string CurrencyCode)
        {
            return clsCurrencies.GetCurrancyRate(CurrencyCode);
        }

        public static DataTable GetAllCurrenciesCodes()
        {
            return clsCurrencies.GetAllCurrenciesCode();
        }

        public static string GetCurrencyCode(string CurrencyCode)
        {
            return clsCurrencies.GetCurrencyCode(CurrencyCode);
        }
    
    }

}
