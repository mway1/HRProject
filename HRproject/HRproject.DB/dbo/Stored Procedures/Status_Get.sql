 CREATE PROCEDURE [dbo].[Status_get] @id INT 
AS 
  BEGIN 
      SELECT * 
      FROM   status 
      WHERE  id = @id; 
  END; 