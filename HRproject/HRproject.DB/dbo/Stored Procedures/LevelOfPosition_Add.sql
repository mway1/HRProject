CREATE PROCEDURE [dbo].[LevelOfPosition_Add]
		@id int,
		@Name varchar(50),
		@isDeleted bit
AS
BEGIN
INSERT INTO dbo.LevelOfPosition(
        Name,
		isDeleted)
VALUES(
		@Name,
		@isDeleted)
SET @id=SCOPE_IDENTITY()

SELECT
		Name=@Name,
		isDeleted=@isDeleted
FROM dbo.LevelOfPosition
WHERE id=@id
END
