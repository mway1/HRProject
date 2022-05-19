CREATE TABLE [dbo].[EmployeeHistory] (
    [id]         INT        NOT NULL,
    [EmployeeId] INT        NOT NULL,
    [Date]       ROWVERSION NOT NULL,
    [StatusId]   INT        NOT NULL,
    CONSTRAINT [PK_EMPLOYEEHISTORY] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [EmployeeHistory_fk0] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employee] ([id]) ON UPDATE CASCADE
);

