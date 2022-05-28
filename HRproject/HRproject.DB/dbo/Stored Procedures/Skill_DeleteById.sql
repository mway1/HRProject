CREATE PROCEDURE [dbo].[Skill_DeleteById]
	  @Id int
AS
	delete [dbo].[Skill]
	
	Where Id = @Id
