CREATE PROCEDURE [dbo].[Employee_Update]
    @id int,
    @FirstName varchar(50),
    @LastName varchar(50),
    @Email varchar(50),
    @PhoneNumber decimal,
    @StatusId int,
    @DepartmentId int,
    @IsDeleted bit
AS
BEGIN

UPDATE dbo.Employee
SET FirstName=@FirstName ,
    LastName=@LastName,
    Email=@Email ,
    PhoneNumber=@PhoneNumber ,
    StatusId=@StatusId ,
    DepartmentId=@DepartmentId,
    IsDeleted=@IsDeleted
WHERE Id = @Id

END
