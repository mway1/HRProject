CREATE PROCEDURE [dbo].[Employee_Position_GetByLevelId]
@LevelOfPositionID int
AS
BEGIN

	SELECT EPos.id,EPos.EmployeeId,PositionId,LP.Name as [LevelOfPositionName]
	FROM dbo.Employee_Position as EPos
	LEFT JOIN dbo.LevelOfPosition as LP on(EPos.LevelOfPositionID=LP.id)
	WHERE LevelOfPositionID=@LevelOfPositionID

END
