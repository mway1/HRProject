CREATE TABLE [dbo].[LevelOfPosition] (
    [id]        INT          IDENTITY (1, 1) NOT NULL,
    [LevelOfPositionName]      VARCHAR (50) NOT NULL,
    [isDeleted] BIT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

