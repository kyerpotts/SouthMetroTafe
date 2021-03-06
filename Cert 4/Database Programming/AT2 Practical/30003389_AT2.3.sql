DROP DATABASE IF EXISTS party_cake;
CREATE DATABASE party_cake;
USE party_cake;
CREATE TABLE CUSTOMER
(
 	ID INT NOT NULL AUTO_INCREMENT,
 	FName VARCHAR(30),
 	LName VARCHAR(40),
    Address VARCHAR(50),
    Suburb VARCHAR(30),
    State VARCHAR(3),
    Phone CHAR(10),
    Descr VARCHAR(255),
    PRIMARY KEY(ID) 
);
CREATE TABLE EMPLOYEE
(
 	ID INT NOT NULL AUTO_INCREMENT,
 	FName VARCHAR(30),
 	LName VARCHAR(40),
    Address VARCHAR(50),
    Suburb VARCHAR(30),
    Salary DECIMAL(9,2),
    StartDate DATE,
    TFN VARCHAR(10),
    PRIMARY KEY(ID) 
);
CREATE TABLE SUPPLIER
(
 	ID INT NOT NULL AUTO_INCREMENT,
 	Name VARCHAR(50),
 	Phone CHAR(10),
    Address VARCHAR(50),
    Suburb VARCHAR(30),
    State VARCHAR(3),
    Postcode CHAR(4),
    PRIMARY KEY(ID) 
);
CREATE TABLE CATEGORY
(
 	ID INT NOT NULL AUTO_INCREMENT,
 	Description VARCHAR(25),
    PRIMARY Key(ID)
);
CREATE TABLE PRODUCT
(
 	ID INT NOT NULL AUTO_INCREMENT,
 	Description VARCHAR(255),
    CategoryID INT,
    CostPrice DECIMAL(5,2),
    SuppID INT,
    PRIMARY Key(ID),
    FOREIGN KEY(CategoryID) REFERENCES CATEGORY(ID),
    FOREIGN KEY(SuppID) REFERENCES SUPPLIER(ID)
);
CREATE TABLE INVOICE
(
 	InvoiceNo INT NOT NULL AUTO_INCREMENT,
 	InvoiceDate DATE,
    CustID INT,
    EmpID INT,
    PRIMARY Key(InvoiceNo),
    FOREIGN KEY(CustID) REFERENCES CUSTOMER(ID),
    FOREIGN KEY(EmpID) REFERENCES EMPLOYEE(ID)
);
CREATE TABLE INVOICE_LINE
(
 	InvoiceNo INT,
 	ProdID INT,
    Qty INT,
    PRIMARY Key(InvoiceNo, ProdID),
    FOREIGN KEY(InvoiceNo) REFERENCES INVOICE(InvoiceNo),
    FOREIGN KEY(ProdID) REFERENCES PRODUCT(ID)
);
