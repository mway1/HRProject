CREATE TABLE [dbo].[EmployeeHistory] (
    [id]         INT        IDENTITY (1, 1) NOT NULL,
    [EmployeeId] INT        NOT NULL,
    [Date]       DATE       NOT NULL,
    [StatusId]   INT        NOT NULL,
    [isDeleted]  BIT        NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employee] ([id]),
    FOREIGN KEY ([StatusId]) REFERENCES [dbo].[Status] ([id])
);