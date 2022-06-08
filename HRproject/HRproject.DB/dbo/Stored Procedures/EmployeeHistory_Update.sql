CREATE PROCEDURE [dbo].[EmployeeHistory_Update]
@id int,
	@EmployeeId int,
	@StatusId int,
	@isDeleted bit	
AS
BEGIN 
UPDATE dbo.EmployeeHistory
SET EmployeeId=@EmployeeId,
	StatusId=@StatusId,
	isDeleted=@isDeleted
	WHERE Id = @Id
END
