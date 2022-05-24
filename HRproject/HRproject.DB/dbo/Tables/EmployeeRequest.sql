CREATE TABLE [dbo].[EmployeeRequest] (
    [id]         INT IDENTITY (1, 1) NOT NULL,
    [Quantity]   INT NOT NULL,
    [isDeleted]  BIT NULL,
    [ProjectID]  INT ,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[Project] ([id])
);

