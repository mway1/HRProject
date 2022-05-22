CREATE TABLE [dbo].[Comment] (
    [id]          INT  IDENTITY (1, 1) NOT NULL,
    [Description] TEXT NOT NULL,
    [EmployeeId]  INT  NOT NULL,
    [isDeleted]   BIT  NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employee] ([id])
);

