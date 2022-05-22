CREATE TABLE [dbo].[Employee_Project] (
    [id]         INT IDENTITY (1, 1) NOT NULL,
    [EmployeeId] INT NOT NULL,
    [ProjectId]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employee] ([id]),
    FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Project] ([id])
);

