CREATE TABLE [dbo].[Employee] (
    [id]           INT          NOT NULL,
    [First_Name]   VARCHAR (50) NOT NULL,
    [Last_Name]    VARCHAR (50) NOT NULL,
    [PositionId]   INT          NOT NULL,
    [email]        VARCHAR (50) NULL,
    [phone_number] DECIMAL (18) NOT NULL,
    [StatusId]     INT          NOT NULL,
    [DepartmentId] INT          NOT NULL,
    [LevelId]      INT          NOT NULL,
    [SkilllId]     INT          NOT NULL,
    CONSTRAINT [PK_EMPLOYEE] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Employee_fk0] FOREIGN KEY ([PositionId]) REFERENCES [dbo].[Position] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [Employee_fk1] FOREIGN KEY ([StatusId]) REFERENCES [dbo].[Status] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [Employee_fk2] FOREIGN KEY ([DepartmentId]) REFERENCES [dbo].[Department] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [Employee_fk3] FOREIGN KEY ([LevelId]) REFERENCES [dbo].[Level] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [Employee_fk4] FOREIGN KEY ([SkilllId]) REFERENCES [dbo].[Skill] ([id]) ON UPDATE CASCADE
);

