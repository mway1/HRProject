CREATE TABLE [dbo].[EmployeeRequest_Position]
(
	[Id] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
	[EmployeeRequestId] INT NOT NULL,
	[PositionId] INT NOT NULL,
	[LevelOfPositionId] INT NULL,
	FOREIGN KEY ([EmployeeRequestId]) REFERENCES [dbo].[EmployeeRequest] ([id]),
	FOREIGN KEY ([PositionId]) REFERENCES [dbo].[Position] ([id]),
	FOREIGN KEY ([LevelOfPositionId]) REFERENCES [dbo].[LevelOfPosition] ([id])
 )
