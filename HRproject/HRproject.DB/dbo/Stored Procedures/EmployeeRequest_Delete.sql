CREATE PROCEDURE dbo.EmployeeRequest_Delete
@Id int,
@ProjectId,
@Quantity,
@IsDeleted
AS
BEGIN
UPDATE dbo.Employee
SET ProjectId=@ProjectId,
Quantity=@Quantity,
IsDeleted=@IsDeleted
WHERE Id = @Id
END