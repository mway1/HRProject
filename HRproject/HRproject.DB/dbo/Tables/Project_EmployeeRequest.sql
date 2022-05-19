CREATE TABLE [dbo].[Project_EmployeeRequest] (
    [Id]        INT        NOT NULL,
    [ProjectId] BINARY (1) NOT NULL,
    [OrderId]   INT        NOT NULL,
    CONSTRAINT [PK_PROJECT_EMPLOYEEREQUEST] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [Project_EmployeeRequest_fk1] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[EmployeeRequest] ([Id]) ON UPDATE CASCADE
);

