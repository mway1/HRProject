CREATE PROCEDURE [dbo].[project_getAllNotFull]
AS
SELECT P.[id], P.[Description], P.[Name], P.isDeleted
FROM Project as P
left join dbo.EmployeeRequest as ER on (P.id = ER.ProjectID)
WHERE
P.isDeleted=0 and Er.ProjectID is not null;
RETURN 0
