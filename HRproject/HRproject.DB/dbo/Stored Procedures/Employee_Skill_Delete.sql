CREATE PROCEDURE [dbo].[Employee_Skill_Delete]
		@id int
AS
BEGIN

DELETE FROM dbo.Employee_Skill
WHERE 
Id=@Id

END

