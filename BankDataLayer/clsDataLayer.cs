using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BankDataLayer
{

    public static class clsUsersInfo
    {
        public static bool FindByUsername(string Username, string Password, ref int ID, ref string Name, ref string Phone, ref string ImagePath, ref string Address, ref string Email, ref int Permissions)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "Select * From Users WHERE Username = @Username";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Name = (string)reader["Name"];
                    Password = (string)reader["Password"];
                    if (reader["ImagePath"] == DBNull.Value)
                    {
                        ImagePath = "";
                    }
                    else
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    command.Parameters.AddWithValue("@Permissions", Permissions);
                    Address = (string)reader["Address"];
                    Permissions = (int)reader["Permissions"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool FindByUsernameAndPass(string Username, string Password, ref int ID, ref string Name, ref string Phone, ref string ImagePath, ref string Address, ref string Email, ref int Permissions)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE Username COLLATE Latin1_General_BIN = @Username AND Password COLLATE Latin1_General_BIN = @Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Name = (string)reader["Name"];
                    if (reader["ImagePath"] == DBNull.Value)
                    {
                        ImagePath = "";
                    }
                    else
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    Address = (string)reader["Address"];
                    Permissions = (int)reader["Permissions"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool SaveTransferLog(DateTime OpDate, string Username, string sAccNO, string rAccNO, Double Amount, Double sBalance, Double rBalance)
        {
            bool Save = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"Insert into TransferLogTable(Date,sAccNO,rAccNO,Amount,sBalance,rBalance,Username)
                             Values (@Date,@sAccNO,@rAccNO,@Amount,@sBalance,@rBalance,@Username);
                              SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@sAccNO", sAccNO);
            command.Parameters.AddWithValue("@Date", OpDate);
            command.Parameters.AddWithValue("@rAccNO", rAccNO);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@rBalance", rBalance);
            command.Parameters.AddWithValue("@sBalance", sBalance);
            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    Save = true;
                }
            }
            catch (Exception ex)
            {
                Save = false;
            }
            finally
            {
                connection.Close();
            }

            return Save;
        }

        public static DataTable GetAllUsers(bool Find = false,bool SortedASC = true, string OrderBy = "",string SearchText = "")
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "";
            if(Find)
            {
                if (OrderBy == "" || OrderBy == "Username")
                {
                    if (SortedASC)
                        query = @"Select Name,Username,Email,Phone,Password,Permissions,ImagePath,Address From Users Where Username Like '%'+ @Username + '%'
                          Order By Username ASC";
                    else
                        query = @"Select Name,Username,Email,Phone,Password,Permissions,ImagePath,Address From Users Where Username Like '%'+ @Username + '%'
                          Order By Username DESC";
                }

                else if (OrderBy == "Address")
                {
                    if (SortedASC)
                        query = @"Select Name,Username,Email,Phone,Password,Permissions,ImagePath,Address From Users Where Address Like '%'+ @Address + '%'
                        Order By Address ASC";
                    else
                        query = @"Select Name,Username,Email,Phone,Password,Permissions,ImagePath,Address From Users Where Address Like '%'+ @Address + '%'
                      Order By Address DESC";
                }
                else if (OrderBy == "Name")
                {
                    if (SortedASC)
                        query = @"Select Name,Username,Email,Phone,Password,Permissions,ImagePath,Address From Users Where Name Like '%'+ @Name + '%'
                      Order By Name ASC";
                    else
                        query = @"Select Name,Username,Email,Phone,Password,Permissions,ImagePath,Address From Users Where Name Like '%'+ @Name + '%'
                      Order By Name DESC";
                }
            }
            else
            {
                if (OrderBy == "" || OrderBy == "Username")
                {
                    if (SortedASC)
                        query = @"Select Name,Username,Email,Phone,Password,Permissions,ImagePath,Address From Users 
                          Order By Username ASC";
                    else
                        query = @"Select Name,Username,Email,Phone,Password,Permissions,ImagePath,Address From Users 
                          Order By Username DESC";
                }

                else if (OrderBy == "Address")
                {
                    if (SortedASC)
                        query = @"Select Name,Username,Email,Phone,Password,Permissions,ImagePath,Address From Users 
                      Order By Address ASC";
                    else
                        query = @"Select Name,Username,Email,Phone,Password,Permissions,ImagePath,Address From Users 
                      Order By Address DESC";
                }
                else if (OrderBy == "Name")
                {
                    if (SortedASC)
                        query = @"Select Name,Username,Email,Phone,Password,Permissions,ImagePath,Address From Users 
                      Order By Name ASC";
                    else
                        query = @"Select Name,Username,Email,Phone,Password,Permissions,ImagePath,Address From Users 
                      Order By Name DESC";
                }
            }
                

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", SearchText);
            command.Parameters.AddWithValue("@Username", SearchText);
            command.Parameters.AddWithValue("@Address", SearchText);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
            
        }

        public static DataTable GetAllTransferLogList(bool Find = false, string sAccNO = "",bool SortByASC= true)
        {
            DataTable result = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "";


            if (!Find)
            {
                if (SortByASC)
                {
                    query = "Select Date,sAccNO,rAccNO,Amount,sBalance,rBalance,Username From TransferLogTable Order by Date ASC";
                }
                else
                {
                    query = "Select Date,sAccNO,rAccNO,Amount,sBalance,rBalance,Username From TransferLogTable Order by Date DESC";
                }
            }
            else
            {
                if (SortByASC)
                {
                    query = "Select Date,sAccNO,rAccNO,Amount,sBalance,rBalance,Username From TransferLogTable Where sAccNO Like '%' + @sAccNO + '%' Order By sAccNO ASC";
                }
                else
                {
                    query = "Select Date,sAccNO,rAccNO,Amount,sBalance,rBalance,Username From TransferLogTable Where sAccNO Like '%' + @sAccNO + '%' Order By sAccNO DESC";
                }

            }

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@sAccNO", sAccNO);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    result.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        public static bool IsUserExist(string Username)
        {
            bool IsUserExist = false;


            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT Username FROM Users WHERE Username COLLATE Latin1_General_BIN = @Username";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    IsUserExist = true;
                }
            }
            catch (Exception ex)
            {
                IsUserExist = false;
            }
            finally
            {
                connection.Close();
            }

            return IsUserExist;
        }

        public static DataTable FindUserByName(string Name)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "Select Name,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\n From Users Where Name Like '%' + @Name + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static DataTable FindUserByUsername(string Username)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "Select Name,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\nName,Username,Email,Phone,Password,Permissions,ImagePath,Address\r\n From Users Where Username Like @Username + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool AddNewUser(string Username, string Name, string Phone, string Email, int Permissions, string Password, string ImagePath, string Address)
        {
            bool IsAdded = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"Insert into Users(Name,Username,Email,Phone,Password,Permissions,ImagePath,Address)
                            Values
                             (@Name,@Username,@Email,@Phone,@Password,@Permissions,@ImagePath,@Address);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Address", Address);
            if(ImagePath == null)
            {
            command.Parameters.AddWithValue("@ImagePath",DBNull.Value);
            }
            else
            {
            command.Parameters.AddWithValue("@ImagePath",ImagePath);

            }
            command.Parameters.AddWithValue("@Permissions", Permissions);

            try
            {
                connection.Open();

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    IsAdded = true;
                }
            }
            catch (Exception ex)
            {
                IsAdded = false;
            }
            finally
            {
                connection.Close();
            }

            return IsAdded;

        }

        public static bool DeleteUser(string Username)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "Delete From Users Where Username = @Username";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();
                int EffetedRows = command.ExecuteNonQuery();
                if (EffetedRows > 0)
                {
                    IsDeleted = true;
                }

            }
            catch (Exception ex)
            {
                IsDeleted = false;
            }
            finally
            {
                connection.Close();
            }

            return IsDeleted;
        }

        public static bool UpdateUserInfo(string Username, string Name, string Phone, string Email,int Permissions, string Password, string ImagePath,string Address)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"Update Users
                            Set Name = @Name,
                                Email = @Email,
                                Phone = @Phone,
                                Password = @Password,
                                Permissions = @Permissions,
                                Address = @Address,
                                ImagePath = @ImagePath
                                Where Username = @Username";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@Password", Password);

            if (ImagePath == null)
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);

            }
            command.Parameters.AddWithValue("@Address", Address);

            try
            {
                connection.Open();

                int EffectedRows = command.ExecuteNonQuery();

                if (EffectedRows > 0)
                {
                    IsUpdated = true;
                }

            }
            catch (Exception ex)
            {
                IsUpdated = false;
            }
            finally
            {
                connection.Close();
            }

            return IsUpdated;
        }

        public static bool SaveLoginLog(string Username, string Password, DateTime DateLogin, int Permissions)
        {
            bool IsSaved = true;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"Insert Into LoginLog(Username,Password,Date,Permissions)
                              Values (@Username,@Password,@DateLogin,@Permissions)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@DateLogin", DateLogin);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    IsSaved = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return IsSaved;
        }

        public static DataTable GetAllLoginLogs(bool Find = false, bool SortedASC = true, string OrderBy = "",string Username = "")
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "";
            if (Find)
            {
                
                    if (SortedASC)
                        query = @"Select Username,Password,Date,Permissions From LoginLog Where Username Like '%'+ @Username + '%'
                          Order By Date ASC";
                    else
                        query = @"Select Username,Password,Date,Permissions From LoginLog Where Username Like '%'+ @Username + '%'
                          Order By Date DESC";
  
            }
            else
            {

                    if (SortedASC)
                        query = @"Select Username,Password,Date,Permissions From LoginLog 
                          Order By Date ASC";
                    else
                        query = @"Select Username,Password,Date,Permissions From LoginLog 
                          Order By Date DESC";
                

               
            }


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }


    }

    public static class clsClientInfo
    {
        public static DataTable GetAllClients(bool OrderByAccNOASC = true)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query;

            if (OrderByAccNOASC)
            {
            query = @"Select AccountNO,Name,Phone,Email,PINCode,Balance,ImagePath,AddedBy From Clients
                      Order By AccountNO ASC";
            }
            else
            {
                query = @"Select AccountNO,Name,Phone,Email,PINCode,Balance,ImagePath,AddedBy From Clients
                      Order By AccountNO DESC";
            }

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static DataTable GetAllClientsAndOrderBalances(bool OrderBalancesASC = true)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query;

            if (OrderBalancesASC)
            {
            query = @"Select AccountNO,Name,Phone,Email,PINCode,Balance,ImagePath,AddedBy From Clients
                      Order By Balance ASC";
            }
            else
            {
                query = @"Select AccountNO,Name,Phone,Email,PINCode,Balance,ImagePath,AddedBy From Clients
                      Order By Balance DESC";
            }

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        //public static int GetNumOfClients(string FilterB = "")
        //{
        //    int NumOfClient = 0;

        //    SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
        //    string query = "";

        //    if(Filter == "")
        //    {
        //        query = "Select Count(*) From Clients";
        //    }
        //    else
        //    {
        //        query = "Select Count(*) From Clients Where "
        //    }

        //}

        public static DataTable FindClientByAccNO(string AccountNumber)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "Select AccountNO,Name,Phone,Email,PINCode,Balance,ImagePath,AddedBy From Clients Where AccountNO Like '%' + @AccountNO + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNO", AccountNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static DataTable FindClientByName(string Name)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "Select AccountNO,Name,Phone,Email,PINCode,Balance,ImagePath,AddedBy From Clients Where Name Like '%' + @Name + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static DataTable FindClientByBalance(string balance)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "Select AccountNO,Name,Phone,Email,PINCode,Balance,ImagePath,AddedBy From Clients Where Balance Like @Balance + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Balance", balance);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static int AddNewClient(string AccountNumber, string Name, string Phone, string Email, int PINCode, int Balance, string ImagePath,string Username)
        {
            int ClientID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"Insert into Clients(AccountNO,Name,Phone,Email,PINCode,Balance,ImagePath,AddedBy)
                            Values
                             (@AccountNumber,@Name,@Phone,@Email,@PINCode,@Balance,@ImagePath,@Username);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@PINCode", PINCode);
            command.Parameters.AddWithValue("@Balance", Balance);
            command.Parameters.AddWithValue("@Username", Username);
            if(ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ClientID = insertedID;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return ClientID;

        }

        public static bool DeleteClient(string AccountNumber)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "Delete From Clients Where AccountNO = @AccountNO";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNO", AccountNumber);

            try
            {
                connection.Open();
                int EffetedRows = command.ExecuteNonQuery();
                if (EffetedRows > 0)
                {
                    IsDeleted = true;
                }

            }
            catch (Exception ex)
            {
                IsDeleted = false;
            }
            finally
            {
                connection.Close();
            }

            return IsDeleted;
        }
    
        public static bool UpdateClientInfo(string AccountNumber, string Name, string Phone, string Email, int PINCode, int Balance,string ImagePath)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection( DataAccessSettings.ConnectionString);
            string query = @"Update Clients
                            Set Name = @Name,
                                Phone = @Phone,
                                Email = @Email,
                                PINCode = @PINCode,
                                Balance = @Balance,
                                ImagePath = @ImagePath
                                Where AccountNO = @AccountNumber";

            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PINCode", PINCode);
            command.Parameters.AddWithValue("@Balance", Balance);
            if (ImagePath != null || ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", "C:\\Users\\Hassan\\Pictures\\Projects Images\\Bank\\UnknownAcc.png");

            }
            try
            {
                connection.Open();

                int EffectedRows = command.ExecuteNonQuery();

                if (EffectedRows > 0)
                {
                    IsUpdated = true;
                }

            }
            catch (Exception ex)
            {
                IsUpdated = false;
            }
            finally
            {
                connection.Close();
            }

            return IsUpdated;
        }

        public static bool DepositBalance(string AccountNumber, double NewAmount)
        {
            bool IsAdded = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"Update Clients
                            Set Balance = Balance + @NewAmount
                                Where AccountNO = @AccountNO";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@AccountNO", AccountNumber);
            command.Parameters.AddWithValue("@NewAmount", NewAmount);

            try
            {
                connection.Open();
                int EffectedRows = command.ExecuteNonQuery();
                if (EffectedRows > 0)
                {
                    IsAdded = true;
                }
            }
            catch (Exception ex)
            {
                IsAdded = false;
            }
            finally
            {
                connection.Close();
            }

            return IsAdded;
        }

        public static bool WithdrawBalance(string AccountNumber, double NewAmount)
        {
            bool IsAdded = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"Update Clients
                            Set Balance = Balance - @NewAmount
                                Where AccountNO = @AccountNO";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@AccountNO", AccountNumber);
            command.Parameters.AddWithValue("@NewAmount", NewAmount);

            try
            {
                connection.Open();
                int EffectedRows = command.ExecuteNonQuery();
                if (EffectedRows > 0)
                {
                    IsAdded = true;
                }
            }
            catch (Exception ex)
            {
                IsAdded = false;
            }
            finally
            {
                connection.Close();
            }

            return IsAdded;
        }

        public static double CalcTotalBalances()
        {
            double TotalBalances = 0;

            SqlConnection connection = new SqlConnection( DataAccessSettings.ConnectionString);
            string query = "Select Sum(Balance) From Clients";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    TotalBalances = Convert.ToDouble(result);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return TotalBalances;
        }
        
        public static bool IsClientExist(string AccountNO)
        {
            bool IsClientExist = false;


            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "Select AccountNO From Clients Where AccountNO = @AccountNO";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNO", AccountNO);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    IsClientExist = true;
                }
            }
            catch (Exception ex)
            {
                IsClientExist = false;
            }
            finally
            {
                connection.Close();
            }

            return IsClientExist;
        }

    }

    public static class clsCurrencies
    {
        public static DataTable GetAllCurrencies(bool Find = false, bool SortedByASC = true, string FindBy = "", string SearchText = "")
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "";

            if (Find == false)
            {
                if (SortedByASC)
                {
                    if (FindBy == "Code" || FindBy == "")
                        query = "Select Country,Code,Name,Rate From Currencies Order by Code ASC";
                    if (FindBy == "Country")
                        query = "Select Country,Code,Name,Rate From Currencies Order by Country ASC";
                    if (FindBy == "Name")
                        query = "Select Country,Code,Name,Rate From Currencies Order by Name ASC";
                }
                else
                {
                    if (FindBy == "Code" || FindBy == "")
                        query = "Select Country,Code,Name,Rate From Currencies Order by Code DESC";
                    if (FindBy == "Country")
                        query = "Select Country,Code,Name,Rate From Currencies  Order by Country DESC";
                    if (FindBy == "Name")
                        query = "Select Country,Code,Name,Rate From Currencies  Order by Name DESC";

                }


            }
            else
            {
                if (SortedByASC)
                {
                    if (FindBy == "Code" || FindBy == "")
                        query = "Select Country,Code,Name,Rate From Currencies Where Code LIKE '%' + @Code + '%' Order by Code ASC";
                    if (FindBy == "Country")
                        query = "Select Country,Code,Name,Rate From Currencies Where Country LIKE '%' + @Country + '%' Order by Country ASC";
                    if (FindBy == "Name")
                        query = "Select Country,Code,Name,Rate From Currencies Where Name LIKE '%' + @Name + '%' Order by Name ASC";
                }
                else
                {
                    if (FindBy == "Code" || FindBy == "")
                        query = "Select Country,Code,Name,Rate From Currencies Where Code LIKE '%' + @Code + '%' Order by Code DESC";
                    if (FindBy == "Country")
                        query = "Select Country,Code,Name,Rate From Currencies Where Country LIKE '%' + @Country + '%'  Order by Country DESC";
                    if (FindBy == "Name")
                        query = "Select Country,Code,Name,Rate From Currencies Where Name LIKE '%' + @Name + '%'  Order by Name DESC";

                }
            }

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Code", SearchText);
            command.Parameters.AddWithValue("@Country", SearchText);
            command.Parameters.AddWithValue("@Name", SearchText);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool UpdateCurrencyRate(string CurrencyCode, decimal newRate)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"Update Currencies
                            Set Rate = @NewRate
                            Where Code = @CurrencyCode";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NewRate", newRate);
            command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode);
            try
            {
                connection.Open();
                int EffectedRows = command.ExecuteNonQuery();
                if (EffectedRows > 0)
                {
                    IsUpdated = true;
                }

            }
            catch (Exception ex)
            {
                IsUpdated = false;
            }
            finally
            {
                connection.Close();
            }

            return IsUpdated;
        }

        public static bool IsCurrencyExist(string CurrencyCode)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"Select Name From Currencies
                            Where Code = @CurrencyCode";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    IsFound = true;
                }

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static void GetCurrencyInfo(string CurrencyCode, ref string Country, ref string Name, ref decimal Rate)
        {

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"Select * From Currencies
                            Where Code = @CurrencyCode";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Country = (string)reader["Country"];
                    Name = (string)reader["Name"];
                    Rate = (decimal)reader["Rate"];

                }

                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
        }

        public static DataTable GetAllCurrenciesCode()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "Select Distinct Code From Currencies Where Rate > 0";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
        
        public static string GetCurrencyCode(string currencyCode)
        {
            string Code = "";

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "Select Code From Currencies Where Code Like '%' + @CurrencyCode + '%' Order by Code ASC";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CurrencyCode", currencyCode);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result!= null)
                {
                    Code = (string)result;
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return Code;
        }

        public static decimal GetCurrancyRate(string  currencyCode)
        {
            decimal rate = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "Select Rate From Currencies Where Code = @Code";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Code", currencyCode);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result!= null)
                {
                    rate = Convert.ToDecimal(result);
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return rate;
        }
    
    }
}
