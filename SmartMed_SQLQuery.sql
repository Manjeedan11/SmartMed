/*CREATE DATABASE SmartMed;*/
USE SmartMed;

/*CREATE TABLE [User] (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Email NVARCHAR(255) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    [Role] NVARCHAR(50) NOT NULL CHECK ([Role] IN ('Admin', 'Customer')),
    CreatedAt DATETIME DEFAULT GETDATE()
);



CREATE TABLE Customer (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL UNIQUE,
    FullName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20) NOT NULL,
    Address NVARCHAR(255) NOT NULL,
    CONSTRAINT FK_Customer_User FOREIGN KEY (UserID) REFERENCES [User](UserID) ON DELETE CASCADE
);



CREATE TABLE Category (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL UNIQUE
);



CREATE TABLE Supplier (
    SupplierID INT IDENTITY(1,1) PRIMARY KEY,
    SupplierName NVARCHAR(100) NOT NULL,
    Contact NVARCHAR(100),
    Phone NVARCHAR(20)
);



CREATE TABLE Medicine (
    MedicineID INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(200) NOT NULL,
    CategoryID INT NOT NULL,
    SupplierID INT NOT NULL,
    Dosage NVARCHAR(50),
    Price DECIMAL(18,2) NOT NULL CHECK (Price > 0),
    Stock INT NOT NULL CHECK (Stock >= 0),
    ExpiryDate DATE NOT NULL,
    RequiresPrescription BIT NOT NULL DEFAULT 0,
    Discount DECIMAL(5,2) NULL CHECK (Discount >= 0 AND Discount <= 100),
    CONSTRAINT FK_Medicine_Category FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID),
    CONSTRAINT FK_Medicine_Supplier FOREIGN KEY (SupplierID) REFERENCES Supplier(SupplierID)
);



CREATE TABLE [Order] (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    OrderDate DATETIME DEFAULT GETDATE(),
    [Status] NVARCHAR(50) NOT NULL CHECK ([Status] IN ('Pending', 'Ready for Pickup', 'Delivered')),
    Total DECIMAL(18,2) NOT NULL CHECK (Total >= 0),
    DiscountApplied DECIMAL(5,2) NULL CHECK (DiscountApplied >= 0 AND DiscountApplied <= 100),
    CONSTRAINT FK_Order_Customer FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);


CREATE TABLE OrderItem (
    OrderItemID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL,
    MedicineID INT NOT NULL,
    Quantity INT NOT NULL CHECK (Quantity > 0),
    UnitPrice DECIMAL(18,2) NOT NULL CHECK (UnitPrice >= 0),
    CONSTRAINT FK_OrderItem_Order FOREIGN KEY (OrderID) REFERENCES [Order](OrderID) ON DELETE CASCADE,
    CONSTRAINT FK_OrderItem_Medicine FOREIGN KEY (MedicineID) REFERENCES Medicine(MedicineID)
);



CREATE TABLE Prescription (
    PrescriptionID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL,
    CustomerID INT NOT NULL,
    MedicineID INT NOT NULL,
    FilePath NVARCHAR(500) NOT NULL,
    UploadDate DATETIME DEFAULT GETDATE(),
    IsVerified BIT NOT NULL DEFAULT 0,
    CONSTRAINT FK_Prescription_Order FOREIGN KEY (OrderID) REFERENCES [Order](OrderID),
    CONSTRAINT FK_Prescription_Customer FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
    CONSTRAINT FK_Prescription_Medicine FOREIGN KEY (MedicineID) REFERENCES Medicine(MedicineID)
);



INSERT INTO Category (CategoryName) VALUES
('Pain Relief'),
('Antibiotics'),
('Vitamins & Supplements'),
('Allergy & Sinus'),
('Digestive Health'),
('First Aid'),
('Skin Care'),
('Ayurvedic'),
('Herbal Remedies'),
('Diabetes Care'),
('Cardiovascular'),
('Respiratory');

INSERT INTO Supplier (SupplierName, Contact, Phone) VALUES
('Ceylon Pharma (Pvt) Ltd', 'Mr. Chaminda Perera', '+94 11 2345678'),
('Lanka Medica Supplies', 'Mrs. Shanthi Fernando', '+94 77 1234567'),
('AyurLife International', 'Dr. Anura Weerasinghe', '+94 71 9876543'),
('HealthGuard Lanka', 'Mr. Nishantha Kumara', '+94 81 2345678'),
('Southern Drug Distributors', 'Ms. Kumari Jayasinghe', '+94 91 3456789');

INSERT INTO Medicine (Name, CategoryID, SupplierID, Dosage, Price, Stock, ExpiryDate, RequiresPrescription, Discount) VALUES

('Puhul (Bael) Syrup', 
    (SELECT CategoryID FROM Category WHERE CategoryName = 'Ayurvedic'), 
    (SELECT SupplierID FROM Supplier WHERE SupplierName = 'AyurLife International'),
    '500ml syrup', 850.00, 120, '2027-06-30', 0, 5.00),

('Amoxicillin 500mg Capsules', 
    (SELECT CategoryID FROM Category WHERE CategoryName = 'Antibiotics'), 
    (SELECT SupplierID FROM Supplier WHERE SupplierName = 'Ceylon Pharma (Pvt) Ltd'),
    '500mg capsule', 350.00, 200, '2026-09-15', 1, NULL)*/


/*SELECT * FROM [User];*/
SELECT * FROM Category;

/*DELETE FROM Medicine WHERE Name = 'Aspirin 75mg Tablets';*/


