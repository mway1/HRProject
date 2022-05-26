CREATE PROCEDURE[dbo].[Project_update] @id          INT, 
                                @name        VARCHAR(64), 
                                @description VARCHAR(128), 
                                @isDeleted   TINYINT 
AS 
  BEGIN 
      UPDATE project 
      SET    name = @name, 
             description = @description, 
             isDeleted = @isDeleted 
      WHERE  id = @id; 
  END; 
 