CREATE PROCEDURE [dbo].[project_getAllFull]
AS
SELECT * FROM Project
WHERE
isDeleted=0 and IsFull=1;
RETURN 0
