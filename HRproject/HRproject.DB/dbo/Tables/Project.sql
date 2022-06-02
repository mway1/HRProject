CREATE TABLE [dbo].[Project] (
    [id]          INT          IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50) NOT NULL,
    [Description] TEXT         NOT NULL,
    [isDeleted]   BIT          NOT NULL,
    [IsFull] BIT NOT NULL, 
    PRIMARY KEY CLUSTERED ([id] ASC)
);

