
CREATE PROCEDURE [dbo].[Status_getAll] 
	AS
SELECT * FROM status
WHERE
isDeleted=0
RETURN 0
