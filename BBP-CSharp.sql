-- Drop and create the database
USE master
GO
DROP DATABASE IF EXISTS BBP_CSharp;
GO
CREATE DATABASE BBP_CSharp;
GO
USE BBP_CSharp;

-- Create Users table  
CREATE TABLE Users (
  userId INT NOT NULL,
  username VARCHAR(255) NOT NULL, 
  password NVARCHAR(255) NOT NULL,
  firstName NVARCHAR(255),
  lastName NVARCHAR(255),
  email NVARCHAR(255),
  phone VARCHAR(255),
  avatarLink NVARCHAR(255),
  role VARCHAR(255),
  PRIMARY KEY (userId)
);

-- Create TableType table
CREATE TABLE TableType (
  tableTypeId INT NOT NULL,
  typeName NVARCHAR(255) NOT NULL,
  typeDescription NVARCHAR(255),
  PRIMARY KEY (tableTypeId)
);

-- Create Booking table
CREATE TABLE Booking (
  bookingId INT NOT NULL,
  customerId INT NOT NULL,
  clubId INT NOT NULL,
  clubStaffId INT,
  bookingStatus BIT,
  bookDate DATETIME,
  PRIMARY KEY (bookingId)
);

-- Create Price table  
CREATE TABLE Price (
  tableTypeId INT NOT NULL,
  slotId INT NOT NULL,
  price INT,
  PRIMARY KEY (tableTypeId, slotId)
);

-- Create Club table
CREATE TABLE Club (
  clubId INT NOT NULL,
  clubName NVARCHAR(255) NOT NULL,
  address NVARCHAR(255) NOT NULL,
  fanpageLink NVARCHAR(255),
  avatarLink NVARCHAR(255),
  openTime INT,
  closeTime INT,
  email VARCHAR(255),
  phone VARCHAR(255),
  status bit,
  PRIMARY KEY (clubId)
);

-- Create Table (Table is a reserved keyword) Table  
CREATE TABLE [Table] (
  tableId INT NOT NULL,
  tableTypeId INT NOT NULL,
  clubId INT NOT NULL,
  isAvailable BIT,
  PRIMARY KEY (tableId)
);

-- Create BookingDetail table
CREATE TABLE BookingDetail (
  bookingDetailId INT NOT NULL,
  bookingId INT NOT NULL,
  slotId INT NOT NULL,  
  tableId INT NOT NULL,
  price INT,
  PRIMARY KEY (bookingDetailId)
);

-- Create Slot table
CREATE TABLE Slot (
  slotId INT NOT NULL,
  startTime INT,
  endTime INT,
  PRIMARY KEY (slotId)
);


-- Define foreign keys

-- Booking
ALTER TABLE Booking  
ADD CONSTRAINT FK_Booking_ClubId FOREIGN KEY (clubId) REFERENCES Club(clubId);

-- BookingDetail FK
ALTER TABLE BookingDetail
ADD CONSTRAINT FK_BookingDetail_BookingId FOREIGN KEY (bookingId) REFERENCES Booking(bookingId);

ALTER TABLE BookingDetail
ADD CONSTRAINT FK_BookingDetail_SlotId FOREIGN KEY (slotId) REFERENCES Slot(slotId);

ALTER TABLE BookingDetail
ADD CONSTRAINT FK_BookingDetail_TableId FOREIGN KEY (tableId) REFERENCES [Table](tableId);

-- Table FK
ALTER TABLE [Table]  
ADD CONSTRAINT FK_Table_TableTypeId FOREIGN KEY (tableTypeId) REFERENCES TableType(tableTypeId);

ALTER TABLE [Table]
ADD CONSTRAINT FK_Table_ClubId FOREIGN KEY (clubId) REFERENCES Club(clubId);

-- Price FK
ALTER TABLE Price
ADD CONSTRAINT FK_Price_TableTypeId FOREIGN KEY (tableTypeId) REFERENCES TableType(tableTypeId);

ALTER TABLE Price
ADD CONSTRAINT FK_Price_SlotId FOREIGN KEY (slotId) REFERENCES Slot(slotId);


-- Sample Data Inserts

-- Users Table
INSERT INTO Users (userId, username, password, firstName, lastName, email, phone, avatarLink, role)
VALUES
(1, 'admin', '123', 'Admin', 'User', 'admin_user@gmail.com', '5555555555', 'admin_avatar.jpg', 'Staff');

-- TableType Table  
INSERT INTO TableType (tableTypeId, typeName, typeDescription)
VALUES
(1, N'Phăng', N'Bàn loại phăng'),  
(2, N'Lỗ', N'Bàn loại lỗ');

-- Slot Table
INSERT INTO Slot (slotId, startTime, endTime)
VALUES  
(1, 9, 10),
(2, 10, 11),
(3, 11, 12),
(4, 12, 13),
(5, 13, 14),
(6, 14, 15),
(7, 15, 16),
(8, 16, 17),
(9, 17, 18),
(10, 18, 19),
(11, 19, 20),
(12, 20, 21);