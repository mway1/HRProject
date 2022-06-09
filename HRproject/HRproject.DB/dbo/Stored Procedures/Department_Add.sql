CREATE PROCEDURE [dbo].[Department_Add]
	@Name varchar(50),
	@Description text,
	@isDeleted bit
AS
BEGIN
INSERT INTO dbo.Department(
	[Name],
	[Description],
	isDeleted
)
VALUES(
	@Name,
	@Description,
	@isDeleted
)
END

