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
            
        public DataTable SelectCustomers()
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
                + "(case when exists(select * from cheque C where C.installmentID = I.installmentID and TransID is null) "
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
            string query = "select Treasury.Name as 'Safe Name', TotalTransactions.transID as 'Transaction ID', TotalTransactions.Price, TotalTransactions.Currency, "
                + "E.name as 'Employee Name', transDate as 'Date', Notes, "
                + "(case when exists(select * from sales where transID = TransactionID and transID is not null) then 'Sale' "
                + "when exists(select * from Purchases where transID = TransactionID and transID is not null) then 'Purchase' "
                + "when exists(select * from OtherTransaction where transID = TransactionID and transID is not null) then 'General' "
                + "else 'Cheque' end) as 'Type' from( "
                + "(select Price, Currency, P.transID from Purchases P where P.transID is not null) union "
                + "(select Price, Currency, S.transID from Sales S where S.transID is not null) union "
                + "(select Price, Currency, T.transID from OtherTransaction T where T.transID is not null) union "
                + "(select Price, Currency, C.transID from Cheque C where C.TransID is not null)) "
                + "as TotalTransactions join transactions on transID = TransactionID "
                + "left outer join Employee E on EmpNatID = EmpID left outer join OtherTransaction on OtherTransaction.transID = transactionID "
                + "join Treasury on Treasury.TreasuryID = transactions.TreasuryID where BankAccID is null order by 'Date' desc;";
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
                + "TotalTransactions.Currency, E.name as 'Employee Name', transDate as 'Date', Notes, "
                + "(case when exists(select * from sales where transID = TransactionID and transID is not null) then 'Sale' "
                + "when exists(select * from Purchases where transID = TransactionID and transID is not null) then 'Purchase' "
                + "when exists(select * from OtherTransaction where transID = TransactionID and transID is not null) then 'General' "
                + "else 'Cheque' end) as 'Type' from( "
                + "(select Price, Currency, P.transID from Purchases P where P.transID is not null) union "
                + "(select Price, Currency, S.transID from Sales S where S.transID is not null) union "
                + "(select Price, Currency, T.transID from OtherTransaction T where T.transID is not null) union "
                + "(select Price, Currency, C.transID from Cheque C where C.TransID is not null)) "
                + "as TotalTransactions join transactions on transID = TransactionID "
                + "left outer join Employee E on EmpNatID = EmpID left outer join OtherTransaction on OtherTransaction.transID = transactionID "
                + "join Treasury on Treasury.TreasuryID = transactions.TreasuryID where BankAccID is not null order by 'Date' desc;";
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

//<<<<<<< HEAD
//=======

        public DataTable SelectCustomerByID(decimal id)
        {
            string query = "select CustAddress,Email,CompName,CompAddress,Credit " 
                         + "from Customer where CustNatID ='" + id + "';";
            return dbMan.ExecuteReader(query);
        }


        public DataTable SelectAllCustomer()
        {
            string query = "select * from Customer order by Name;";
            return dbMan.ExecuteReader(query);

        }
        public int InsertCustomer(string name, decimal id, string add, string email, string cmpName, string cmpAdd)
        {
            string query = "insert into Customer (CustNatID,Name,CustAddress,Email,CompName,CompAddress) "
                         + "Values ('" + id + "','" + name + "','" + add + "','" + email + "','" + cmpName + "','" + cmpAdd + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateCustomer(decimal id, string name, string add, string email, string cmpName, string cmpAdd, decimal credit)
        {
            string query = "update Customer set ";
            if (name != "")
                query += "Name ='" + name + "',";
            query += "CustAddress ='" + add + "',"
                  + "Email ='" + email + "',"
                  + "CompName ='" + cmpName + "',"
                  + "CompAddress ='" + cmpAdd + "',"
                  + "Credit =" + credit + " where CustNatID ='" + id + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertCustPhoneNum(string phone, decimal id)
        {
            string query = "INSERT INTO CustomerPhoneNumbers (Phone,CustID) "
                         + "Values ('" + phone + "','" + id + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectCustomerPhoneNumbers(decimal id)
        {
            string query = "select Phone from CustomerPhoneNumbers where CustID = '" + id + "';";
            return dbMan.ExecuteReader(query);
        }

        public int DeleteCustPhoneNum(string phone, decimal id)
        {
            string query = "delete from CustomerPhoneNumbers where Phone ='" + phone + "' and CustID ='" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectAvailableCarBrands()
        {
            string query = "select distinct Brand from Category t,Car c where c.CatName = t.CatName and c.Status = 1;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAvailableCarTypes(string brand)
        {
            string query = "select distinct Type from Category t,Car c where c.CatName = t.CatName and c.Status = 1 and t.Brand='" + brand + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAvailableCarCategory(string brand, string type)
        {
            string query = "select distinct t.CatName from Category t,Car c "
                         + "where t.CatName = c.CatName and Brand = '" + brand + "' and Type = '" + type + "' and c.Status = 1;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAvailableCarInfo(string catName)
        {
            string query = "select Model,Specs,PrimaryChashPrice,Currency from Category "
                         + "where CatName ='" + catName + "';";
            return dbMan.ExecuteReader(query);
        }

        public int ReserveCar(string id, int status)
        {
            string query = "update Car set Status =" + status + " where ChasisID ='" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectAvailabeCars(string catname)
        {
            string query = "select c.ChasisID,C.Color,t.Name from Car c,Store t where c.StoreID = t.StoreID and c.CatName ='" + catname + "' and Status = 1;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectBrands()
        {
            string query = "select distinct Brand from Category order by Brand";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectTypes(string brand)
        {
            string query = "select distinct Type from Category where Brand ='" + brand + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectCategories(string brand, string type)
        {
            string query = "select CatName from Category where Brand ='" + brand + "' and Type ='" + type + "' order by CatName; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectCategoryInfo(string catName)
        {
            string query = "select Brand,Type,Model,Specs,PrimaryChashPrice,Currency from Category where CatName ='" + catName + "';";
            return dbMan.ExecuteReader(query);
        }

        public int InsertCategory(string name, string brand, string type, string model, string specs, Decimal price, string currency)
        {
            string query = "insert into Category (CatName,Brand,Type,Model,Specs,PrimaryChashPrice,Currency) "
                          + "values ('" + name + "','" + brand + "','" + type + "','" + model + "','" + specs + "'," + price + ",'" + currency + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int RequestCategory(string name, string custID, string note, int reqID)
        {
            string query;
            if(custID != "")
                query = "insert into CarRequest (CatName,CustID,Notes,ReqID) "
                         + "values ('" + name + "','" + custID  + "','" + note + "'," + reqID + ");";
            else
                query = "insert into CarRequest (CatName,Notes,ReqID) "
                      +  "values('" + name + "','" + note + "', " + reqID + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int GetNewRequestID()
        {
            string query = "select IDENT_CURRENT from CarRequest;";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int UpdateCategory(string name,string newName, string brand, string type, string model, string specs, Decimal price, string currency)
        {
            string query = "update Category set "
                         + "CatName ='" + newName + "',"
                         + "Brand ='" + brand + "',"
                         + "Type ='" + type + "',"
                         + "Model ='" + model + "',"
                         + "Specs ='" + specs + "',"
                         + "PrimaryChashPrice =" + price + ","
                         + "Currency ='" + currency + "' where CatName ='" + name +"';";
            return dbMan.ExecuteNonQuery(query);
        }
        
        public DataTable SelectAvailableCars(string catName, string brand, string model)
        {
            string query = "SELECT ChasisID,Color,Name from Car c,Store s,Category t "
                         + "where c.StoreID=s.StoreID and c.CatName=t.CatName and CatName='" + catName + "' and Brand='" + brand + "' "
                         + "and Model='" + model + "';";
            return dbMan.ExecuteReader(query);
        }

        //inventory manager form
        public DataTable SelectCarsInStores()
        {
            string query = "select s.Name as Store,Brand,Type,r.CatName as Category,Color,Model,Specs "
                         + "from Car r,Category c, Store s where r.CatName = c.CatName and r.StoreID = s.StoreID and r.Status <> 0 order by s.Name,Brand,Type; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectCarsNotInStore()
        {
            string query = "select Brand,Type,r.CatName as Category,Model,Color,Specs,ChasisID "
                         + "from Car r,Category c where r.CatName = c.CatName and r.Status <> 0 and r.StoreID is null ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectStores()
        {
            string query = "select Name,StoreID from Store";
            return dbMan.ExecuteReader(query);
        }

        public int InsertCarIntoStore(string id,string storeid)
        {
            string query = "update Car set "
                         + "StoreID ='" + storeid + "' where ChasisID ='" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public decimal MaxSalary()
        {
            string query = "select max(Salary) from Employee ";
            return (decimal)dbMan.ExecuteScalar(query);
        }

        public decimal SumSalary()
        {
            string query = "select sum(Salary) from Employee ";
            return (decimal)dbMan.ExecuteScalar(query);
        }

        public int NumOfEmp()
        {
            string query = "select count(EmpNatID) from Employee ";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int NumOfAvailableCars()
        {
            string query = "select count(ChasisID) from Car where Status = 1 ";
            return (int)dbMan.ExecuteScalar(query);
        }








//>>>>>>> Nehal
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

        public DataTable SelectAllEmployees()
        {
            string query = "select EmpNatID as 'National ID', Name, Address, JobName as Job, Salary from Employee;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllCars()
        {
            string query = "select chassisID as 'Chassis Number', MotorNum as 'Motor Number', Color, CatName as 'Category Name', "
                + "(case when status = 0 then 'sold' "
                + "when status = 1 then 'available' "
                + "when status = 2 then 'reserved' end) as Status, "
                + "Name as 'Store Name' from car left outer join Store on Car.StoreID = Store.StoreID;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllUsers()
        {
            string query = "select UserBasic.Username, Name, UserPrivileges.JobName as 'Job Name' from UserBasic " +
                "join Employee on EmpNatID = EmpID " +
                "join UserPrivileges on UserPrivileges.Username = UserBasic.Username order by Name;";
            return dbMan.ExecuteReader(query);
        }
    }
}
