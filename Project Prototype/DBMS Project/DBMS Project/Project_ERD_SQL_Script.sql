CREATE TABLE Customer (
  CustomerID INTEGER  NOT NULL   IDENTITY ,
  FirstName VARCHAR    ,
  LastName VARCHAR    ,
  CNIC INTEGER    ,
  RegistrationID INTEGER      ,
PRIMARY KEY(CustomerID));
GO




CREATE TABLE SalesPerson (
  SalePersonID INTEGER  NOT NULL   IDENTITY ,
  SPFirstName VARCHAR    ,
  SPLastName VARCHAR    ,
  CarsSold INTEGER    ,
  NumberOfClients INTEGER      ,
PRIMARY KEY(SalePersonID));
GO




CREATE TABLE Car (
  RegistratonID INTEGER  NOT NULL   IDENTITY ,
  RegistrationYear YEAR  NOT NULL  ,
  Make VARCHAR  NOT NULL  ,
  Model VARCHAR  NOT NULL  ,
  Price INTEGER      ,
PRIMARY KEY(RegistratonID));
GO




CREATE TABLE SalesPersonPerformance (
  SalesPersonID INTEGER  NOT NULL   IDENTITY ,
  SalesPerson_SalePersonID INTEGER  NOT NULL  ,
  CarsSold INTEGER    ,
  NumberOfClients INTEGER      ,
PRIMARY KEY(SalesPersonID)  ,
  FOREIGN KEY(SalesPerson_SalePersonID)
    REFERENCES SalesPerson(SalePersonID));
GO


CREATE INDEX SalesPersonPerformance_FKIndex1 ON SalesPersonPerformance (SalesPerson_SalePersonID);
GO


CREATE INDEX IFK_Rel_01 ON SalesPersonPerformance (SalesPerson_SalePersonID);
GO


CREATE TABLE Has_Features (
  Car_RegistratonID INTEGER  NOT NULL  ,
  EngineType VARCHAR  NOT NULL  ,
  Transmission VARCHAR  NOT NULL  ,
  SeatingCapacity INTEGER  NOT NULL  ,
  Airbags BOOL    ,
  ABS BOOL    ,
  AC BOOL    ,
  PowerLocks BOOL    ,
  PowerWindows BOOL    ,
  PowerSteering BOOL    ,
  PaddleShifters BOOL    ,
  Infotainment BOOL    ,
  Sunroof BOOL    ,
  FM/AM BOOL      ,
PRIMARY KEY(Car_RegistratonID)  ,
  FOREIGN KEY(Car_RegistratonID)
    REFERENCES Car(RegistratonID));
GO


CREATE INDEX Has_Features_FKIndex1 ON Has_Features (Car_RegistratonID);
GO


CREATE INDEX IFK_Rel_10 ON Has_Features (Car_RegistratonID);
GO


CREATE TABLE Transactions (
  RegistrationID INTEGER  NOT NULL   IDENTITY ,
  CustomerID INTEGER  NOT NULL  ,
  Customer_CustomerID INTEGER  NOT NULL  ,
  Car_RegistratonID INTEGER  NOT NULL  ,
  Price INTEGER    ,
  isInsured BOOL    ,
  AmountPaid INTEGER    ,
  DateBought DATE    ,
  AmountDue INTEGER    ,
  LeasingAmount INTEGER      ,
PRIMARY KEY(RegistrationID, CustomerID)    ,
  FOREIGN KEY(Car_RegistratonID)
    REFERENCES Car(RegistratonID),
  FOREIGN KEY(Customer_CustomerID)
    REFERENCES Customer(CustomerID));
GO


CREATE INDEX Transactions_FKIndex1 ON Transactions (Car_RegistratonID);
GO
CREATE INDEX Transactions_FKIndex2 ON Transactions (Customer_CustomerID);
GO


CREATE INDEX IFK_Rel_03 ON Transactions (Car_RegistratonID);
GO
CREATE INDEX IFK_Rel_05 ON Transactions (Customer_CustomerID);
GO


CREATE TABLE CarBought (
  CustomerID INTEGER  NOT NULL   IDENTITY ,
  SalesPerson_SalePersonID INTEGER  NOT NULL  ,
  Customer_CustomerID INTEGER  NOT NULL  ,
  RegistratonID INTEGER    ,
  SalesPersonID INTEGER      ,
PRIMARY KEY(CustomerID)    ,
  FOREIGN KEY(Customer_CustomerID)
    REFERENCES Customer(CustomerID),
  FOREIGN KEY(SalesPerson_SalePersonID)
    REFERENCES SalesPerson(SalePersonID));
GO


CREATE INDEX CarBought_FKIndex1 ON CarBought (Customer_CustomerID);
GO
CREATE INDEX CarBought_FKIndex2 ON CarBought (SalesPerson_SalePersonID);
GO


CREATE INDEX IFK_Rel_04 ON CarBought (Customer_CustomerID);
GO
CREATE INDEX IFK_Rel_07 ON CarBought (SalesPerson_SalePersonID);
GO


CREATE TABLE Lease (
  RegistrationID INTEGER  NOT NULL   IDENTITY ,
  CustomerID INTEGER  NOT NULL  ,
  Transactions_CustomerID INTEGER  NOT NULL  ,
  Transactions_RegistrationID INTEGER  NOT NULL  ,
  Car_RegistratonID INTEGER  NOT NULL  ,
  isLeased BOOL    ,
  DownPayment INTEGER    ,
  Installments INTEGER    ,
  DateBought DATE    ,
  DateEnd DATE      ,
PRIMARY KEY(RegistrationID, CustomerID)    ,
  FOREIGN KEY(Car_RegistratonID)
    REFERENCES Car(RegistratonID),
  FOREIGN KEY(Transactions_RegistrationID, Transactions_CustomerID)
    REFERENCES Transactions(RegistrationID, CustomerID));
GO


CREATE INDEX Lease_FKIndex2 ON Lease (Car_RegistratonID);
GO
CREATE INDEX Lease_FKIndex2 ON Lease (Transactions_RegistrationID, Transactions_CustomerID);
GO


CREATE INDEX IFK_Rel_08 ON Lease (Car_RegistratonID);
GO
CREATE INDEX IFK_Rel_10 ON Lease (Transactions_RegistrationID, Transactions_CustomerID);
GO



