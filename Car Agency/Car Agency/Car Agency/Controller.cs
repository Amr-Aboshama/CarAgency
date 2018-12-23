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

        
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

		public int insertSupplier(string name, UInt64 ID, string address, string email, string compName, string compAddress)
		{

			//addCustomer()

			string query =

				"insert into customer(Name, custNatID, custAddress " + (string.IsNullOrWhiteSpace(email)? "" : ", email") + 
																		(string.IsNullOrWhiteSpace(compName)? "" : ", compName") + 
																		(string.IsNullOrWhiteSpace(compAddress)? "" : ", compAddress") + ") " +
				"values('" + name + "', " + ID + ", '" + address + (string.IsNullOrWhiteSpace(email)? "" : "', '" + email) + 
																	 (string.IsNullOrWhiteSpace(compName)? "" : "', '" + compName) + 
																	 (string.IsNullOrWhiteSpace(compAddress) ? "" : "', '" + compAddress) + "');"

				;

			int result = dbMan.ExecuteNonQuery(query);

			if (result == 0)
				return 0;

			query = 

				"insert into supplier(custID)" +
				"values(" + ID + ");"

				;

			return dbMan.ExecuteNonQuery(query);
			
		}

		public DataTable selectAllSuppliers()
		{

			string query =

				"select Name, custAddress as 'Address', custID as 'National ID', compName as 'Company Name', compAddress as 'Company Address'" + 
				"from supplier join customer on custID = custNatID"

				;

			return dbMan.ExecuteReader(query);

		}

		public DataTable selectSales(bool pending = false)
		{

			string query =

				"select s.saleID as 'key', catName as 'Car', s.Price, s.Currency, c.name as 'Customer', e.name as 'Employee', saleDate as 'Date' " +
				"from sales s left outer join transactions on transID = transactionID " + 
										"join car on carID = chasisID " +
										"join customer c on custID = custNatID " +
										"join employee e on s.empID = empNatID " + 
				(pending? "where transID is null " : " ") +
				"order by transID asc "

				;

			return dbMan.ExecuteReader(query);

		}

		public DataTable selectPurchases(bool pending = false)
		{

			string query =

				"select p.purchaseID as 'key', catName as 'Car', p.Price, p.Currency, c.name as 'Supplier', e.name as 'Employee', purchaseDate as 'Date' " +
				"from purchases p left outer join transactions on transID = transactionID " +
										"join car on carID = chasisID " +
										"join supplier s on p.supID = s.supID " +
										"join customer c on s.custID = custNatID " +
										"join employee e on p.empID = empNatID " +
				(pending ? "where transID is null " : " ") +
				"order by transID asc "

				;

			return dbMan.ExecuteReader(query);

		}

		public DataTable selectAllCurrencies()
		{

			string query =

				"select currCode as 'Currency Code', egpPrice as 'EGP Price' " +
				"from currency "

				;

			return dbMan.ExecuteReader(query);
		}

		public int addCurrency(string code, decimal price)
		{
			
			string query =

				"insert into currency values('" + code + "', " + Convert.ToString(price) + ") ";

			;

			return dbMan.ExecuteNonQuery(query);
		}

		public int removeCurrency(string code)
		{
			
			string query =

				"delete from currency where currCode = '" + code + "' "
				
				;

			return dbMan.ExecuteNonQuery(query);
		}

		public bool isApproved(bool sale, int id)
		{
			string relation = (sale ? "sale" : "purchase");

			string query =

				"select transID from " +
				relation + "s " +
				"where " + relation + "ID = " + Convert.ToString(id);

				;

			DataTable dt = dbMan.ExecuteReader(query);

			return (!String.IsNullOrEmpty(Convert.ToString(dt.Rows[0][0])));
		}

		public DataTable[] selectSaleInfo(int id)
		{
			DataTable[] dt = new DataTable[5];

			//Sale info
			string query =

				"select Price, Currency, CashOrInstallment as 'Cash/Installment', saleDate as 'Date' " +
				"from sales " +
				"where saleID = " + Convert.ToString(id)

			;

			dt[0] = dbMan.ExecuteReader(query);

			//Guarantor info
			query =
				"select gName as 'Name', gNatID as 'National ID', gAddress as 'Address', gPhone as 'Phone Number' " +
				"from sales " +
				"where saleID = " + Convert.ToString(id)
				;

			dt[3] = dbMan.ExecuteReader(query);

			//Employee info
			query =
				"select e.Name, e.empNatID as 'National ID', e.Address, e.jobID as 'Job' " +
				"from sales s join employee e on s.empID = e.empNatID " +
				"where saleID = " + Convert.ToString(id)
				;

			dt[4] = dbMan.ExecuteReader(query);

			//Customer info
			query =
				"select c.Name, c.custNatID as 'National ID', c.Credit, c.custAddress as 'Address', c.Email, c.CompName as 'Company Name', c.compAddress as 'Company Address' " +
				"from sales s join customer c on s.custID = c.custNatID " +
				"where saleID = " + Convert.ToString(id)
				;

			dt[2] = dbMan.ExecuteReader(query);


			//Car info
			query =
				"select c.catName as 'Category', c.Brand, c.Type, c.Model, c.primaryCashPrice as 'Primary Cash Price', c.Currency, " +
					"r.chasisID as 'Chasis', r.motorNum as 'Motor', r.Color, " +
					"t.Name as 'Store Name', t.Address as 'Store Address' " +
				"from sales s left outer join car r on s.carID = r.chasisID " +
							 "left outer join category c on r.catName = c.catName " +
							 "left outer join store t on r.storeID = t.storeID " +
				"where saleID = " + Convert.ToString(id)
				;

			dt[1] = dbMan.ExecuteReader(query);

			return dt;
		}

		public DataTable[] selectPurchaseInfo(int id)
		{
			DataTable[] dt = new DataTable[4];

			//Purchase info
			string query =

				"select Price, Currency, purchaseDate as 'Date' " +
				"from purchases " +
				"where purchaseID = " + Convert.ToString(id)

			;

			dt[0] = dbMan.ExecuteReader(query);

			//Employee info
			query =
				"select e.Name, e.empNatID as 'National ID', e.Address, e.jobID as 'Job' " +
				"from purchases p join employee e on p.empID = e.empNatID " +
				"where purchaseID = " + Convert.ToString(id)
				;

			dt[3] = dbMan.ExecuteReader(query);

			//Supplier info
			query =
				"select c.Name, c.custNatID as 'National ID', c.Credit, c.custAddress as 'Address', c.Email, c.CompName as 'Company Name', c.compAddress as 'Company Address' " +
				"from purchases p join supplier s on p.supID = s.supID " +
								 "join customer c on s.custID = c.custNatID " +
				"where purchaseID = " + Convert.ToString(id)
				;

			dt[2] = dbMan.ExecuteReader(query);


			//Car info
			query =
				"select c.catName as 'Category', c.Brand, c.Type, c.Model, c.primaryCashPrice as 'Primary Cash Price', c.Currency, " +
						"r.chasisID as 'Chasis', r.motorNum as 'Motor', r.Color, " +
						"t.Name as 'Store Name', t.Address as 'Store Address' " +
				"from purchases p left outer join car r on p.carID = r.chasisID " +
							 "left outer join category c on r.catName = c.catName " +
							 "left outer join store t on r.storeID = t.storeID " +
				"where purchaseID = " + Convert.ToString(id)
				;

			dt[1] = dbMan.ExecuteReader(query);

			return dt;
		}

		public int deleteSaleorPurchase(bool sale, int id)
		{
			string relation = sale ? "Sale" : "Purchase";

			string query =
				"delete from " + relation + "s " + " where " + relation + "ID = " + Convert.ToString(id);

			return dbMan.ExecuteNonQuery(query);
		}

		public int addCallRecord(int custID, int empID, string text)
		{
			string query =
				"insert into CallRecords(custID, empID, notes) values(" + Convert.ToString(custID) + ", " + Convert.ToString(empID) + ", " + text + ") ";

			return dbMan.ExecuteNonQuery(query);
		}

		public DataTable selectRecords()
		{
			string query =
				"select c.Name as 'Customer', e.Name as 'Employee', notes, callDate as 'Date' " +
				"from callRecords r join customer c on r.custID = c.custNatID " +
									"join employee e on r.empID = e.empNatID ";

			return dbMan.ExecuteReader(query);
		}
	}
}
