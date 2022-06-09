CREATE PROCEDURE [dbo].[Employee_Position_GetById]
@Id int
AS
BEGIN

	SELECT id,EmployeeId,PositionId,LevelOfPositionID
	FROM dbo.Employee_Position
	WHERE Id=@Id

END