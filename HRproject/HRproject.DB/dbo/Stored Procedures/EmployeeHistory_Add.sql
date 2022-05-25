CREATE PROCEDURE [dbo].[EmployeeHistory_Add]
	@id int,
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
	SELECT 
	EmployeeId=@EmployeeId,
	[Date]=@Date,
	StatusId=@StatusId,
	isDeleted=@isDeleted

	FROM dbo.EmployeeHistory
	WHERE id=@id
	END
	

