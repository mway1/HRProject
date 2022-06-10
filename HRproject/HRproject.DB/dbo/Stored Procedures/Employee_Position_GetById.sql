CREATE PROCEDURE [dbo].[Employee_Position_GetById]
@EmployeeId int
AS
BEGIN

	SELECT EPos.id,EPos.EmployeeId,P.[Name],LP.[Name] as LevelOfPositionName
	FROM dbo.Employee_Position as EPos
	LEFT JOIN dbo.Position as P on(EPos.PositionId=P.id)
	LEFT JOIN dbo.LevelOfPosition as LP on(EPos.LevelOfPositionID=LP.id)
	WHERE EmployeeId=@EmployeeId

END