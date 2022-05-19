CREATE TABLE [dbo].[Project] (
    [id]          INT           NOT NULL,
    [name]        VARCHAR (50)  NOT NULL,
    [Description] VARCHAR (125) NULL,
    CONSTRAINT [PK_PROJECT] PRIMARY KEY CLUSTERED ([id] ASC)
);

