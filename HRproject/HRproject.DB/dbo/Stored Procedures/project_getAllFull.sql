CREATE PROCEDURE [dbo].[project_getAllFull]
AS
SELECT
	P.[id], P.[Description], P.[Name], P.isDeleted
FROM
	[dbo].[Project] AS P
LEFT JOIN (
	SELECT
		*
	FROM
		[dbo].[EmployeeRequest]
	WHERE
		isDeleted = 0
) AS ER
ON
	(P.id = [ER].[ProjectID])
WHERE
	P.isDeleted=0 AND ER.ProjectID IS NULL;
RETURN 0
