create table Cars(
		CarId int PRIMARY KEY IDENTITY(1,1),
		BrandID int,
		ColorID int,
		ModelYear nvarchar(25),
		DailyPrice decimal,
		Descriptions nvarchar(25),
		FOREIGN KEY (BrandId) REFERENCES Brands(BrandId),
		FOREIGN KEY (ColorId) REFERENCES Colors(ColorId),

)

create table Colors(
		ColorId int PRIMARY KEY IDENTITY(1,1),
		ColorName nvarchar(25),
)

create table Brands(
		BrandId int PRIMARY KEY IDENTITY(1,1),
		BrandName nvarchar(25),
)

INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','1','2013','53000','Manual Diesel'),
	('2','2','2018','12000','Hybrid'),
	('3','2','2015','71000','Sedan Large Baggage'),
	('4','3','2010','34000','Manual Gasoline');

INSERT INTO Colors(ColorName)
VALUES
	('Yellow'),
	('Grey'),
	('Blue'),
	('Red');

INSERT INTO Brands(BrandName)
VALUES
	('Hyundai'),
	('Porsche'),
	('Opel'),
	('Fiat');
	