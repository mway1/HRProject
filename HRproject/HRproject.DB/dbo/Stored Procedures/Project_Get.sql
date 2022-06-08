CREATE PROCEDURE [dbo].[Project_get] @id INT 
AS 
  BEGIN 
      SELECT * 
      FROM   project 
      WHERE  id = @id; 
  END; 