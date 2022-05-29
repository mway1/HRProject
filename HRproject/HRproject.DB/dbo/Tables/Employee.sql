CREATE TABLE [dbo].[Employee] (
    [id]           INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]    VARCHAR (50) NOT NULL,
    [SecondName]     VARCHAR (50) NOT NULL,
    [LastName]     VARCHAR (50) ,
    [BirthDate]    DATE         NOT NULL,
    [Email]        VARCHAR (50) NOT NULL,
    [PhoneNumber]  DECIMAL (18) NOT NULL,
    [StatusId]     INT          NOT NULL,
    [DepartmentId] INT          NOT NULL,
    [isDeleted]    BIT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([DepartmentId]) REFERENCES [dbo].[Department] ([id]),
    FOREIGN KEY ([StatusId]) REFERENCES [dbo].[Status] ([id])
);

