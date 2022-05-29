CREATE PROCEDURE dbo.EmployeeRequest_UpdateById
@Id int,
@ProjectId int,
@Quantity int,
@isDeleted bit
AS
BEGIN
UPDATE dbo.EmployeeRequest
SET ProjectId=@ProjectId,
Quantity=@Quantity,
isDeleted=@isDeleted
WHERE Id = @Id
END