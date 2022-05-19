CREATE TABLE [dbo].[Comment] (
    [id]          INT      NOT NULL,
    [EmployeeId]  INT      NOT NULL,
    [Description] TEXT     NOT NULL,
    [Date]        DATETIME NOT NULL,
    CONSTRAINT [PK_COMMENT] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Comment_fk0] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employee] ([id]) ON UPDATE CASCADE
);

