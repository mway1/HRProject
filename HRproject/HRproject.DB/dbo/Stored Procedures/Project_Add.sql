
CREATE PROCEDURE [dbo].[Project_Add] @id          INT, 
                                     @name        VARCHAR(64), 
                                     @description VARCHAR (128)                                   
AS 
  BEGIN 
      INSERT INTO project 
                  (id, 
                   NAME, 
                   description
                   ) 
      VALUES      (@id, 
                   @name, 
                   @description
                   ); 
  END; 