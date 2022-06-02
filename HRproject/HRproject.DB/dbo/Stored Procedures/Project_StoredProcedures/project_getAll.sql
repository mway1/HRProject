CREATE PROCEDURE [dbo].[project_getAll]
	AS
SELECT * FROM Project
WHERE
isDeleted=0
RETURN 0
