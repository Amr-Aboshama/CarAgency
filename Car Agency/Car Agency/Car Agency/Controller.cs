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
            string query = "select max(ReqID) from CarRequest;";
            int? id = dbMan.ExecuteScalar(query) as int?;

            if (id == null)
                return 1;
            else
                return (int)id + 1;
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

        public DataTable SelecAllCurrency()
        {
            string query = "select distinct CurrCode from Currency";
            return dbMan.ExecuteReader(query);
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


      

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
    }
