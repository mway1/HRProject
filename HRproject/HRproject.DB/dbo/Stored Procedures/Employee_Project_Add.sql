CREATE PROCEDURE [dbo].[Employee_Project_Add]
		@id int,
		@EmployeeId int,
		@ProjectId int
AS
BEGIN
INSERT INTO dbo.Employee_Project(
        EmployeeId,
		ProjectId)
VALUES(
		@EmployeeId,
		@ProjectId)
SET @id=SCOPE_IDENTITY()

SELECT
		EmployeeId=@EmployeeId,
		ProjectId=@ProjectId
FROM dbo.Employee_Project
WHERE id=@id
END