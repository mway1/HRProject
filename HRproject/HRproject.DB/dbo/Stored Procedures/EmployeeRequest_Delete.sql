CREATE PROCEDURE dbo.EmployeeRequest_Delete
@Id int,
@ProjectId int,
@Quantity int,
@IsDeleted bit
AS
BEGIN
UPDATE dbo.EmployeeRequest
SET ProjectId=@ProjectId,
Quantity=@Quantity,
IsDeleted=@IsDeleted
WHERE Id = @Id
END