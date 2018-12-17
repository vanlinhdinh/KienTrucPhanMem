/*
	1-Admin
	0-Nhan Vien
*/
INSERT INTO dbo.Account
(
    userName,
    passWordUser,
    style
)
VALUES
(   'trido113',  -- userName - varchar(50)
    '123456',  -- passWordUser - varchar(50)
    1 -- style - bit
)

INSERT INTO dbo.Account
(
    userName,
    passWordUser,
    style
)
VALUES
(   'trido123',  -- userName - varchar(50)
    '123456',  -- passWordUser - varchar(50)
    2 -- style - bit
)

--Insert foodTable

DECLARE @i INT=0
WHILE @i<=8
BEGIN
	Insert INTO dbo.TableFood VALUES
	(
		N'Bàn'+CAST(@i AS varchar(10)),
		N'Trống'
	)
	SET @i=@i+1
END

--Add FoodCategory
go
insert into dbo.FoodCategory(nameFoodCategory)
values(N'Hải Sản')
go
insert into dbo.FoodCategory(nameFoodCategory)
values(N'Món Nướng')
go
insert into dbo.FoodCategory(nameFoodCategory)
values(N'Món Lẩu')
go
go
insert into dbo.FoodCategory(nameFoodCategory)
values(N'Món Chay')
go
insert into dbo.FoodCategory(nameFoodCategory)
values(N'Món khác')

--Thêm món ăn
insert into dbo.Food(nameFood,price,idFoodCategory)
values(N'Tôm hấp bia',90000,1)
insert into dbo.Food(nameFood,price,idFoodCategory)
values(N'Mực xào ớt xanh',80000,1)
insert into dbo.Food(nameFood,price,idFoodCategory)
values(N'Hàu tái chanh',120000,1)

insert into dbo.Food(nameFood,price,idFoodCategory)
values(N'Vịt nướng chao',110000,2)
insert into dbo.Food(nameFood,price,idFoodCategory)
values(N'Vú heo nướng sa tế',70000,2)
insert into dbo.Food(nameFood,price,idFoodCategory)
values(N'Sườn nướng mật ong',120000,2)

insert into dbo.Food(nameFood,price,idFoodCategory)
values(N'Lẩu chao vịt',150000,3)
insert into dbo.Food(nameFood,price,idFoodCategory)
values(N'Lẩu thập cẩm',160000,3)
insert into dbo.Food(nameFood,price,idFoodCategory)
values(N'Lẩu gà lá giang',140000,3)

insert into dbo.Food(nameFood,price,idFoodCategory)
values(N'đậu hũ chiên',30000,4)
insert into dbo.Food(nameFood,price,idFoodCategory)
values(N'Rau thập cẩm luộc',40000,4)
insert into dbo.Food(nameFood,price,idFoodCategory)
values(N'Đùi gà chay chiên',45000,4)

insert into dbo.Food(nameFood,price,idFoodCategory)
values(N'Cơm chiên cá mặn',90000,5)
insert into dbo.Food(nameFood,price,idFoodCategory)
values(N'Mì xào thập cẩm',75000,5)
insert into dbo.Food(nameFood,price,idFoodCategory)
values(N'Cháo vịt',69000,5)


--thêm bill
insert into dbo.Bill(dateCheckIn, dateCheckOUt, discount,idTable,statusBill)
values(
	GETDATE(),
	null,
	10000,
	1,
	1
)

insert into dbo.Bill(dateCheckIn, dateCheckOUt, discount,idTable,statusBill)
values(
	GETDATE(),
	null,
	14000,
	2,
	1
)

insert into dbo.Bill(dateCheckIn, dateCheckOUt, discount,idTable,statusBill)
values(
	GETDATE(),
	GETDATE(),
	12000,
	3,
	1
)

insert into dbo.BillInfo(idBillInfo,idBill,idFood)
values(1,1,1)
insert into dbo.BillInfo(idBillInfo,idBill,idFood)
values(2,1,2)
insert into dbo.BillInfo(idBillInfo,idBill,idFood)
values(3,2,1)
insert into dbo.BillInfo(idBillInfo,idBill,idFood)
values(4,3,1)
insert into dbo.BillInfo(idBillInfo,idBill,idFood)
values(5,1,1)

insert into dbo.BillInfo(idBill,idFood)
values(1,1)


SELECT *FROM dbo.Bill
SELECT *FROM dbo.BillInfo
SELECT *FROM TableFood

---------PROC-----------------
--PROC Display Detail TableFood
ALTER PROC TableFoodDetails @idTable INT
AS
	Select tb.nameTable,f.nameFood,f.price,COUNT(bif.idBillInfo) 'count'
	 From TableFood tb RIGHT JOIN Bill b 
	 ON tb.idTable=b.idTable RIGHT JOIN  BillInfo bif 
	 ON b.idBill=bif.idBill RIGHT JOIN Food f 
	 ON f.idFood=bif.idFood
	 Where tb.idTable=@idTable AND b.status=0
     Group By tb.nameTable,f.nameFood,f.price
GO

EXEC TableFoodDetails 1

--------------------------------

--Query

--PROC Display Detail TableFood
Create PROC TableFoodDetails @idTable INT
AS
	Select tb.nameTable,f.nameFood,f.price,COUNT(bif.idBillInfo) 'count'
	 From TableFood tb RIGHT JOIN Bill b 
	 ON tb.idTable=b.idTable RIGHT JOIN  BillInfo bif 
	 ON b.idBill=bif.idBill RIGHT JOIN Food f 
	 ON f.idFood=bif.idFood
	 Where tb.idTable=@idTable AND b.statusBill=0
     Group By tb.nameTable,f.nameFood,f.price
GO

EXEC TableFoodDetails 1

