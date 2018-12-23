create database CarAgencyDB
GO
use CarAgencyDB

/*a lot of on delete/update cascade caused an error, I don't know why, so I made them no action*/

create table Jobs
(
Name nvarChar(50)	primary key
);

create table Employee
( 
EmpNatID decimal(14,0) primary key,
Name nvarchar(30) not null,
Address nvarchar(50),
JobName nvarchar(50),
salary decimal(9, 2)
foreign key (JobName) references Jobs(Name) on delete set null on update cascade
);

create table EmployeePhones
(
EmpNatID decimal(14,0),
Phone decimal(14, 0),
primary key(EmpNatID, Phone),
foreign key(EmpNatID) references Employee on delete cascade on update cascade	
);

create table EmpSalaryMods					/*this table specifies the additions and subtractions*/
(											/*from salary of an Employee during one month*/
EmpNatID decimal(14,0),							/*and will be cleared every month when calculating the salaries*/
amount decimal(9, 2),						/*for employees*/
notes nvarchar(500),
ModID int identity(1, 1) primary key,
ModDate datetime default getdate(),
foreign key(EmpNatID) references Employee on delete cascade on update cascade
);

create table Store
(
Name nvarchar(30) not null, 
Address nvarchar(50),
Capacity int default 0,
StoreEmpID decimal(14,0),
StoreID int IDENTITY(1,1) primary key,
foreign key (StoreEmpID) references Employee(EmpNatID) on delete set null on update cascade
);

create table UserBasic
(
Username varchar(20) primary key,			/* Username must be in English*/
Password varchar(100) not null,				/* Password will be resized according to hashing algorithm*/
EmpID decimal(14,0),
foreign key (EmpID) references Employee(EmpNatID) on delete set null on update cascade
);

create table Customer
(
CustNatID decimal(14, 0) primary key,
Name nvarchar(30) not null,
CustAddress nvarchar(50) not null,
Email nvarchar(30),
CompName nvarchar(30),	/*"company name" if the customer was from a company*/
CompAddress nvarchar(50),
CompTaxCard nvarchar(500),			/*those are supposed to be images, but we still can't decide to store*/
CompCommercialRecord nvarchar(500),	/*their path only or to store the whole image*/
Credit decimal(12, 2) default 0,	/*each customer can have credit that can be used when he purcahse a car*/
);

create table CustomerPhoneNumbers
(
Phone decimal(14, 0),
CustID decimal(14, 0), 
primary key(Phone,CustID),
foreign key (CustID) references Customer(CustNatID) on delete cascade on update cascade
);

create table Supplier /*supplier data is stored as customer data and there is a reference to that customer*/
(
CustID decimal(14, 0) unique,
SupID int IDENTITY(1,1) primary key,
foreign key (CustID) references Customer(CustNatID)	on delete cascade on update cascade
);

create table Currency	/*To store the currencies that are used in the company,*/
(						/*we can group by a currency later*/
CurrCode char(3) primary key,	/*such as EGP and USD*/
EGPPrice decimal(9, 2)			/*can be used later*/
);

create table Category	/*number of cars in a category is derived from the cars that refer to that category*/
(
CatName nvarchar(20) primary key,
Brand nvarchar(20),	
Type nvarchar(20),
Model nvarchar(20),
Specs nvarchar(2000),
PrimaryChashPrice decimal(12, 2),
Currency char(3) default 'EGP', /*What would happen if the 'EGP' wasn't exist in Currency?*/
foreign key(Currency) references Currency
);

create table Car
(
ChassisID varchar(20) primary key,
MotorNum varchar(20) unique not null,
Color nvarchar(20) not null,
CatName nvarchar(20) not null,
StoreID int,
Status int default 0,	/*isn't sold initially*/
foreign key (StoreID) references Store(StoreID) on delete set null on update cascade,
foreign key (CatName) references Category(CatName) on update cascade
);

create table CarRequest
(
CatName nvarchar(20) not null,
CustID decimal(14, 0), 
EmpID decimal(14,0),
Notes nvarchar(1000),
ReqID int IDENTITY(1,1) primary key,
foreign key (CatName) references Category(CatName) on delete cascade on update cascade,
foreign key (CustID) references Customer(CustNatID) on delete set null on update cascade,
foreign key (EmpID) references Employee(EmpNatID) on delete set null on update cascade
);

create table Treasury
(
TreasuryID int IDENTITY(1,1) primary key,
Name nvarchar(25) not null unique,
BankAccID nvarchar(30),
BankBranch nvarchar(30),
BankAccName nvarchar(30),
);

create table Transactions
(
TreasuryID int not null,
EmpID decimal(14,0),
TransDate datetime default getdate(),
TransactionID int IDENTITY(1,1) primary key,
foreign key (EmpID) references Employee(EmpNatID) on delete set null on update cascade,
foreign key (TreasuryID) references Treasury(TreasuryID) on delete cascade on update cascade
);

create table Purchases 
(
CarID varchar(20) not null unique,
Price decimal(12, 2) not null,
Currency char(3) default 'EGP',
EmpID decimal(14,0),
SupID int not null,
TransID int unique,
PurchaseDate datetime default getdate(),
PurchaseID int IDENTITY(1,1) primary key,
foreign key (Currency) references Currency,
foreign key (EmpID) references Employee(EmpNatID) on delete set null on update cascade,
foreign key (CarID) references Car(ChassisID),
foreign key (TransID) references Transactions(TransactionID),
foreign key (SupID) references Supplier(SupID) on update cascade,
foreign key (Currency) references Currency(Currcode) on delete set default on update cascade
);

create table Sales
(
CarID varchar(20) not null unique,
CashOrInstallment bit not null,
Price decimal(12, 2) not null,
Currency char(3) default 'EGP',
CustID decimal(14, 0) not null,
GNatID decimal(14, 0) not null,	/*guarantor national ID*/
GName nvarchar(30), 
GPhone decimal(14, 0),
GAddress nvarchar(50),
EmpID decimal(14,0),
TransID int unique,
SaleDate datetime default getdate(),
SaleID int IDENTITY(1,1) primary key,
foreign key (Currency) references Currency,
foreign key (CarID) references Car(ChassisID) on delete cascade on update cascade,
foreign key (CustID) references Customer(CustNatID) on update cascade,
foreign key (EmpID) references Employee(EmpNatID),
foreign key (TransID) references Transactions(TransactionID),
foreign key (Currency) references Currency(Currcode) on delete set default on update cascade
);

create table OtherTransaction
(
ID int Identity(1,1) primary key,
transID int unique,
Price decimal(9, 2) not null,
Currency char(3) default 'EGP',
Notes nvarchar(1000),
foreign key (transID) references Transactions(TransactionID) on delete no action on update cascade,
foreign key (Currency) references Currency(Currcode)
);

create table Installment
(
SubmittedPrice decimal(12, 2) not null,
PriceOfOneInstallment decimal(12, 2) not null,
Currency char(3) default 'EGP',
SaleID int not null unique,
Factor decimal(12, 2) default 1,	/*Used when some customer purchase a car in EGP although it's in USD*/
ArchivePlace nvarchar(50),	/*related to the physical place where it's stored*/
DrawerNum int,	/*drawer number where the achive is placed*/
InstallmentID int IDENTITY(1,1) primary key,
foreign key (Currency) references Currency,
foreign key (SaleID) references Sales(SaleID) on delete cascade on update cascade
);

create table Cheque
(
ChequeID varchar(20) primary key,
Price decimal(12, 2) not null,
Currency char(3) default 'EGP',
CustID decimal(14, 0) not null,
CustomerBank nvarchar(30)not null,
DueDate datetime not null,
DelayPenalty decimal(12, 2) not null,
Notes nvarchar(2000),
InstallmentID int,	/*it can be null because a cheque can be made without an installment*/
TransID int unique,
RecordDate datetime default getdate(),
foreign key (Currency) references Currency,
foreign key (CustID) references Customer(CustNatID) on delete cascade on update cascade,
foreign key (TransID) references Transactions(TransactionID) on delete cascade on update cascade,
foreign key (InstallmentID) references Installment(InstallmentID),
);

create table UserPrivileges
(
Username varchar(20) not null,
JobName nvarchar(50) not null,
foreign key (Username) references UserBasic(Username) on delete cascade on update cascade,
foreign key (JobName) references Jobs(Name) on delete no action on update no action
);

INSERT INTO Jobs values('--All--');
