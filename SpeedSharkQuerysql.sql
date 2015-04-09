use SpeedSharkDB

create table Employee
(
fName nvarchar(50) not null,
lName nvarchar(50) not null,
username nvarchar(50) not null,
password nvarchar(50) not null,
primary key(username)
)

create table Customer
(
CVR nvarchar(50) not null,
fName nvarchar(50) not null,
lName nvarchar(50) not null,
city nvarchar(50) not null,
address nvarchar(50) not null,
phoneNo nvarchar(50),
email nvarchar(50) not null,
primary key(CVR)
)

create table Truck
(
truckId int not null identity(1,1),
status nvarchar(50) not null,
primary key(truckId)
)

create table Cargo
(
cargoId int not null identity(1,1),
weight float not null,
primary key(cargoId)
)

create table Session
(
sessionId int not null identity(1,1),
cargoId int not null,
departureTime datetime not null,
arrivalTime datetime not null,
truckId int not null,
destCity nvarchar(50) not null,
destAddress nvarchar(50) not null,
primary key(sessionId),
foreign key(cargoId) references Cargo(cargoId),
foreign key(truckId) references Truck(truckId)
)

create table Orders
(
orderId int not null identity(1,1),
orderNo nvarchar(50) not null,
custCVR nvarchar(50) not null,
price float not null,
sessionId int not null,
cargoId int not null,
status nvarchar(50) not null,
primary key(orderId),
foreign key(sessionId) references Session(sessionId),
foreign key(custCVR) references Customer(CVR),
foreign key(cargoId) references Cargo(cargoId)
)






