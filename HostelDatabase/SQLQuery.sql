CREATE DATABASE HostelManagementDB;

create table Rooms(
roomId int identity(1,1) primary key,
roomNo varchar(250) not null unique,
roomType varchar(250) not null,
bed varchar (250) not null,
price bigint not null,
booked varchar(50) default  ' No'
);
ALTER TABLE Rooms
ADD CONSTRAINT UK_roomNo UNIQUE (roomNo);

INSERT INTO Rooms (roomNo, roomType, bed, price)
VALUES ('101', 'Ac', 'Single', 10000),
       ('102', 'Non-Ac', 'Double', 6000),
       ('103', 'Non-Ac', 'Single', 8000),
       ('104', 'Ac', 'Double', 8000);

	   Select * from Rooms;
	


Create table Student(
cId int identity(1,1) primary key,
cname varchar (250) not null,
mobile bigint not null,
clgEmail varchar(250) not null,
gender varchar(50) not null,
dob varchar(50) not null,
idproof varchar(250) not null,
address varchar(250) not null,
joindate varchar(250) not null,
checkout_date varchar(250),
checkout_status varchar(250) not null default 'No',
roomId int not null,
foreign key (roomId) references Rooms(roomId)
);
ALTER TABLE Student
ADD CONSTRAINT FK_roomNo FOREIGN KEY (roomNo) REFERENCES Rooms(roomNo);

ALTER TABLE Student
ADD roomNo unique;
ALTER TABLE Student
ALTER COLUMN roomNo int NOT NULL;
ALTER TABLE Student
ADD CONSTRAINT FK_RoomNo FOREIGN KEY (roomNo) REFERENCES Rooms(roomNo);

cname,mobile,clgEmail,gender,dob,idproof,address,joindate,roomId
INSERT INTO Student(cname, mobile, clgEmail, gender, dob, idproof, address, joindate, checkout_date, checkout_status,roomId)
VALUES ('Saket',9875479621,'22bcae54@kristujayanti.com','Male','02-01-2002','54789123456','patna,India','20-03-2024','','NO',1 );

INSERT INTO Student(cname, mobile, clgEmail, gender, dob, idproof, address, joindate, checkout_date, checkout_status,roomId)
VALUES ('Tanmay',6364521478,'22bcae63@kristujayanti.com','Male','25-01-2004','8745691456289','Mumabi,India','20-02-2024','20-02-2026','Yes',2 );


INSERT INTO Student(cname, mobile, clgEmail, gender, dob, idproof, address, joindate, checkout_date, checkout_status,roomId)
VALUES ('Martin',8484525478,'22bcae40@kristujayanti.com','Male','25-01-2003','123456789123','Kolkata,India','10-01-2024','10-01-2026','Yes',1 );


select * from Student;

select * from Rooms;

ALTER TABLE Student
DROP COLUMN roomNo;

DELETE FROM Rooms WHERE roomId = '1'
DELETE FROM Student where roomId = '1'

DBCC CHECKIDENT ('Rooms', RESEED, 0)
DBCC CHECKIDENT ('Student', RESEED, 0)

SELECT roomNo 
FROM Rooms 
WHERE bed = 'Single' 
  AND roomType = 'Ac' 
  AND booked = 'No';

SELECT roomNo 
FROM Rooms 
WHERE 
    RTRIM(LTRIM(bed)) = 'Single' 
    AND RTRIM(LTRIM(roomType)) = 'Ac' 
    AND RTRIM(LTRIM(booked)) = 'No';


	ALTER TABLE Rooms
ADD currentOccupancy INT NOT NULL DEFAULT 0;

ALTER TABLE Rooms DROP CONSTRAINT UQ__Rooms__6C3BFE6CA86816DA;

select booked from rooms;






"Select Student.cId,Student.cname,Student.mobile,Student.clgEmail,Student.gender,Student.dob,Student.idproof,Student.address,Student.joindate,Rooms.roomNo,Rooms.roomType,Rooms.bed,Rooms.price from Student inner join Rooms on Student.roomId = Rooms.roomId where checkout_status = 'No' "


SELECT 
    Stu.cId,
    Stu.cname,
    Stu.mobile,
    Stu.clgEmail,
    Stu.gender,
    Stu.dob,
    Stu.idproof,
    Stu.address,
    Stu.joindate,
    Rms.roomNo,
    Rms.roomType,
    Rms.bed,
    Rms.price 
FROM 
    Student Stu
INNER JOIN 
    Rooms Rms ON Stu.roomId = Rms.roomId 
WHERE 
    checkout_status = 'No'


	Create table Admin(
	Username varchar(250) primary key,
	password varchar(250) not null);

	Insert into Admin values('Kjc','123');
	select * from Admin

ALTER TABLE Student
ADD feedback VARCHAR(max);

					SELECT 
                            Stu.cId,
                            Stu.cname,
                            Stu.mobile,
                            Stu.clgEmail,
                            Stu.gender,
                            Stu.dob,
                            Stu.idproof,
                            Stu.address,
                            Stu.joindate,
                            Stu.checkout_date,
                            stu.checkout_status,
                            Rms.roomNo,
                            Rms.roomType,
                            Rms.bed,
                            Rms.price 
                    FROM
                            Student Stu
                    INNER Join 
                            Rooms Rms ON Stu.roomId = Rms.roomId 
                    where clgEmail = '22bcae42@kristujayanti.com' ;

Select cId,clgEmail,Stu_Password from Student where clgEmail = '22bcae42@kristujayanti.com' And Stu_Password ='12345'




		select * from Student