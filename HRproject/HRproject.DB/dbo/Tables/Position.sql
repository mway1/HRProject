CREATE TABLE [dbo].[Position] (
    [id]                INT          IDENTITY (1, 1) NOT NULL,
    [Name]              VARCHAR (50) NOT NULL,
    [LevelOfPositionId] INT          NOT NULL,
    [isDeleted]         BIT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([LevelOfPositionId]) REFERENCES [dbo].[LevelOfPosition] ([id])
);

