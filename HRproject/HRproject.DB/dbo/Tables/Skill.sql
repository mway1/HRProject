CREATE TABLE [dbo].[Skill] (
    [id]             INT          IDENTITY (1, 1) NOT NULL,
    [Name]           VARCHAR (50) NOT NULL,
    [isDeleted]      BIT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
);

