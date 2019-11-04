USE MASTER
CREATE DATABASE Pharmacy
GO

USE Pharmacy
GO

CREATE TABLE Users(
userId		INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_userId PRIMARY KEY,
username			VARCHAR(25) NOT NULL,
userpass			VARCHAR(250) NOT NULL,
)
INSERT INTO Users(username, userpass) VALUES ('evan', 'NYHdBrLO6VD5qevTj3DQGcdUA5bdyadHGEaPotoODfw=')

CREATE TABLE Patient(
patientId		INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_patientId PRIMARY KEY,
fName			VARCHAR(25) NOT NULL,
lName			VARCHAR(25) NOT NULL,
mInit			CHAR(1),
street			VARCHAR(60) NOT NULL,
city			VARCHAR(30) NOT NULL,
stateAbbr		CHAR(2) NOT NULL,
zip				INT NOT NULL,
phone1			VARCHAR(15) NOT NULL,
phone2			VARCHAR(15),
email			VARCHAR(100) NOT NULL,
DOB				DATE NOT NULL CHECK(DOB < GETDATE()),
gender			CHAR(1) NOT NULL CHECK(gender IN('M','F','O')),
InsuranceCo		VARCHAR(40),
InsuranceNum	VARCHAR(30),
)


CREATE TABLE Physician(
physicianId		INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_physicianId PRIMARY KEY,
fName			VARCHAR(25) NOT NULL,
lName			VARCHAR(25) NOT NULL,
mInit			CHAR(1),
gender			CHAR(1) NOT NULL CHECK(gender IN('M','F','O')),
street			VARCHAR(60) NOT NULL,
city			VARCHAR(30) NOT NULL,
stateAbbr		CHAR(2) NOT NULL,
zip				INT NOT NULL,
phone1			VARCHAR(15) NOT NULL,	
phone2			VARCHAR(15),
email			VARCHAR(100) NOT NULL,
specialty1		VARCHAR(60),
specialty2		VARCHAR(60)
)


CREATE TABLE Perscription(
perscriptionId	INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_perscriptionId PRIMARY KEY,
patientId		INT NOT NULL FOREIGN KEY (patientId) REFERENCES Patient(patientId),
physicianId		INT NOT NULL FOREIGN KEY (physicianId) REFERENCES Physician(physicianId),
medName			VARCHAR(40) NOT NULL,					-- drug name
medType			VARCHAR(15) NOT NULL,					-- drug type
dispense		VARCHAR(15) NOT NULL,					-- how much given out each time
intake			VARCHAR(125) NOT NULL,					-- how to drug
medDosage		VARCHAR(15) NOT NULL,					-- how many each time taken
freqNumber		INT NOT NULL,							-- how often number
freqInterval	VARCHAR(20) NOT NULL,					-- hour/day/week/month
maxRefills		INT NOT NULL							-- max refill times
)

CREATE TABLE Fill(
refillId		INT NOT NULL IDENTITY (1,1) CONSTRAINT PK_refillId PRIMARY KEY,
perscriptionId	INT NOT NULL FOREIGN KEY (perscriptionId) REFERENCES Perscription(perscriptionId),
refillsUsed		INT NOT NULL,
refillDate		DATETIME NOT NULL DEFAULT (GETDATE())
)


--Add Patient
CREATE PROC Add_Patient(
	@fName			VARCHAR(25),
	@lName			VARCHAR(25),
	@mInit			CHAR(1) = NULL,
	@DOB			DATE,
	@gender			CHAR(1),
	@street		VARCHAR(60),
	@city			VARCHAR(30),
	@stateAbbr		CHAR(2),
	@zip			INT,
	@phone1		VARCHAR(15),
	@phone2		VARCHAR(15) = NULL,
	@email		VARCHAR(100),
	@InsuranceCo	VARCHAR(40) = NULL,
	@InsuranceNum	VARCHAR(30) = NULL
)
AS
	BEGIN
	SET NOCOUNT ON;
		BEGIN TRANSACTION
			INSERT INTO Patient(fName, lName, mInit, DOB, gender, street, city, stateAbbr, zip, phone1, phone2, email, InsuranceCo, InsuranceNum)
			VALUES (@fName, @lName, @mInit, @DOB, @gender, @street, @city, @stateAbbr, @zip, @phone1, @phone2, @email, @InsuranceCo, @InsuranceNum)

			IF @@ERROR <> 0
				BEGIN
					ROLLBACK TRANSACTION
					RAISERROR ('Unable to insert record.',16,1)
					RETURN -1
				END
			ELSE
				BEGIN
					COMMIT TRANSACTION
					PRINT 'Record added successfully!'
				END
	END
GO

CREATE PROC Add_Physician(
	@fName			VARCHAR(25),
	@lName			VARCHAR(25),
	@mInit			CHAR(1) = NULL,
	@gender			CHAR(1),
	@street			VARCHAR(60),
	@city			VARCHAR(30),
	@stateAbbr		CHAR(2),
	@zip			INT,
	@phone1			VARCHAR(15),
	@phone2			VARCHAR(15) = NULL,
	@email			VARCHAR(100),
	@specialty1		VARCHAR(60) = NULL,
	@specialty2		VARCHAR(60) = NULL
)
AS
	BEGIN
	SET NOCOUNT ON;
		BEGIN TRANSACTION
			INSERT INTO Physician(fName, lName, mInit, gender,
				street, city, stateAbbr, zip, phone1,
				phone2, email, specialty1, specialty2)
			VALUES (@fName, @lName, @mInit, @gender, @street, 
				@city, @stateAbbr, @zip, @phone1, @phone2,
				@email, @specialty1, @specialty2)

				IF @@ERROR <> 0
				BEGIN
					ROLLBACK TRANSACTION
					RAISERROR ('Unable to insert record.',16,1)
					RETURN -1
				END
			ELSE
				BEGIN
					COMMIT TRANSACTION
					PRINT 'Record added successfully!'
				END
	END
GO


CREATE PROCEDURE dbo.sp_FindStringInTable @stringToFind VARCHAR(100), @schema sysname, @table sysname 
AS

BEGIN TRY
   DECLARE @sqlCommand varchar(max) = 'SELECT * FROM [' + @schema + '].[' + @table + '] WHERE ' 
	   
   SELECT @sqlCommand = @sqlCommand + '[' + COLUMN_NAME + '] LIKE ''' + @stringToFind + ''' OR '
   FROM INFORMATION_SCHEMA.COLUMNS 
   WHERE TABLE_SCHEMA = @schema
   AND TABLE_NAME = @table 
   AND DATA_TYPE IN ('char','nchar','ntext','nvarchar','text','varchar')

   SET @sqlCommand = left(@sqlCommand,len(@sqlCommand)-3)
   EXEC (@sqlCommand)
   PRINT @sqlCommand
END TRY

BEGIN CATCH 
   PRINT 'There was an error. Check to make sure object exists.'
   PRINT error_message()
END CATCH 
