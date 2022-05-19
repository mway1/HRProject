CREATE TABLE [dbo].[Employee_Project] (
    [id]         INT NOT NULL,
    [EmployeeId] INT NOT NULL,
    [ProjectId]  INT NOT NULL,
    CONSTRAINT [PK_EMPLOYEE_PROJECT] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Employee_Project_fk0] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employee] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [Employee_Project_fk1] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Project] ([id]) ON UPDATE CASCADE
);

