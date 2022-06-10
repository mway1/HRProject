CREATE PROCEDURE [dbo].[EmployeeRequest_Create]
	@ProjectId int,
	@Quantity int,
	@IsDeleted int = 0
AS
BEGIN
INSERT INTO dbo.EmployeeRequest(
        ProjectId,
		Quantity,
		isDeleted)
VALUES(
		@ProjectId,
		@Quantity,
		@isDeleted)
SELECT SCOPE_IDENTITY() 
END
