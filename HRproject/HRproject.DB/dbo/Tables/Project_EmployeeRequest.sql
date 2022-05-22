CREATE TABLE [dbo].[Project_EmployeeRequest] (
    [id]                INT IDENTITY (1, 1) NOT NULL,
    [EmployeeRequestId] INT NOT NULL,
    [ProjectId]         INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([EmployeeRequestId]) REFERENCES [dbo].[EmployeeRequest] ([id]),
    FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Project] ([id])
);

