create Table CarImages(
					   Id int PRIMARY KEY IDENTITY(1,1),
					   CarId int,
					   ImagePath varChar(150),
					   Date dateTime,
					   FOREIGN KEY (CarId) REFERENCES Cars(CarId),
)