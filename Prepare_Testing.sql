USE CarAgencyDB

INSERT INTO CURRENCY VALUES('EGP', 1.0);


INSERT INTO Jobs values('Sales Manager');
INSERT INTO Jobs values('Purchases Manager');
INSERT INTO Employee(EmpNatID,Name) VALUES(123,'TEST1');
INSERT INTO Employee(EmpNatID,Name) VALUES(456,'TEST2');
INSERT INTO Employee(EmpNatID,Name) VALUES(789,'TEST3');
INSERT INTO Employee(EmpNatID,Name) VALUES(123456789,'Amr');
INSERT INTO UserBasic(Username,Password,EmpID) VALUES('Test1',123,123);
INSERT INTO UserBasic(Username,Password,EmpID) VALUES('Test2',123,456);
INSERT INTO UserBasic(Username,Password,EmpID) VALUES('Test3',123,789);
INSERT INTO UserBasic(Username,Password,EmpID) VALUES('Amr',123,123456789);
INSERT INTO Treasury(Name) VALUES ('SAFE');
INSERT INTO Treasury(Name,BankAccID) VALUES ('Al-Ahly','5');
INSERT INTO UserPrivileges values('Amr','Sales Agent');
INSERT INTO UserPrivileges values('Amr','Purchases Manager');
INSERT INTO UserPrivileges VALUES('TEST1','Sales Manager');
INSERT INTO UserPrivileges VALUES('TEST2','Purchases Manager');
INSERT INTO UserPrivileges VALUES('TEST3','Sales Manager');
INSERT INTO transactions(treasuryID) values(1), (1), (2), (2);
insert into OtherTransaction(TransID, Price, Notes) values (2, 150000.0, 'This is a general transaction');

INSERT INTO CUSTOMER(custNatID, Name, CustAddress) values (12345678901234, 'Muhammad', 'bla-bla');
INSERT INTO Category(CatName) values ('Corolla_P1');
INSERT INTO Car(ChassisID, MotorNum, Color, catName) values ('x23f983vg', 'Red', 'nfe02lpavj323', 'Corolla_P1');

INSERT INTO Supplier(CustID) values (12345678901234);
insert into purchases(CarID, Price, SupID, transID) values ('x23f983vg', -30000000.0, 1, 3);

INSERT INTO Sales(CarID, CashOrInstallment, price, CustID, GNatID, TransID) 
values('x23f983vg', 0, 1234, 12345678901234, 123, 1);
