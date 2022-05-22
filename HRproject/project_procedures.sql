CREATE PROCEDURE Project_create @id          INT,
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

CREATE PROCEDURE Project_update @id          INT,
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

CREATE PROCEDURE Project_get @id INT
AS
  BEGIN
      SELECT *
      FROM   project
      WHERE  id = @id;
  END;

--EXEC project_create @id = 1, @name = 'First', @description = 'hey dude', @isDeleted = 0;
--EXEC project_update @id = 1, @name ='second', @description = 'bye dude', @isDeleted = 0;
--EXEC project_get @id = 1;