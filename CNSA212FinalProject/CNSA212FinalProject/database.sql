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
zip				CHAR(5) NOT NULL,
phone1			VARCHAR(15) NOT NULL,
phone2			VARCHAR(15),
email			VARCHAR(100) NOT NULL,
DOB				DATE NOT NULL CHECK(DOB < GETDATE()),
gender			CHAR(1) NOT NULL CHECK(gender IN('M','F','O')),
InsuranceCo		VARCHAR(40),
InsuranceNum	INT
)


CREATE TABLE Physician(
physicianId		INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_physicianId PRIMARY KEY,
fName			VARCHAR(25) NOT NULL,
lName			VARCHAR(25) NOT NULL,
mInit			CHAR(1),
street			VARCHAR(60) NOT NULL,
city			VARCHAR(30) NOT NULL,
stateAbbr		CHAR(2) NOT NULL,
zip				CHAR(5) NOT NULL,
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





--Stored procedures
--Add Physician
CREATE PROC Add_Physician(
	@fName			VARCHAR(25),
	@lName			VARCHAR(25),
	@mInit			CHAR(1) = NULL,
	@gender			CHAR(6),
	@SALARY			DECIMAL(8,2),
	@street		VARCHAR(60) = NULL,
	@city			VARCHAR(30) = NULL,
	@stateAbbr		CHAR(2) = NULL,
	@zip			INT = NULL,
	@phone1		VARCHAR(15) = NULL,
	@phone2		VARCHAR(15) = NULL,
	@email		VARCHAR(100) = NULL,
	@email2		VARCHAR(100) = NULL,
	@SPECIALTY1		VARCHAR(60) = NULL,
	@SPECIALTY2		VARCHAR(60) = NULL
)
AS
	BEGIN
	SET NOCOUNT ON;
		BEGIN TRANSACTION
			INSERT INTO PHYSICIAN(fName, lName, mInit, gender,
				SALARY, street, city, stateAbbr, zip, phone1,
				phone2, email, email2, SPECIALTY1, SPECIALTY2)
			VALUES (@fName, @lName, @mInit, @gender, @SALARY, @street, 
				@city, @stateAbbr, @zip, @phone1, @phone2,
				@email, @email2, @SPECIALTY1, @SPECIALTY2)

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





--Add Patient
CREATE PROC Add_Patient(
	@fName			VARCHAR(25),
	@lName			VARCHAR(25),
	@mInit			CHAR(1) = NULL,
	@DOB			DATE,
	@gender			CHAR(6),
	@street		VARCHAR(60),
	@city			VARCHAR(30),
	@stateAbbr		CHAR(2),
	@zip			INT,
	@phone1		VARCHAR(15),
	@phone2		VARCHAR(15) = NULL,
	@email		VARCHAR(100),
	@InsuranceCo	VARCHAR(40) = NULL,
	@InsuranceNum	INT = NULL
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





--Update Patient
CREATE PROC Update_Patient(
	@patientId		INT IDENTITY(1,1),
	@fName			VARCHAR(25) = NULL,
	@lName			VARCHAR(25) = NULL,
	@mInit			CHAR(1) = NULL,
	@street		VARCHAR(60) = NULL,
	@city			VARCHAR(30) = NULL,
	@stateAbbr		CHAR(2) = NULL,
	@zip			INT = NULL,
	@phone1		VARCHAR(15) = NULL,
	@phone2		VARCHAR(15) = NULL,
	@email		VARCHAR(100) = NULL,
	@email2		VARCHAR(100) = NULL,
	@InsuranceCo	VARCHAR(40) = NULL,
	@InsuranceNum	INT = NULL
)
AS
	BEGIN
	SET NOCOUNT ON;
		BEGIN TRANSACTION
			UPDATE Patient
				SET fName = ISNULL (@fName, fName),
					lName = ISNULL (@lName, lName),
					mInit = ISNULL (@mInit, mInit),
					street = ISNULL (@street, street),
					city = ISNULL (@city, city),
					stateAbbr = ISNULL (@stateAbbr, stateAbbr),
					zip = ISNULL (@zip, zip),
					phone1 = ISNULL (@phone1, phone1),
					phone2 = ISNULL (@phone2, phone2),
					email = ISNULL (@email, email),
					email2 = ISNULL (@email2, email2),
					InsuranceCo = ISNULL (@InsuranceCo, InsuranceCo),
					InsuranceNum = ISNULL (@InsuranceNum, InsuranceNum)
				FROM Patient
				WHERE patientId = @patientId

				IF @@ERROR <> 0
				BEGIN
					ROLLBACK TRANSACTION
					RAISERROR ('Unable to update record.',16,1)
					RETURN -1
				END
			ELSE
				BEGIN
					COMMIT TRANSACTION
					PRINT 'Record update successfully!'
				END
	END
GO






--Add Prescription
CREATE PROC Add_Prescription(
	@patientId		INT,
	@physicianId	INT,
	@MedName		VARCHAR(100),
	@intake		VARCHAR(15),
	@medDosage		VARCHAR(8),
	@freqNumber		INT,
	@freqInterval	INT IDENTITY(1,1),
	@maxRefills	INT
)
AS
	BEGIN
	SET NOCOUNT ON;
		BEGIN TRANSACTION
			INSERT INTO Perscription(patientId, physicianId, MedName, intake, medDosage, freqNumber, freqInterval, maxRefills)
			VALUES (@patientId, @physicianId, @MedName, @intake, @medDosage, @freqNumber, @freqInterval, @maxRefills)

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





--Update Prescription
CREATE PROC Update_Refill(
	@refillId		INT,
	@refillDate		DATETIME
)
AS
	BEGIN
	SET NOCOUNT ON;
		BEGIN TRANSACTION
			UPDATE Fill
				SET refillDate = @refillDate
				FROM REFILL
				WHERE refillId = @refillId

				IF @@ERROR <> 0
				BEGIN
					ROLLBACK TRANSACTION
					RAISERROR ('Unable to update record.',16,1)
					RETURN -1
				END
			ELSE
				BEGIN
					COMMIT TRANSACTION
					PRINT 'Record update successfully!'
				END
	END
GO



--DROP TABLE #TEMPREFILL

--Add Refill
--drop proc add_refill 
CREATE PROC Add_Refill(
	@perscriptionId		INT
)
AS
	BEGIN
	SET NOCOUNT ON;
		BEGIN TRANSACTION

			DECLARE @refillsUsed INTEGER;
			DECLARE @MAXID INTEGER;
			DECLARE @MAXREFILLS INTEGER;

			SELECT * INTO #TEMPREFILL 
			FROM Fill
			where perscriptionId = @perscriptionId

			SELECT @MAXID = MAX(refillId) FROM #TEMPREFILL
			SELECT @refillsUsed = refillsUsed FROM #TEMPREFILL WHERE refillId = @MAXID
			SELECT @refillsUsed = ISNULL(@refillsUsed + 1, 1)
			SELECT @MAXREFILLS = maxRefills FROM Perscription WHERE perscriptionId = @perscriptionId
			
			
			IF @refillsUsed <= @MAXREFILLS
			BEGIN
				INSERT INTO Fill(perscriptionId, refillsUsed)
				VALUES (@perscriptionId, @refillsUsed)
			END
			ELSE
			BEGIN
				RAISERROR ('Unable to insert record.',16,1)
			END


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



--Delete Refill
CREATE PROC Delete_Refill(
	@refillId INT
)
AS
	BEGIN
	SET NOCOUNT ON;
		BEGIN TRANSACTION
			DELETE FROM Fill
			WHERE refillId = @refillId

			IF @@ERROR <> 0
				BEGIN
					ROLLBACK TRANSACTION
					RAISERROR ('Unable to delete record.',16,1)
					RETURN -1
				END
			ELSE
				BEGIN
					COMMIT TRANSACTION
					PRINT 'Record deleted successfully!'
				END
	END
GO


--Combo Patient1
CREATE PROC ComboPatient1
AS
	BEGIN
		SELECT patientId, lName + ', ' + fName + ' ' + mInit AS FullName
		FROM Patient
	END
GO



--Combo Patient2
CREATE PROC ComboPatient2(
	@lName VARCHAR(25)
)
AS
	BEGIN
		SELECT patientId, lName + ', ' + fName + ' ' + mInit AS FullName
		FROM Patient
		WHERE lName LIKE '%' + @lName + '%'
	END
GO



--Combo Physician
CREATE PROC ComboPhysician
AS
	BEGIN
		SELECT physicianId, lName + ', ' + fName + ' ' + mInit AS FullName
		FROM Physician
	END
GO



--Combo Prescription
CREATE PROC ComboPrescription(
	@patientId INT
)
AS
	BEGIN
		SELECT perscriptionId, medDosage + ' of ' + MedName AS Presname
		FROM Perscription
		WHERE patientId = @patientId
	END
GO



--Patient Info
CREATE PROC PatientInfo(
	@patientId INT
)
AS
	BEGIN
		SELECT *
		FROM Patient 
		WHERE patientId = @patientId
	END
GO




--Prescription Info
CREATE PROC PrescriptionInfo(
	@perscriptionId INT
)
AS
	BEGIN
		SELECT *
		FROM Perscription
		WHERE perscriptionId = @perscriptionId
	END
GO



--Physician Info
CREATE PROC PhysicianInfo(
	@physicianId INT
)
AS
	BEGIN
		SELECT *
		FROM Physician
		WHERE physicianId = @physicianId
	END
GO


exec physicianInfo 'DOC01'
--Refill History
CREATE PROC RefillHistory(
	@perscriptionId INT
)
AS
	BEGIN
		SELECT *
		FROM Fill
		WHERE perscriptionId = @perscriptionId
	END
GO