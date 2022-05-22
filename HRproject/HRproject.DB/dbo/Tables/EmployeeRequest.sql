CREATE TABLE [dbo].[EmployeeRequest] (
    [id]         INT IDENTITY (1, 1) NOT NULL,
    [PositionId] INT NOT NULL,
    [SkillId]    INT NOT NULL,
    [Quantity]   INT NOT NULL,
    [isDeleted]  BIT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([PositionId]) REFERENCES [dbo].[Position] ([id]),
    FOREIGN KEY ([SkillId]) REFERENCES [dbo].[Skill] ([id])
);

