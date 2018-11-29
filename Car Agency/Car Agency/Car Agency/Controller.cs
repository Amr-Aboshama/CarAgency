using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

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

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public int getPriv(string username)
        {
            if (!checkClean(username)) return 0;

            string query = "SELECT Priv FROM UserBasic WHERE Username = '" + username + "'";
            return (int)dbMan.ExecuteScalar(query);
        }

        public decimal getEmpId(string username)
        {
            if (!checkClean(username)) return 0;

            string query = "SELECT EmpID FROM UserBasic WHERE Username = '" + username + "'";
            return (decimal)dbMan.ExecuteScalar(query);
        }

        public int addTransaction(decimal empId, int treasuryId, decimal price,int operationType, string Notes)
        {
            if (!checkClean(Notes)) return 0;
            
            string query = "INSERT INTO Transactions(EmpID,TreasuryID,price,DepositOrWithdraw,Notes)" +
                "VALUES(" + empId + "," + treasuryId + "," + price + "," + operationType + ",'" + Notes + "')";

            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getTreasuries()
        {
            string query = "SELECT Name,TreasuryID FROM Treasury WHERE TreasuryID != 1";
            return dbMan.ExecuteReader(query);
        }

        
    }
}
