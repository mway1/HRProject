CREATE PROCEDURE [dbo].[Employee_Position_Add]
	@id int,
	@EmployeeId int,
	@PositionId int,
	@LevelOfPositionID int
AS
BEGIN
INSERT INTO dbo.Employee_Position(
        EmployeeId,
		PositionId,
		LevelOfPositionID)
VALUES(
		@EmployeeId,
		@PositionId,
		@LevelOfPositionID)
SET @id=SCOPE_IDENTITY()

SELECT
		EmployeeId=@EmployeeId,
		PositionId=@PositionId,
		LevelOfPositionID=@LevelOfPositionID
FROM dbo.Employee_Position
END
