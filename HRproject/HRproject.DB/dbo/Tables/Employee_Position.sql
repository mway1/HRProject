CREATE TABLE [dbo].[Employee_Position] (
    [id]         INT IDENTITY (1, 1) NOT NULL,
    [EmployeeId] INT NOT NULL,
    [PositionId] INT NOT NULL,
    [LevelOfPositionID] INT,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employee] ([id]),
    FOREIGN KEY ([LevelOfPositionID]) REFERENCES [dbo].[LevelOfPosition] ([id]),
    FOREIGN KEY ([PositionId]) REFERENCES [dbo].[Position] ([id])
);

