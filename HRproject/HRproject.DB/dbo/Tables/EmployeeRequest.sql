CREATE TABLE [dbo].[EmployeeRequest] (
    [Id]               INT NOT NULL,
    [Position_LevelId] INT NOT NULL,
    [SkillsId]         INT NOT NULL,
    CONSTRAINT [PK_EMPLOYEEREQUEST] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [EmployeeRequest_fk0] FOREIGN KEY ([Position_LevelId]) REFERENCES [dbo].[Specialist] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [EmployeeRequest_fk1] FOREIGN KEY ([SkillsId]) REFERENCES [dbo].[Skill] ([id]) ON UPDATE CASCADE
);

