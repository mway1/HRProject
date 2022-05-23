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

)
	SELECT @param1, @param2
RETURN 0
