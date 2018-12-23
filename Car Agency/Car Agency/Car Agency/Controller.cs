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

        public DataTable SelectAllInstallments()
        {
            string query = "select installmentID as 'Installment ID', SaleID as 'Sale ID', submittedPrice as 'Submitted Price', "
                + "PriceOfOneInstallment as'Price of one Installment', Factor, Currency, ArchivePlace as 'Archive Place', "
                + "DrawerNum as'Drawer Number', "
                + "(case when exists(select transID from cheque C where C.installmentID = I.installmentID and TransID is null) "
                + "then 'No' else 'Yes' end) as 'Completed' from Installment I order by installmentID desc; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectCheques(int? installmentID)
        {
            string query = "select ChequeID as 'Cheque ID', Price, DelayPenalty as 'Delay Penalty', Currency, "
                + "CustID as 'Customer National ID', CustomerBank as 'Customer Bank', DueDate as 'Due Date', "
                + "RecordDate as'Record Date', InstallmentID as 'Installment ID', TransID as 'Transaction ID', Notes "
                + "from Cheque " + (installmentID == null ? "" : ("where installmentID = " + installmentID.ToString())) +
                " order by RecordDate desc; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable viewSafeBalance()
        {
            string query = "select Name as 'Safe Name', sum(Price) as Balance, Currency from( "
                + "(select Price, Currency, P.transID from Purchases P where P.transID is not null) union "
                + "(select Price, Currency, S.transID from Sales S where S.transID is not null) union "
                + "(select Price, Currency, T.transID from OtherTransaction T where T.transID is not null) union "
                + "(select Price, Currency, C.transID from Cheque C where C.TransID is not null)) "
                + "as TotalTransactions join transactions on transID = TransactionID "
                + "join Treasury on Treasury.TreasuryID = transactions.TreasuryID where BankAccID is null group by Name, Currency;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable viewSafeTransactions()
        {
            string query = "select Treasury.Name as 'Safe Name', transID as 'Transaction ID', Price, Currency, "
                + "E.name as 'Employee Name', transDate as 'Date' from( "
                + "(select Price, Currency, P.transID from Purchases P where P.transID is not null) union "
                + "(select Price, Currency, S.transID from Sales S where S.transID is not null) union "
                + "(select Price, Currency, T.transID from OtherTransaction T where T.transID is not null) union "
                + "(select Price, Currency, C.transID from Cheque C where C.TransID is not null)) "
                + "as TotalTransactions join transactions on transID = TransactionID "
                + "left outer join Employee E on EmpNatID = EmpID "
                + "join Treasury on Treasury.TreasuryID = transactions.TreasuryID where BankAccID is null;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable viewBankBalance()
        {
            string query = "select Name as 'Bank Name', sum(Price) as Balance, Currency from( "
                + "(select Price, Currency, P.transID from Purchases P where P.transID is not null) union "
                + "(select Price, Currency, S.transID from Sales S where S.transID is not null) union "
                + "(select Price, Currency, T.transID from OtherTransaction T where T.transID is not null) union "
                + "(select Price, Currency, C.transID from Cheque C where C.TransID is not null)) "
                + "as TotalTransactions join transactions on transID = TransactionID "
                + "join Treasury on Treasury.TreasuryID = transactions.TreasuryID where BankAccID is not null group by Name, Currency;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable viewBankTransactions()
        {
            string query = "select Treasury.Name as 'Bank Name', BankBranch as 'Bank Branch', BankAccName as 'Bank Account Name', "
                + "BankAccID as 'Bank Account ID', TotalTransactions.transID as 'Transaction ID', TotalTransactions.Price, "
                + "TotalTransactions.Currency, E.name as 'Employee Name', transDate as 'Date', Notes from( "
                + "(select Price, Currency, P.transID from Purchases P where P.transID is not null) union "
                + "(select Price, Currency, S.transID from Sales S where S.transID is not null) union "
                + "(select Price, Currency, T.transID from OtherTransaction T where T.transID is not null) union "
                + "(select Price, Currency, C.transID from Cheque C where C.TransID is not null)) "
                + "as TotalTransactions join transactions on transID = TransactionID "
                + "left outer join Employee E on EmpNatID = EmpID left outer join OtherTransaction on OtherTransaction.transID = transactionID "
                + "join Treasury on Treasury.TreasuryID = transactions.TreasuryID where BankAccID is not null;";
            return dbMan.ExecuteReader(query);
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
                + (DrawerNum == null ? "null" : DrawerNum.ToString()) + ");";
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
            if (dt != null)
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
