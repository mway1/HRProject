CREATE PROCEDURE [dbo].[EmployeeRequestPosition_Create]
	@EmployeeRequestId int,
	@PositionId int,
	@LevelOfPositionId int
AS
BEGIN
INSERT INTO dbo.EmployeeRequest_Position(
        EmployeeRequestId,
		PositionId,
		LevelOfPositionId)
VALUES(
		@EmployeeRequestId,
		@PositionId,
		@LevelOfPositionId)
END
