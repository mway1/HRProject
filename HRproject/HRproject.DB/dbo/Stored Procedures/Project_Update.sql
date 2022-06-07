CREATE PROCEDURE[dbo].[Project_update] @id          INT, 
                                @name        VARCHAR(64), 
                                @description VARCHAR(128)
AS 
  BEGIN 
      UPDATE project 
      SET    name = @name, 
             description = @description
      WHERE  id = @id; 
  END; 
 