CREATE PROCEDURE[dbo].[Project_update] @id          INT, 
                                @name        VARCHAR(64), 
                                @description VARCHAR(128), 
                                @isDeleted   TINYINT 
AS 
  BEGIN 
      UPDATE project 
      SET    NAME = @name, 
             description = @description, 
             isDeleted = @isDeleted 
      WHERE  id = @id; 
  END; 
 