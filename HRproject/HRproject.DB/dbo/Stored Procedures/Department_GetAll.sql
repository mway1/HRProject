CREATE PROCEDURE [dbo].[Department_GetAll]
AS
SELECT * FROM Department
WHERE isDeleted=0
END