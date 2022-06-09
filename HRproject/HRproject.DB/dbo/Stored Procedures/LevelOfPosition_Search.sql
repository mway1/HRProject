CREATE PROCEDURE [dbo].[LevelOfPosition_Search]
	@Name text,
	@Limit integer
AS
BEGIN
	SELECT TOP (@Limit)
		Name
	FROM
		LevelOfPosition
	WHERE
		LOWER(Name) LIKE '%' + LOWER(CONVERT(VARCHAR, @Name)) + '%'
END
GO