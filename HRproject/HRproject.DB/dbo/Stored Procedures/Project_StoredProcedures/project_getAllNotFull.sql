CREATE PROCEDURE [dbo].[project_getAllNotFull]
	AS
SELECT * FROM Project
WHERE
isDeleted=0 and IsFull=0;
RETURN 0
