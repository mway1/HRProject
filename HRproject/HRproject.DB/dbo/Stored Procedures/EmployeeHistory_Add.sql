CREATE PROCEDURE [dbo].[EmployeeHistory_Add]

	@EmployeeId int,
	@Date timestamp,
	@StatusId int,
	@isDeleted bit

AS
BEGIN
INSERT INTO dbo.EmployeeHistory(
EmployeeId,
[Date],
StatusId,
isDeleted
)
VALUES(
@EmployeeId,
@Date,
@StatusId,
@isDeleted
)
	
	END
	

