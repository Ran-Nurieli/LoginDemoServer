Create Database LoginDemoDB
Go
use LoginDemoDB

Create Table Users (
	Email nvarchar(100) PRIMARY KEY,
	[Password] nvarchar(20) NOT NULL,
	PhoneNumber nvarchar(20) NULL,
	BirthDate DATETIME NULL,
	[Status] int NULL,
	[Name] nvarchar(50) NOT NULL
)
Go

Create Table Grades (
Email nvarchar(100),
FOREIGN KEY (Email) REFERENCES Users(Email),
[Subject] nvarchar(100) NOT NULL,
BirthDate DATETIME NULL,
[Date] int NULL,
Grade int Null

)
Go

INSERT INTO dbo.Users VALUES ('talsi@talsi.com', '1234', '+972506665835','20-may-1976',1,'Tal Simon')
INSERT INTO dbo.Grades VALUES ('talsi@talsi.com', 'Math','20-may-1976','95')
INSERT INTO dbo.Grades VALUES ('ran123.com', 'English','14-January-2007','95')
Go

--scaffold-DbContext "Server = (localdb)\MSSQLLocalDB;Initial Catalog=LoginDemoDB;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0" Microsoft.EntityFrameworkCore.SqlServer -OutPutDir Models -Context LoginDemoDbContext -DataAnnotations -force