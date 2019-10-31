USE MASTER
CREATE DATABASE Pharmacy

USE Pharmacy

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
street			VARCHAR(60) NOT NULL,
city			VARCHAR(30) NOT NULL,
stateAbbr		CHAR(2) NOT NULL,
zip				INT NOT NULL,
phone1			VARCHAR(15) NOT NULL,	
phone2			VARCHAR(15),
email1			VARCHAR(100) NOT NULL,
email2			VARCHAR(100) NOT NULL,
gender			CHAR(1) NOT NULL CHECK(gender IN('M','F','O')),
SPECIALTY1		VARCHAR(60),
SPECIALTY2		VARCHAR(60)
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