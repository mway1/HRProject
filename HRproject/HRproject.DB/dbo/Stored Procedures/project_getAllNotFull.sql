CREATE PROCEDURE [dbo].[project_getAllNotFull]
AS
SELECT
	P.[id], P.[Description], P.[Name], P.isDeleted
FROM
	Project as P
JOIN 
	(
		SELECT
			DISTINCT ProjectID
		FROM
			dbo.EmployeeRequest
		WHERE
			isDeleted = 0
	) AS ER
	ON
		(P.id = ER.ProjectID)
WHERE
	P.isDeleted = 0;
RETURN 0
