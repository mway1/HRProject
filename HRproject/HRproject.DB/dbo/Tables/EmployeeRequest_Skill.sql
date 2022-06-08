CREATE TABLE [dbo].[EmployeeRequest_Skill]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[EmployeeRequestId] INT NOT NULL,
	[SkillId] INT NOT NULL,
	[LevelOfSkill] INT NULL,
	FOREIGN KEY ([EmployeeRequestId]) REFERENCES [dbo].[EmployeeRequest] ([id]),
	FOREIGN KEY ([SkillId]) REFERENCES [dbo].[Skill] ([id])
)
