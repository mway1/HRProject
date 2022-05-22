CREATE TABLE [dbo].[Employee_Skill] (
    [id]         INT IDENTITY (1, 1) NOT NULL,
    [EmployeeId] INT NOT NULL,
    [SkillId]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employee] ([id]),
    FOREIGN KEY ([SkillId]) REFERENCES [dbo].[Skill] ([id])
);

