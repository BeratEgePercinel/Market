# Market

![image](https://user-images.githubusercontent.com/119699844/216139402-bbbe77e5-b82e-497b-bfc0-8cc7819226aa.png)


![image](https://user-images.githubusercontent.com/119699844/216139710-38eb4c07-0b96-4bc3-a00f-2c6a20b351df.png)

create table Supplier( Id int primary key IDENTITY (1,1), SupplierName  varchar (100), TaxNumber int, PhoneNumber varchar (10) );

create table Product( Id int primary key IDENTITY (1,1), ProductName  varchar(100), Barcode  varchar(50), Brand varchar(100), Price float, Quantity int, MeasurePrice float );

create table Receipt( Id int primary key IDENTITY (1,1), ReceiptNumber varchar(13), TaxNumber varchar(10), Unit int, UnitPrice float );

create table ProductReceipt( Id int primary key IDENTITY (1,1), ReceiptId int, ProductId int, FOREIGN KEY (ReceiptId) REFERENCES Receipt(Id), FOREIGN KEY (ProductId) REFERENCES Product(Id) );

create table Bill( Id int primary key IDENTITY (1,1), BillNumber varchar(16), SupplierId int, FOREIGN KEY (SupplierId) REFERENCES Supplier(Id) );

create table SupplierProduct( Id int primary key GENERATED ALWAYS AS IDENTITY, ProductId int, SupplierId int, FOREIGN KEY (SupplierId) REFERENCES Supplier(Id), FOREIGN KEY (ProductId) REFERENCES Product(Id) ); insert into Supplier(SupplierName,TaxNumber,PhoneNumber) values ('Mert',32647,'5335246062')

