CREATE PROCEDURE [dbo].[EmployeeHistory_Update]
@id int,
	@EmployeeId int,
	@Date timestamp,
	@StatusId int,
	@isDeleted bit	
AS
BEGIN 
UPDATE dbo.EmployeeHistory
SET EmployeeId=@EmployeeId,
	[Date]=@Date,
	StatusId=@StatusId,
	isDeleted=@isDeleted
	WHERE Id = @Id
END
