
CREATE PROCEDURE [dbo].[Project_Add] @id          INT, 
                                     @name        VARCHAR(64), 
                                     @description VARCHAR (128), 
                                    @isDeleted   TINYINT 
AS 
  BEGIN 
      INSERT INTO project 
                  (id, 
                   NAME, 
                   description, 
                   isdeleted) 
      VALUES      (@id, 
                   @name, 
                   @description, 
                   @isDeleted); 
  END; 