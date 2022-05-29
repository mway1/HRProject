CREATE PROCEDURE [dbo].[Position_DeleteById]
	  @Id int
AS
   BEGIN
    UPDATE dbo.Position
    SET
    [IsDeleted] = 1
    WHERE [Id] = @Id
END
