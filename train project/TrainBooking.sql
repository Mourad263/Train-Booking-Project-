--
-- Database: `TrainBooking`
--
CREATE database TrainBooking;

use TrainBooking;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE [User] (
    Userid INT IDENTITY(1,1) PRIMARY KEY,
    Firstname VARCHAR(50),
    Lastname VARCHAR(50),
    Address VARCHAR(60),
    Age INT,
    RegistrationDate datetime,
    Email VARCHAR(60),
    Password1 VARCHAR(40)
);

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE [Admin] (
    AdminId INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    [Address] VARCHAR(60),
    Age INT,
    RegistrationDate datetime,
    Email VARCHAR(60),
    Password1 VARCHAR(40)
);

-- --------------------------------------------------------

--
-- Table: Train                                                 
--
CREATE TABLE Train
(
   [Train-id]           INT NOT NULL PRIMARY KEY,
   Trainname            TEXT,
   Source               varchar(15) DEFAULT NULL,
   Destination          varchar(15) DEFAULT NULL,
   Distance             NUMERIC(10,0),
   ArrivalTime          DATETIME,
   [Departure-Time]     DATETIME,
   [Admin-no]           INT NOT NULL,
   [Seat-no]            NUMERIC(20,0),
   FOREIGN KEY ([Admin-no]) REFERENCES [Admin](AdminId),
   CONSTRAINT CHK_Train_Arrival_Departure CHECK (ArrivalTime > [Departure-Time])
);
-- --------------------------------------------------------


--
-- Table structure for table `paymentviavisa`
--

CREATE TABLE Payment (
  PaymentId INT IDENTITY(1,1) PRIMARY KEY,
  PaymentDate datetime DEFAULT NULL,
  PaymentStatus varchar(15) DEFAULT NULL,
  PaymentGateway varchar(15) DEFAULT NULL,
  Amount int DEFAULT NULL,
  VisaNumber varchar(20) DEFAULT NULL,
  PaymentMethod  varchar(15) DEFAULT NULL
) ;

-- --------------------------------------------------------

--
-- Table: Trip                                                  
--
CREATE TABLE Trip 
(
   [Trip-no]           INT NOT NULL PRIMARY KEY,
   [Admin-no]           INT NOT NULL,
   [Train-id]           INT NOT NULL,
   [trip-duration]      Decimal,
   [Arrival-station]    CHAR(30),
   [Departure-station]  CHAR(30),
   [Available-seats]    INt,
   Budget               INT,
   FOREIGN KEY ([Admin-no]) REFERENCES [Admin](AdminId),
   FOREIGN KEY ([Train-id]) REFERENCES Train([Train-id])
   ON DELETE CASCADE,
   CONSTRAINT CHK_Trip_Duration CHECK ([trip-duration] > 0)
);
-- --------------------------------------------------------

--
-- Table structure for table `ticket`
--

CREATE TABLE Ticket (
    TicketId INT IDENTITY(1,1) PRIMARY KEY,
	UserID INT NOT NULL,
	TripID Int NOT NULL,
	PaymentID Int NOT NULL,
    Class VARCHAR(30),
	FOREIGN KEY (UserID) REFERENCES [User](Userid), --
	FOREIGN KEY (TripID) REFERENCES [Trip]([Trip-no])
	ON DELETE CASCADE,
	FOREIGN KEY (PaymentID) REFERENCES Payment(PaymentId) --
);



-- --------------------------------------------------------
--
-- Indexes for Table Class                                                 
--
CREATE TABLE Class
(
   classid              INT IDENTITY(1,1) PRIMARY KEY,
   className            varchar(15) DEFAULT NULL,
   [Train-id]           Int NOT NULL,
   FOREIGN KEY ([Train-id]) REFERENCES Train([Train-id])
); 

-- --------------------------------------------------------

--
-- Table: Station                                              
--
CREATE TABLE Station
(
   [Station-no]         INT NOT NULL PRIMARY KEY,
   [Station-name]       TEXT
);

-- --------------------------------------------------------

--
-- Table: Train <-> Staion                                                
--

CREATE TABLE Details 
(
   StationId INT,
   TrainId INT,
   PRIMARY KEY (StationId, TrainId),
   FOREIGN KEY (StationId) REFERENCES Station ([Station-no]),
   FOREIGN KEY (TrainId) REFERENCES Train ([Train-id])
);

-- --------------------------------------------------------

-- inserting some data

INSERT INTO [User] (Firstname, Lastname, Address, Age, RegistrationDate, Email, Password1)
VALUES 
    ('John', 'Doe', '123 Main St', 25, GETDATE(), 'john.doe@example.com', 'password123'),
    ('Jane', 'Smith', '456 Elm St', 30, GETDATE(), 'jane.smith@example.com', 'password456'),
    ('Michael', 'Johnson', '789 Oak St', 35, GETDATE(), 'michael.johnson@example.com', 'password789'),
    ('Emily', 'Davis', '234 Maple St', 28, GETDATE(), 'emily.davis@example.com', 'password234'),
    ('David', 'Wilson', '567 Pine St', 32, GETDATE(), 'david.wilson@example.com', 'password567'),
    ('Sarah', 'Anderson', '890 Cedar St', 29, GETDATE(), 'sarah.anderson@example.com', 'password890'),
    ('James', 'Brown', '345 Walnut St', 27, GETDATE(), 'james.brown@example.com', 'password345'),
    ('Jennifer', 'Taylor', '678 Birch St', 31, GETDATE(), 'jennifer.taylor@example.com', 'password678'),
    ('William', 'Clark', '901 Spruce St', 33, GETDATE(), 'william.clark@example.com', 'password901'),
    ('Olivia', 'Hall', '456 Oak St', 26, GETDATE(), 'olivia.hall@example.com', 'password456');

INSERT INTO [Admin] (FirstName, LastName, [Address], Age, RegistrationDate, Email, Password1)
VALUES 
    ('John', 'Doe', '123 Main St', 25, GETDATE(), 'john.doe@example.com', 'password123'),
    ('Jane', 'Smith', '456 Elm St', 30, GETDATE(), 'jane.smith@example.com', 'password456'),
    ('Michael', 'Johnson', '789 Oak St', 35, GETDATE(), 'michael.johnson@example.com', 'password789'),
    ('Emily', 'Davis', '234 Maple St', 28, GETDATE(), 'emily.davis@example.com', 'password234'),
    ('David', 'Wilson', '567 Pine St', 32, GETDATE(), 'david.wilson@example.com', 'password567'),
    ('Sarah', 'Anderson', '890 Cedar St', 29, GETDATE(), 'sarah.anderson@example.com', 'password890'),
    ('James', 'Brown', '345 Walnut St', 27, GETDATE(), 'james.brown@example.com', 'password345'),
    ('Jennifer', 'Taylor', '678 Birch St', 31, GETDATE(), 'jennifer.taylor@example.com', 'password678'),
    ('William', 'Clark', '901 Spruce St', 33, GETDATE(), 'william.clark@example.com', 'password901'),
    ('Olivia', 'Hall', '456 Oak St', 26, GETDATE(), 'olivia.hall@example.com', 'password456');

INSERT INTO Station ([Station-no], [Station-name])
VALUES 
    (1, 'Cairo'),
    (2, 'Alexandria'),
    (3, 'Giza'),
    (4, 'Luxor'),
    (5, 'Aswan'),
    (6, 'Hurghada'),
    (7, 'Sharm El-Sheikh'),
    (8, 'Port Said'),
    (9, 'Suez'),
    (10, 'Mansoura');

INSERT INTO Train ([Train-id], Trainname, Source, Destination, Distance,  [Departure-Time],ArrivalTime, [Admin-no], [Seat-no])
VALUES
    (1, 'Train 1', 'Source 1', 'Destination 1', 100, '2023-05-21 08:00:00', '2023-05-21 10:00:00', 1, 50),
    (2, 'Train 2', 'Source 2', 'Destination 2', 150, '2023-05-21 09:00:00', '2023-05-21 11:00:00', 2, 60),
    (3, 'Train 3', 'Source 3', 'Destination 3', 200, '2023-05-21 10:00:00', '2023-05-21 12:00:00', 1, 70),
    (4, 'Train 4', 'Source 4', 'Destination 4', 120, '2023-05-21 11:00:00', '2023-05-21 13:00:00', 2, 80),
    (5, 'Train 5', 'Source 5', 'Destination 5', 180, '2023-05-21 12:00:00', '2023-05-21 14:00:00', 1, 90),
    (6, 'Train 6', 'Source 6', 'Destination 6', 140, '2023-05-21 13:00:00', '2023-05-21 15:00:00', 2, 100),
    (7, 'Train 7', 'Source 7', 'Destination 7', 160, '2023-05-21 14:00:00', '2023-05-21 16:00:00', 1, 110),
    (8, 'Train 8', 'Source 8', 'Destination 8', 130, '2023-05-21 15:00:00', '2023-05-21 17:00:00', 2, 120),
    (9, 'Train 9', 'Source 9', 'Destination 9', 170, '2023-05-21 16:00:00', '2023-05-21 18:00:00', 1, 130),
    (10, 'Train 10', 'Source 10', 'Destination 10', 190, '2023-05-21 17:00:00', '2023-05-21 19:00:00', 2, 140);

INSERT INTO Details (StationId, TrainId)
VALUES
    (1, 1),
    (2, 2),
    (3, 3),
    (4, 4),
    (5, 5),
    (6, 6),
    (7, 7),
    (8, 8),
    (9, 9),
    (10, 10);


INSERT INTO Trip ([Trip-no], [Admin-no], [Train-id], [trip-duration], [Arrival-station], [Departure-station], [Available-seats], Budget)
VALUES
    (1, 1, 1, 2.5, 'Station A', 'Station B', 100, 500),
    (2, 1, 2, 3.0, 'Station B', 'Station C', 150, 700),
    (3, 2, 3, 1.5, 'Station C', 'Station D', 80, 400),
    (4, 2, 4, 2.0, 'Station D', 'Station E', 120, 600),
    (5, 3, 5, 2.5, 'Station E', 'Station F', 90, 450),
    (6, 3, 6, 3.5, 'Station F', 'Station G', 100, 500),
    (7, 4, 7, 2.0, 'Station G', 'Station H', 70, 350),
    (8, 4, 8, 1.5, 'Station H', 'Station I', 110, 550),
    (9, 5, 9, 3.0, 'Station I', 'Station J', 130, 650),
    (10, 5, 10, 2.5, 'Station J', 'Station K', 80, 400);

INSERT INTO Payment (PaymentDate, PaymentStatus, PaymentGateway, Amount, VisaNumber, PaymentMethod)
VALUES
    ('2023-05-01 10:30:00', 'Completed', 'PayPal', 100, NULL, 'Cash'),
    ('2023-05-02 11:45:00', 'Pending', 'Stripe', 50, '1234567890123456', 'Visa'),
    ('2023-05-03 12:15:00', 'Completed', 'PayPal', 80, NULL, 'Cash'),
    ('2023-05-04 09:00:00', 'Completed', 'Stripe', 200, '9876543210987654', 'Visa'),
    ('2023-05-05 14:20:00', 'Pending', 'PayPal', 120, NULL, 'Cash'),
    ('2023-05-06 16:45:00', 'Completed', 'Stripe', 150, '5432109876543210', 'Visa'),
    ('2023-05-07 13:30:00', 'Completed', 'PayPal', 90, NULL, 'Cash'),
    ('2023-05-08 11:10:00', 'Pending', 'Stripe', 180, '0123456789012345', 'Visa'),
    ('2023-05-09 08:45:00', 'Completed', 'PayPal', 70, NULL, 'Cash'),
    ('2023-05-10 17:00:00', 'Completed', 'Stripe', 110, '9876543210123456', 'Visa');


INSERT INTO Ticket (UserID, TripID, PaymentID, Class)
VALUES
    (1, 1, 1, 'Economy'),
    (2, 2, 2, 'Business'),
    (3, 3, 3, 'First Class'),
    (4, 4, 4, 'Economy'),
    (5, 5, 5, 'Business'),
    (6, 6, 6, 'First Class'),
    (7, 7, 7, 'Economy'),
    (8, 8, 8, 'Business'),
    (9, 9, 9, 'First Class'),
    (10, 10, 10, 'Economy');
