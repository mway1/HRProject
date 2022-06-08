CREATE PROCEDURE [dbo].[Department_GetAll]
AS
BEGIN
SELECT * FROM Department
WHERE isDeleted=0
END