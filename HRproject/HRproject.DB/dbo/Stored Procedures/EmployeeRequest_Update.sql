CREATE PROCEDURE dbo.EmployeeRequest_Update
@Id int,
@ProjectId int,
@Quantity int
AS
BEGIN
UPDATE dbo.EmployeeRequest
SET ProjectId=@ProjectId,
Quantity=@Quantity
WHERE Id = @Id
END