CREATE TABLE [dbo].[Skill] (
    [id]         INT          NOT NULL,
    [SkillName]  VARCHAR (50) NOT NULL,
    [SkillLevel] INT          NOT NULL,
    CONSTRAINT [PK_SKILL] PRIMARY KEY CLUSTERED ([id] ASC)
);

