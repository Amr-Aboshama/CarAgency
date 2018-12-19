USE CarAgencyDB


INSERT INTO Jobs values('Sales Agent');
INSERT INTO Jobs values('Sales Manager');
INSERT INTO Jobs values('Purchases Manager');
INSERT INTO Currency(CurrCode,EGPPrice) VALUES('EGP',5.5);
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