CREATE PROCEDURE [dbo].[Department_Add]
	@id int,
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

SELECT
	[Name]=@Name,
	[Description]=@Description,
	isDeleted=@isDeleted
FROM dbo.Department
WHERE id=@id
END

