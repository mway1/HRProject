CREATE TABLE [dbo].[EmployeeRequest_Position]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[EmployeeRequestId] INT NOT NULL,
	[PositionId] INT NOT NULL,
	[LevelOfPositionId] INT NOT NULL,
	FOREIGN KEY ([EmployeeRequestId]) REFERENCES [dbo].[EmployeeRequest] ([id]),
	FOREIGN KEY ([PositionId]) REFERENCES [dbo].[Position] ([id]),
	FOREIGN KEY ([LevelOfPositionId]) REFERENCES [dbo].[LevelOfPosition] ([id])
 )
