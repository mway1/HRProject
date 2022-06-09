CREATE PROCEDURE [dbo].[Employee_Position_Add]
	@id int,
	@EmployeeId int,
	@PositionId int,
	@LevelOfPositionId int
AS
BEGIN
INSERT INTO dbo.Employee_Position(
        EmployeeId,
		PositionId,
		LevelOfPositionId)
VALUES(
		@EmployeeId,
		@PositionId,
		@LevelOfPositionId)
SET @id=SCOPE_IDENTITY()

SELECT
		EmployeeId=@EmployeeId,
		PositionId=@PositionId,
		LevelOfPositionId=@LevelOfPositionId
FROM dbo.Employee_Position
END
