CREATE PROCEDURE [dbo].[Employee_Position_GetById]
@EmployeeId int
AS
BEGIN

	SELECT EPos.id,EPos.EmployeeId,P.[Name],EPos.LevelOfPositionID
	FROM dbo.Employee_Position as EPos
	LEFT JOIN dbo.Position as P on(EPos.PositionId=P.id)
	WHERE EmployeeId=@EmployeeId

END