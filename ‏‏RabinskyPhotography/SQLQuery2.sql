
CREATE TABLE Photographers (
    Id int IDENTITY(1,1) PRIMARY KEY,
    FirstName varchar(255),
    LastName varchar(255) NOT NULL,
    PriceCode int  NOT NULL,
);

CREATE TABLE Prices (
    Code int IDENTITY(1,1) PRIMARY KEY,
    Price_for_320_photos int NOT NULL,
    Price_for_an_additional_hour_beyond_7_hours int NOT NULL,
    Price_for_an_additional_hour_after_1_am int   NOT NULL,
);

CREATE TABLE customers (
    Id int IDENTITY(1,1) PRIMARY KEY,
    KalaName varchar(255),
    ChatanName varchar(255) NOT NULL,
    Hall varchar(255) NOT NULL,
    PhotographerId int  NOT NULL,
    Phone varchar(255) NOT NULL,
);
ALTER TABLE customers
ADD CONSTRAINT FK_customers_to_Photographers
FOREIGN KEY (PhotographerId) REFERENCES Photographers(Id)

ALTER TABLE Photographers
ADD CONSTRAINT FK_Photographers_to_Prices
FOREIGN KEY (PriceCode) REFERENCES Prices(Code)