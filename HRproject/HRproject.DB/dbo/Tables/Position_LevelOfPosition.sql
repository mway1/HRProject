CREATE TABLE [dbo].[Position_LevelOfPosition]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[PositionId] INT NOT NULL,
	[LevelOfPositionId] INT NOT NULL,
	FOREIGN KEY ([LevelOfPositionId]) REFERENCES [dbo].[LevelOfPosition] ([id]),
	FOREIGN KEY ([PositionId]) REFERENCES [dbo].[Position] ([id])
)
