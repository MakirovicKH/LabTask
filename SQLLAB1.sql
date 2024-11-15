CREATE DATABASE ACADEMY
USE ACADEMY



CREATE TABLE Students(
Id int IDENTITY PRIMARY KEY,
FirstName NVARCHAR(50) NOT NULL,
LastName NVARCHAR(50) NOT NULL,
DataOfBirth DATE,
Username NVARCHAR(50) UNIQUE NOT NULL,
Password NVARCHAR(20) NOT NULL,
EnrollmentDate DATE
)

EXEC InsertStudent 
    @FirstName = 'Mahir',
    @LastName = 'Khalilov',
    @DataOfBirth = '03/06/2005',
    @Username = 'makirovic',
    @Password = 'makirovic123',
    @EnrollmentDate = '09/15/2024';


EXEC InsertStudent 
    @FirstName = 'Elvin',
    @LastName = 'Hüseynov',
    @DataOfBirth = '2004-05-10',
    @Username = 'elvin2004',
    @Password = 'passElvin',
    @EnrollmentDate = '2024-09-15';

EXEC InsertStudent 
    @FirstName = 'Nigar',
    @LastName = 'Həsənova',
    @DataOfBirth = '2003-07-25',
    @Username = 'nigarr',
    @Password = 'nigar123',
    @EnrollmentDate = '2024-10-01';

EXEC InsertStudent 
    @FirstName = 'Tural',
    @LastName = 'Məmmədov',
    @DataOfBirth = '2005-12-05',
    @Username = 'turalM',
    @Password = 'turM555',
    @EnrollmentDate = '2024-11-01';

	SELECT * 
FROM sys.objects 
WHERE object_id = OBJECT_ID(N'InsertStudent') 
      AND type IN (N'P', N'PC');


CREATE PROCEDURE InsertStudent
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @DataOfBirth DATE,
    @Username NVARCHAR(50),
    @Password NVARCHAR(20),
    @EnrollmentDate DATE
AS
BEGIN
        INSERT INTO Students (FirstName, LastName, DataOfBirth, Username, Password, EnrollmentDate)
        VALUES (@FirstName, @LastName, @DataOfBirth, @Username, @Password, @EnrollmentDate);
END

	

CREATE TABLE Departments(
Id INT IDENTITY PRIMARY KEY,
DepartmentName NVARCHAR(25)
)


INSERT INTO Departments (DepartmentName) 
VALUES ('İnformasiya TEX');

INSERT INTO Departments (DepartmentName) 
VALUES ('Riyaziyyat');

INSERT INTO Departments (DepartmentName) 
VALUES ('Fizika');



DROP TABLE Departments
SELECT * FROM Departments

CREATE TABLE Instructors(
Id int IDENTITY PRIMARY KEY,
FirstName NVARCHAR(50) NOT NULL,
LastName NVARCHAR(50) NOT NULL,
HireDate DATE,
DepartmentId INT,
FOREIGN KEY (DepartmentId) REFERENCES Departments(Id),
Username NVARCHAR(50) UNIQUE NOT NULL,
Password NVARCHAR(20) NOT NULL,
Pin NVARCHAR(10) NOT NULL
)

INSERT INTO Instructors (FirstName, LastName, HireDate, Username, Password, Pin) 
VALUES ('Rəşad', 'Quliyev', '2020-09-01', 'reshad123', 'password1', 'PIN001');

INSERT INTO Instructors (FirstName, LastName, HireDate, Username, Password, Pin) 
VALUES ('Leyla', 'Əliyeva', '2018-01-15', 'leyla87', 'secure2', 'PIN002');

INSERT INTO Instructors (FirstName, LastName, HireDate, Username, Password, Pin) 
VALUES ('Cavid', 'Əsgərov', '2019-06-20', 'cavid2024', 'pass123', 'PIN003');



CREATE TABLE [Group](
Id int IDENTITY PRIMARY KEY,
GroupName NVARCHAR(25),
DepartmentId INT,
FOREIGN KEY (DepartmentId) REFERENCES Departments(Id),
StartDate DATE,
EndDATE DATE
)

INSERT INTO [Group] (GroupName, StartDate, EndDate) 
VALUES ('AB101', '2024-09-01', '2025-06-30');

INSERT INTO [Group] (GroupName, StartDate, EndDate) 
VALUES ('CS202', '2024-10-01', '2025-05-30');

INSERT INTO [Group] (GroupName, StartDate, EndDate) 
VALUES ('PH303',  '2024-11-01', '2025-07-30');


CREATE TABLE Enrollments(
Id int IDENTITY PRIMARY KEY,
StudentId INT,
GroupId INT,
FOREIGN KEY (StudentId) REFERENCES Students(Id),
FOREIGN KEY (GroupId) REFERENCES [GROUP](Id),
)
INSERT INTO Enrollments VALUES ('1')

------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------


CREATE TABLE ClassesTable(
Id int IDENTITY PRIMARY KEY,
GroupId INT,
FOREIGN KEY (GroupId) REFERENCES [GROUP](Id),
InstructorId INT,
FOREIGN KEY (InstructorId) REFERENCES Instructors(Id),
Schedule NVARCHAR(50),
RoomName NVARCHAR(50)
)

INSERT INTO ClassesTable (Schedule, RoomName) 
VALUES ( '01/02/2024', 'Otaq 101');

INSERT INTO ClassesTable ( Schedule, RoomName) 
VALUES ('01/03/2024', 'Otaq 202');

INSERT INTO ClassesTable ( Schedule, RoomName) 
VALUES ('01/04/2024', 'Otaq 303');


DECLARE @StudentId INT = 1;

SELECT 
    S.Id AS StudentId,
     S.FirstName + ' ' + S.LastName AS StudentName,
    G.GroupName AS GroupName,
    CT.Schedule AS Schedule,
    CT.RoomName AS RoomName
FROM 
    Students S
INNER JOIN Enrollments E ON S.Id = E.StudentId
INNER JOIN [Group] G ON E.GroupId = G.Id
INNER JOIN ClassesTable CT ON G.Id = CT.GroupId
WHERE 
    S.Id = @StudentId; 

