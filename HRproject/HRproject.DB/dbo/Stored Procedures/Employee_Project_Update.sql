CREATE PROCEDURE [dbo].[Employee_Project_Update]
		@id int,
		@EmployeeId int,
		@ProjectId int
AS
BEGIN

UPDATE dbo.Employee_Project
SET	   EmployeeId=@EmployeeId,
       ProjectId=@ProjectId
WHERE Id = @Id

END

