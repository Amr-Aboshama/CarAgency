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

        public DataTable SelectCutomers()
        {
            string query = "select CustNatID,Name from Customer order by Name;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectSuppliers()
        {
            string query = "select SupID, Name from supplier s join customer c on s.custID = c.CustNatID order by Name;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectCategoriesNames()
        {
            string query = "select catName from category order by CatName;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectCarByChassis(string chassisID)
        {
            string query = "select ChassisID from Car where ChassisID = '" + chassisID + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectCarByMotor(string motorNum)
        {
            string query = "select MotorNum from Car where MotorNum = '" + motorNum + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelecAllCurrency()
        {
            string query = "select distinct CurrCode from Currency";
            return dbMan.ExecuteReader(query);
        }

        public int getLastInstallmentID()
        {
            string query = "SELECT IDENT_CURRENT('Installment');";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int insertInstallment(decimal SubmittedPrice, decimal PriceOfOneInstallment, string Currency, int SaleID,
            decimal Factor, string ArchivePlace, int? DrawerNum)
        {
            string query = "insert into Installment values("
                + SubmittedPrice.ToString() + ", "
                + PriceOfOneInstallment.ToString() + ", '"
                + Currency + "', "
                + SaleID.ToString() + ", "
                + Factor.ToString() + ", '"
                + ArchivePlace + "', "
                + (DrawerNum==null?"null": DrawerNum.ToString()) + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int insertCheque(string ChequeID, decimal price, string Currency, ulong CustID, string CustomerBank, 
            DateTime DueDate, decimal DelayPenalty, string Notes, int? installmentID)
        {
            string query = "insert into cheque(ChequeID, price, Currency, CustID, CustomerBank, DueDate, DelayPenalty, Notes," +
                " installmentID) values('"
                + ChequeID + "', "
                + price.ToString() + ", '"
                + Currency + "', "
                + CustID.ToString() + ", '"
                + CustomerBank + "', '"
                + DueDate.ToString() + "', "
                + DelayPenalty.ToString() + ", '"
                + Notes + "', "
                + (installmentID == null ? "null" : installmentID.ToString()) + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public string getCustName(UInt64 custID)
        {
            string query = "select name from customer where CustNatID = " + custID.ToString() + ";";
            DataTable dt = dbMan.ExecuteReader(query);
            if(dt!=null)
                return dt.Rows[0].ToString();
            return "";
        }

        public DataTable SelectCustomer(int saleID)
        {
            string query = "select custNatID, Name from sales join customer on CustNatID = CustID where saleID = " + saleID.ToString() + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectInstallment(int installmentID)
        {
            string query = "select * from installment where installmentID = " + installmentID.ToString() + ";";
            return dbMan.ExecuteReader(query);
        }

        public int InsertJob(string name)
        {
            string query = "insert into jobs(Name) values('" + name + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertCar(string ChassisID, string MotorNum, string Color, string CatName)
        {
            string query = "INSERT INTO Car(ChassisID, MotorNum, Color, CatName) VALUES('"
                + ChassisID + "', '"
                + MotorNum + "', '"
                + Color + "', '"
                + CatName + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteCar(string ChassisID)
        {
            string query = "Delete from Car where ChassisId = '" + ChassisID + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertPurchase(string CarID, decimal price, string Currency, int SupID, ulong EmpID)
        {
            string query = "INSERT INTO Purchases(CarID, price, Currency, SupID, EmpID) VALUES('"
                + CarID + "', "
                + price.ToString() + ", '"
                + Currency + "', "
                + SupID.ToString() + ", '"
                + EmpID.ToString() + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
    }
