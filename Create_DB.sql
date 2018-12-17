CREATE TABLE TableFood
(
	idTable INT IDENTITY PRIMARY KEY,
	nameTable NVARCHAR(50) NOT NULL,
	statusTable NVARCHAR(50) NOT NULL
)

CREATE TABLE Account
(
	userName VARCHAR(50) PRIMARY KEY,
	passWordUser VARCHAR(50) NOT NULL,
	style BIT NOT NULL
)

CREATE TABLE FoodCategory
(
	idFoodCategory INT IDENTITY PRIMARY KEY,
	nameFoodCategory NVARCHAR(50) NOT NULL
)

CREATE TABLE Food
(
	idFood INT IDENTITY PRIMARY KEY,
	nameFood NVARCHAR(50) NOT NULL,
	price MONEY NOT NULL,
	idFoodCategory INT
	FOREIGN KEY(idFoodCategory)REFERENCES dbo.FoodCategory(idFoodCategory)
)

CREATE TABLE Bill
(
	idBill INT IDENTITY PRIMARY KEY,
	dateCheckIn DATE,
	dateCheckOUt DATE,
	discount INT ,
	idTable INT,
	totalPrice INT,
	statusBill bit,
	FOREIGN KEY(idTable) REFERENCES dbo.TableFood(idTable)
)

CREATE TABLE BillInfo
(
	idBillInfo INT IDENTITY PRIMARY KEY,
	idBill INT ,
	idFood INT,
	FOREIGN KEY(idBill) REFERENCES dbo.Bill(idBill),
	FOREIGN KEY(idFood) REFERENCES dbo.Food(idFood)
)

go	
alter table Account add constraint Account_PassWord  default 0 for passWordUser
go


