CREATE TABLE [dbo].[Skill] (
    [id]             INT          IDENTITY (1, 1) NOT NULL,
    [SkillName]           VARCHAR (50) NOT NULL,
    [LevelOfSkillId] INT          NOT NULL,
    [isDeleted]      BIT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([LevelOfSkillId]) REFERENCES [dbo].[LevelOfSkill] ([id])
);

