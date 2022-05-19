CREATE TABLE [dbo].[Department] (
    [id]          INT           NOT NULL,
    [Name]        VARCHAR (50)  NOT NULL,
    [Description] VARCHAR (125) NULL,
    CONSTRAINT [PK_DEPARTMENT] PRIMARY KEY CLUSTERED ([id] ASC)
);

