IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [JobInfo] (
    [JobDate] datetime NOT NULL,
    [ActiveJobs] int NOT NULL,
    [JobViews] int NOT NULL,
    [PredictedJobViews] int NOT NULL,
    CONSTRAINT [PK_JobInfo] PRIMARY KEY ([JobDate])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'JobDate', N'ActiveJobs', N'JobViews', N'PredictedJobViews') AND [object_id] = OBJECT_ID(N'[JobInfo]'))
    SET IDENTITY_INSERT [JobInfo] ON;
INSERT INTO [JobInfo] ([JobDate], [ActiveJobs], [JobViews], [PredictedJobViews])
VALUES ('2022-05-29T00:00:00.000', 150, 90, 60),
('2022-05-30T00:00:00.000', 145, 87, 58),
('2022-05-31T00:00:00.000', 140, 84, 56),
('2022-06-01T00:00:00.000', 135, 81, 54),
('2022-06-02T00:00:00.000', 130, 78, 52),
('2022-06-03T00:00:00.000', 125, 75, 50),
('2022-06-04T00:00:00.000', 120, 72, 48),
('2022-06-05T00:00:00.000', 115, 69, 46),
('2022-06-06T00:00:00.000', 110, 66, 44),
('2022-06-07T00:00:00.000', 105, 63, 42),
('2022-06-08T00:00:00.000', 100, 60, 40),
('2022-06-09T00:00:00.000', 95, 57, 38),
('2022-06-10T00:00:00.000', 90, 54, 36),
('2022-06-11T00:00:00.000', 85, 51, 34),
('2022-06-12T00:00:00.000', 80, 48, 32),
('2022-06-13T00:00:00.000', 75, 45, 30),
('2022-06-14T00:00:00.000', 70, 42, 28),
('2022-06-15T00:00:00.000', 65, 39, 26),
('2022-06-16T00:00:00.000', 60, 36, 24),
('2022-06-17T00:00:00.000', 55, 33, 22),
('2022-06-18T00:00:00.000', 50, 30, 20),
('2022-06-19T00:00:00.000', 45, 27, 18),
('2022-06-20T00:00:00.000', 40, 24, 16),
('2022-06-21T00:00:00.000', 35, 21, 14),
('2022-06-22T00:00:00.000', 30, 18, 12),
('2022-06-23T00:00:00.000', 25, 15, 10),
('2022-06-24T00:00:00.000', 20, 12, 8),
('2022-06-25T00:00:00.000', 15, 9, 6),
('2022-06-26T00:00:00.000', 10, 6, 4),
('2022-06-27T00:00:00.000', 5, 3, 2);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'JobDate', N'ActiveJobs', N'JobViews', N'PredictedJobViews') AND [object_id] = OBJECT_ID(N'[JobInfo]'))
    SET IDENTITY_INSERT [JobInfo] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220628151848_InitialMigrationWithData', N'6.0.6');
GO

COMMIT;
GO

