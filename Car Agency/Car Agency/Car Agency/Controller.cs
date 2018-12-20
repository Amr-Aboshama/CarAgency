using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Car_Agency
{
    public class Controller
    {
        private DBManager dbMan; // A Reference of type DBManager 
                                 // (Initially NULL; NO DBManager Object is created yet)
        
        public Controller()
        {
            dbMan = new DBManager(); // Create the DBManager Object
        }

        // Check SQL Injection
        public bool checkClean(string s)
        {
            for (int i = 0; i < s.Length; ++i)
                if (s[i] == '\'' || s[i] == '"') return false;
            return true;
        }

        public string ComputeHashSHA256(string data)
        {
            SHA256 hashing = SHA256.Create();
            byte[] bytes = hashing.ComputeHash(Encoding.UTF8.GetBytes(data));
            string hashed = "";
            foreach (byte b in bytes)
                hashed += b.ToString("x2");
            return hashed;
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public int getPriv(string username)
        {
            if (!checkClean(username)) return 0;

            string query = "SELECT Priv FROM UserBasic WHERE Username = '" + username + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public decimal getEmpIDByUser(string username)
        {
            if (!checkClean(username)) return 0;

            string query = "SELECT EmpID FROM UserBasic WHERE Username = '" + username + "';";
            return (decimal)dbMan.ExecuteScalar(query);
        }

        public int AddOtherTransaction(decimal empId, int treasuryId, decimal price, string notes)
        {
            int transId = addTransaction(empId, treasuryId);
            string query = "INSERT INTO OtherTransaction(transID,Price,Notes) " +
                "VALUES (" + transId + "," + price + ",'" + notes + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addTransaction(decimal empId, int treasuryId)
        {
            // RETURN ADDED TRANSACTION ID

            string query = "INSERT INTO Transactions(TreasuryID,EmpID) VALUES(" + treasuryId + "," + empId + "); " +
                "SELECT TransactionID FROM Transactions T1 WHERE " +
                "EXISTS(SELECT * FROM Transactions T2 WHERE T2.EmpID = " + empId + " " +
                "HAVING MAX(T2.TransDate) = T1.TransDate);";
            return (int)dbMan.ExecuteScalar(query);
        }

        public DataTable getTreasuries(int type)
        {
            // type 1 -> Banks & type 2 -> Safes
            string query;
            if(type==1) query = "SELECT Name,TreasuryID FROM Treasury WHERE BankAccID is not null;";
            else query = "SELECT Name,TreasuryID FROM Treasury WHERE BankAccID is null;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getAllJobs()
        {
            string query = "SELECT NAME FROM JOBS;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getAllEmployees()
        {
            string query = "SELECT EMPNATID,NAME FROM EMPLOYEE;";
            return dbMan.ExecuteReader(query);
        }

        public int addUser(string username, string password, decimal empID)
        {
            string hashedPassword = ComputeHashSHA256(password);
            string query = "INSERT INTO UserBasic VALUES('" + username + "','" + hashedPassword + "'," + empID + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addUserPriv(string username, string priv)
        {
            string query = "INSERT INTO UserPrivileges values('"+username+"','"+priv+"');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int removeUserPriv(string username, string priv)
        {
            string query = "DELETE FROM UserPrivileges WHERE USERNAME='"+username+"' AND JobName='"+priv+"';";
            return dbMan.ExecuteNonQuery(query);
        }

        public bool isUsernameExists(string username)
        {
            string query = "SELECT Username FROM UserBasic WHERE Username ='"+username+"';";
            return (dbMan.ExecuteScalar(query) != null);
        }

        public DataTable getAllUsers()
        {
            string query = "SELECT USERNAME, EMPID FROM USERBASIC;";
            return dbMan.ExecuteReader(query);
        }

        public int removeUser(string username)
        {
            string query = "DELETE FROM UserBasic WHERE Username = '"+username+"';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getUserData(string username)
        {
            string query = "SELECT * FROM USERBASIC WHERE USERNAME = '"+username+"';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getUserPrivileges(string username)
        {
            string query = "SELECT JobName FROM UserPrivileges WHERE Username='"+username+"';";
            return dbMan.ExecuteReader(query);
        }

        public int setUserEmp(string user,decimal empID)
        {
            string query = "UPDATE UserBasic SET EmpID=" + empID + " WHERE Username='" + user + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int setUserPassword(string username, string pass)
        {
            pass = ComputeHashSHA256(pass);
            string query = "UPDATE UserBasic SET Password='" + pass + "' WHERE Username='" + username + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addEmployee(decimal empID,string name, string address, decimal sal, string job)
        {
            string query = "INSERT INTO Employee VALUES(" + empID + ",'" + name + "','" + address + "','" + job + "'," + sal + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getEmpByJob(string job)
        {
            string query = "SELECT * FROM Employee WHERE JobName='" + job + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getEmpData(decimal empID)
        {
            string query = "SELECT * FROM Employee WHERE EmpNatID = " + empID + ";";
            return dbMan.ExecuteReader(query);
        }

        public int removeEmployee(decimal empID)
        {
            string query = "DELETE FROM Employee WHERE EmpNatID = " + empID + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public bool isEmployeeExists(decimal empID)
        {
            string query = "SELECT EmpNatID FROM Employee WHERE EmpNatID = " + empID + ";";
            return (dbMan.ExecuteScalar(query) != null);
        }

        public int UpdateEmployee(decimal oldEmpID,decimal empID, string name, string address, decimal sal, string job)
        {
            string query = "UPDATE Employee SET EmpNatID = " + empID + ", Name='" + name 
                + "', Address='" + address + "',JobName='" + job + "',salary=" + sal + " where EmpNatID=" + oldEmpID + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int ChangeUsername(string oldUsername, string newUsername)
        {
            string query = "UPDATE UserBasic SET Username = '" + newUsername + "' WHERE Username = '" + oldUsername + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public bool isUserMatchPassword(string username, string password)
        {
            password = ComputeHashSHA256(password);
            string query = "SELECT Username FROM UserBasic WHERE Username = '" + username + "' AND Password = '" + password + "';";
            return (dbMan.ExecuteScalar(query) != null);
        }

        public DataTable getAllStoresSup()
        {
            string query = "SELECT * FROM Employee WHERE JobName = 'Store Supervisor';";
            return dbMan.ExecuteReader(query);
        }

        public void addStore(string name, string address, int cap, decimal empID)
        {
            string query = "INSERT INTO Store(Name,Address,Capacity,StoreEmpID) " +
                "VALUES('" + name + "','" + address + "'," + cap + "," + empID + ");";
            dbMan.ExecuteNonQuery(query);
        }

        public DataTable getAllPrivileges()
        {
            string query = "select DISTINCT JOBNAME from UserPrivileges";
            return dbMan.ExecuteReader(query);
        }
    }
}
