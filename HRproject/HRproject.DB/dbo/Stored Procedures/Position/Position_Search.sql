﻿CREATE PROCEDURE [dbo].[Position_Search]
	@Name text,
	@Limit integer
AS
BEGIN
	SELECT TOP (@Limit)
		Name
	FROM
		Project
	WHERE
		LOWER(Name) LIKE '%' + LOWER(CONVERT(VARCHAR, @Name)) + '%'
END;
GO



