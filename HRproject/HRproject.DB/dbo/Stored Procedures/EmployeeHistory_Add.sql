CREATE PROCEDURE [dbo].[EmployeeHistory_Add]

	@EmployeeId int,
	@StatusId int,
	@isDeleted bit

AS
BEGIN
INSERT INTO dbo.EmployeeHistory(
EmployeeId,
StatusId,
isDeleted
)
VALUES(
@EmployeeId,
@StatusId,
@isDeleted
)
	
	END
	

