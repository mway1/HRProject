CREATE PROCEDURE dbo.EmployeeRequest_DeleteById
@Id int,
@ProjectId int,
@Quantity int
AS
BEGIN
UPDATE dbo.EmployeeRequest
SET ProjectId=@ProjectId,
Quantity=@Quantity,
IsDeleted= 1
WHERE Id = @Id
END