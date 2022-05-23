CREATE PROCEDURE [dbo].[Department_Add]
	@id int,
	@Name varchar(50),
	@Description text,
	@IsDeleted bit
AS
BEGIN
INSERT INTO dbo.Department(
	[Name],
	[Description],
	IsDeleted
)
VALUES(
	@Name,
	@Description,
	@IsDeleted
)

SELECT
	[Name]=@Name,
	[Description]=@Description,
	IsDeleted=@IsDeleted
FROM dbo.Department
WHERE id=@id
END

