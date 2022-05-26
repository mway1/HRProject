CREATE PROCEDURE [dbo].[Department_GetAll]
	
AS
BEGIN
SELECT id, [Name], [Description], isDeleted
FROM dbo.Department
END
