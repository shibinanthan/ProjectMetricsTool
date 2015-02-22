ALTER TABLE TASK ALTER COLUMN Priority VARCHAR(15) NOT NULL;
ALTER TABLE TASK ALTER COLUMN TaskStatus VARCHAR(15) NOT NULL;

DELETE FROM dbo.Task
DELETE FROM dbo.Employee
DELETE FROM dbo.Requirement
DELETE FROM dbo.Project
DELETE FROM dbo.Team
DELETE FROM dbo.Release
DELETE FROM dbo.Process
DELETE FROM dbo.Activity
DELETE FROM dbo.Phase

--======================
-- BEGIN: Data Insertion
--====================== 
DECLARE @ReleaseID UNIQUEIDENTIFIER
SET @ReleaseID = NEWID();
INSERT INTO dbo.Release(ReleaseId,[Description])
VALUES(@ReleaseID, 'TestRelease')

DECLARE @PhaseID UNIQUEIDENTIFIER
SET @PhaseID = NEWID();
INSERT INTO dbo.Phase(PhaseID, [Description])
VALUES(@PhaseID, 'TestPhase')

DECLARE @ActivityID UNIQUEIDENTIFIER
SET @ActivityID = NEWID();
INSERT INTO dbo.Activity(ActivityID, PhaseID, [Description])
VALUES(@ActivityID, @PhaseID, 'TestActivity')

DECLARE @ProcessID UNIQUEIDENTIFIER
SET @ProcessID = NEWID();
INSERT INTO dbo.Process(ProcessID, ActivityID, [Description])
VALUES(@ProcessID, @ActivityID, 'TestProcess')

DECLARE @TeamID UNIQUEIDENTIFIER
SET @TeamID = NEWID();
INSERT INTO dbo.Team(TeamID, Name)
VALUES(@TeamID, 'TestTeam')

DECLARE @EmpId INT;
INSERT INTO dbo.Employee(TeamID,Name)
VALUES(@TeamID, 'TestEmp')
SET @EmpId = SCOPE_IDENTITY()

DECLARE @PrjId UNIQUEIDENTIFIER
DECLARE @ProjectId UNIQUEIDENTIFIER
SET @PrjId = NEWID();
SET @ProjectId = NEWID();
INSERT INTO dbo.Project(PrjID, ProjectID, ReleaseId, TeamId, [Description])
VALUES(@PrjId, @ProjectId, @ReleaseID, @TeamID, 'TestProject')

DECLARE @ReqId UNIQUEIDENTIFIER
SET @ReqId = NEWID();
INSERT INTO dbo.Requirement(ReqID, PrjID, [Description])
VALUES(@ReqId, @PrjId, 'TestRquirement')

DECLARE @TaskId UNIQUEIDENTIFIER
SET @TaskId = NEWID();
INSERT INTO dbo.Task(TaskID, [Description], PrjID, ReqID, ProcessID, EmpID, PlannedStartDate, 
					 PlannedEndDate, ActualStartDate, ActualEndDate, CreatedDate, UpdatedDate, 
					 TotalDuration, TotalEffort, TaskType, Priority, TaskStatus, Allocation, 
					 Comments, AnyChangeInReq, Risk, IsActive)
VALUES(@TaskId, 'TestTask', @PrjId, @ReqId, @ProcessID, @EmpId, GETDATE(), DATEADD(d, 3, GETDATE()),
       GETDATE(), DATEADD(d, 3, GETDATE()), GETDATE(), GETDATE(), 32, 32, 'Design', 'Medium', 'Closed', '', '', 1, '', 1)
       
INSERT INTO [dbo].[UserType] ([Description]) VALUES ('Admin')
INSERT INTO [dbo].[UserType] ([Description]) VALUES ('Project Manager')
INSERT INTO [dbo].[UserType] ([Description]) VALUES ('Team Member')

INSERT INTO [dbo].[User] ([Name], [Password], [UserTypeId]) VALUES ('Shibi' ,'test', 1)

GO

--====================
-- END: Data Insertion
--====================

SELECT * FROM dbo.Employee
SELECT *  FROM dbo.Requirement
SELECT *  FROM dbo.Project
SELECT *  FROM dbo.Team
SELECT *  FROM dbo.Release
SELECT *  FROM dbo.Process
SELECT *  FROM dbo.Activity
SELECT *  FROM dbo.Phase
SELECT * FROM dbo.Task

