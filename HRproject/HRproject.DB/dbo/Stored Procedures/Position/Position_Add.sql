CREATE PROCEDURE [dbo].[Position_Add]
	@PositionName		nvarchar (255)	
AS
BEGIN
	INSERT INTO dbo.Position ([Name])
	VALUES (@PositionName)
END
