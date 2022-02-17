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

CREATE TABLE [Companies] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [ShortDescription] nvarchar(max) NULL,
    [CompanyLogo] nvarchar(max) NULL,
    [CreatedBy] nvarchar(max) NULL,
    [Created] datetimeoffset NOT NULL,
    [ModifiedBy] nvarchar(max) NULL,
    [Modified] datetimeoffset NOT NULL,
    [StatusId] int NOT NULL,
    [InactivatedBy] nvarchar(max) NULL,
    [Inactivated] datetimeoffset NOT NULL,
    CONSTRAINT [PK_Companies] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ExperienceLeves] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_ExperienceLeves] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ProgrammingLanguages] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Image] nvarchar(max) NULL,
    CONSTRAINT [PK_ProgrammingLanguages] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Technologies] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_Technologies] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [JobOffers] (
    [Id] int NOT NULL IDENTITY,
    [PositionName] nvarchar(max) NULL,
    [SalaryMin] int NOT NULL,
    [SalaryMax] int NOT NULL,
    [City] nvarchar(max) NULL,
    [ExperienceLevelId] int NOT NULL,
    [CompanyId] int NOT NULL,
    [ProgrammingLanguageId] int NOT NULL,
    [CreatedBy] nvarchar(max) NULL,
    [Created] datetimeoffset NOT NULL,
    [ModifiedBy] nvarchar(max) NULL,
    [Modified] datetimeoffset NOT NULL,
    [StatusId] int NOT NULL,
    [InactivatedBy] nvarchar(max) NULL,
    [Inactivated] datetimeoffset NOT NULL,
    CONSTRAINT [PK_JobOffers] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_JobOffers_Companies_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [Companies] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_JobOffers_ExperienceLeves_ExperienceLevelId] FOREIGN KEY ([ExperienceLevelId]) REFERENCES [ExperienceLeves] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_JobOffers_ProgrammingLanguages_ProgrammingLanguageId] FOREIGN KEY ([ProgrammingLanguageId]) REFERENCES [ProgrammingLanguages] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [JobDescriptions] (
    [Id] int NOT NULL IDENTITY,
    [About] nvarchar(max) NULL,
    [Responsibilities] nvarchar(max) NULL,
    [Expectation] nvarchar(max) NULL,
    [Offer] nvarchar(max) NULL,
    [JobOfferId] int NOT NULL,
    [CreatedBy] nvarchar(max) NULL,
    [Created] datetimeoffset NOT NULL,
    [ModifiedBy] nvarchar(max) NULL,
    [Modified] datetimeoffset NOT NULL,
    [StatusId] int NOT NULL,
    [InactivatedBy] nvarchar(max) NULL,
    [Inactivated] datetimeoffset NOT NULL,
    CONSTRAINT [PK_JobDescriptions] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_JobDescriptions_JobOffers_JobOfferId] FOREIGN KEY ([JobOfferId]) REFERENCES [JobOffers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [JobOfferTechnologies] (
    [JobOfferId] int NOT NULL,
    [TechnologyId] int NOT NULL,
    CONSTRAINT [PK_JobOfferTechnologies] PRIMARY KEY ([JobOfferId], [TechnologyId]),
    CONSTRAINT [FK_JobOfferTechnologies_JobOffers_JobOfferId] FOREIGN KEY ([JobOfferId]) REFERENCES [JobOffers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_JobOfferTechnologies_Technologies_TechnologyId] FOREIGN KEY ([TechnologyId]) REFERENCES [Technologies] ([Id]) ON DELETE CASCADE
);
GO

CREATE UNIQUE INDEX [IX_JobDescriptions_JobOfferId] ON [JobDescriptions] ([JobOfferId]);
GO

CREATE INDEX [IX_JobOffers_CompanyId] ON [JobOffers] ([CompanyId]);
GO

CREATE INDEX [IX_JobOffers_ExperienceLevelId] ON [JobOffers] ([ExperienceLevelId]);
GO

CREATE INDEX [IX_JobOffers_ProgrammingLanguageId] ON [JobOffers] ([ProgrammingLanguageId]);
GO

CREATE INDEX [IX_JobOfferTechnologies_TechnologyId] ON [JobOfferTechnologies] ([TechnologyId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220130183626_Initial', N'5.0.13');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CompanyLogo', N'Created', N'CreatedBy', N'Inactivated', N'InactivatedBy', N'Modified', N'ModifiedBy', N'Name', N'ShortDescription', N'StatusId') AND [object_id] = OBJECT_ID(N'[Companies]'))
    SET IDENTITY_INSERT [Companies] ON;
INSERT INTO [Companies] ([Id], [CompanyLogo], [Created], [CreatedBy], [Inactivated], [InactivatedBy], [Modified], [ModifiedBy], [Name], [ShortDescription], [StatusId])
VALUES (5, N'SoftMatter', '2022-01-30T18:37:15.7264096+00:00', N'Admin', '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7264096+00:00', N'Admin', N'Soft Matter', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dignissim nulla tempor, varius neque at, bibendum mi. Suspendisse efficitur blandit pharetra. Quisque non commodo ante, ut volutpat arcu. Vestibulum mi magna, commodo nec dolor vitae, gravida sagittis nisi. Phasellus vulputate, dolor eget cursus dignissim, ligula augue porta ante, sit amet semper lacus enim ac tortor. Nullam congue auctor erat, volutpat pharetra tellus pretium dignissim.', 1),
(3, N'Creativity', '2022-01-30T18:37:15.7264096+00:00', N'Admin', '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7264096+00:00', N'Admin', N'Creativity', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dignissim nulla tempor, varius neque at, bibendum mi. Suspendisse efficitur blandit pharetra. Quisque non commodo ante, ut volutpat arcu. Vestibulum mi magna, commodo nec dolor vitae, gravida sagittis nisi. Phasellus vulputate, dolor eget cursus dignissim, ligula augue porta ante, sit amet semper lacus enim ac tortor. Nullam congue auctor erat, volutpat pharetra tellus pretium dignissim.', 1),
(2, N'SwissUnionBank', '2022-01-30T18:37:15.7264096+00:00', N'Admin', '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7264096+00:00', N'Admin', N'Swiss Union Bank', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dignissim nulla tempor, varius neque at, bibendum mi. Suspendisse efficitur blandit pharetra. Quisque non commodo ante, ut volutpat arcu. Vestibulum mi magna, commodo nec dolor vitae, gravida sagittis nisi. Phasellus vulputate, dolor eget cursus dignissim, ligula augue porta ante, sit amet semper lacus enim ac tortor. Nullam congue auctor erat, volutpat pharetra tellus pretium dignissim.', 1),
(1, N'SoftwareSolution', '2022-01-30T18:37:15.7264096+00:00', N'Admin', '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7264096+00:00', N'Admin', N'Software Solution', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dignissim nulla tempor, varius neque at, bibendum mi. Suspendisse efficitur blandit pharetra. Quisque non commodo ante, ut volutpat arcu. Vestibulum mi magna, commodo nec dolor vitae, gravida sagittis nisi. Phasellus vulputate, dolor eget cursus dignissim, ligula augue porta ante, sit amet semper lacus enim ac tortor. Nullam congue auctor erat, volutpat pharetra tellus pretium dignissim.', 1),
(4, N'ItOpportunity', '2022-01-30T18:37:15.7264096+00:00', N'Admin', '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7264096+00:00', N'Admin', N'It Opportunity', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dignissim nulla tempor, varius neque at, bibendum mi. Suspendisse efficitur blandit pharetra. Quisque non commodo ante, ut volutpat arcu. Vestibulum mi magna, commodo nec dolor vitae, gravida sagittis nisi. Phasellus vulputate, dolor eget cursus dignissim, ligula augue porta ante, sit amet semper lacus enim ac tortor. Nullam congue auctor erat, volutpat pharetra tellus pretium dignissim.', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CompanyLogo', N'Created', N'CreatedBy', N'Inactivated', N'InactivatedBy', N'Modified', N'ModifiedBy', N'Name', N'ShortDescription', N'StatusId') AND [object_id] = OBJECT_ID(N'[Companies]'))
    SET IDENTITY_INSERT [Companies] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[ExperienceLeves]'))
    SET IDENTITY_INSERT [ExperienceLeves] ON;
INSERT INTO [ExperienceLeves] ([Id], [Name])
VALUES (1, N'Junior'),
(2, N'Mid'),
(3, N'Senior'),
(4, N'Expert');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[ExperienceLeves]'))
    SET IDENTITY_INSERT [ExperienceLeves] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Image', N'Name') AND [object_id] = OBJECT_ID(N'[ProgrammingLanguages]'))
    SET IDENTITY_INSERT [ProgrammingLanguages] ON;
INSERT INTO [ProgrammingLanguages] ([Id], [Image], [Name])
VALUES (3, N'Python', N'Python'),
(4, N'JavaScript', N'JavaScript'),
(5, N'CPlusPlus', N'C++'),
(1, N'CSharp', N'C#'),
(2, N'Java', N'Java');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Image', N'Name') AND [object_id] = OBJECT_ID(N'[ProgrammingLanguages]'))
    SET IDENTITY_INSERT [ProgrammingLanguages] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Technologies]'))
    SET IDENTITY_INSERT [Technologies] ON;
INSERT INTO [Technologies] ([Id], [Name])
VALUES (19, N'C++ 17'),
(18, N'Django'),
(17, N'Flask'),
(16, N'AWS'),
(15, N'Moq'),
(14, N'XUnit'),
(13, N'Mockito'),
(11, N'Spring'),
(10, N'Hibernate'),
(9, N'Angular'),
(7, N'Docker'),
(6, N'Azure'),
(5, N'CSS'),
(4, N'HTML'),
(3, N'Entity Framwork'),
(2, N'SQL'),
(1, N'ASP.Net'),
(12, N'JUnit'),
(8, N'React');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Technologies]'))
    SET IDENTITY_INSERT [Technologies] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'City', N'CompanyId', N'Created', N'CreatedBy', N'ExperienceLevelId', N'Inactivated', N'InactivatedBy', N'Modified', N'ModifiedBy', N'PositionName', N'ProgrammingLanguageId', N'SalaryMax', N'SalaryMin', N'StatusId') AND [object_id] = OBJECT_ID(N'[JobOffers]'))
    SET IDENTITY_INSERT [JobOffers] ON;
INSERT INTO [JobOffers] ([Id], [City], [CompanyId], [Created], [CreatedBy], [ExperienceLevelId], [Inactivated], [InactivatedBy], [Modified], [ModifiedBy], [PositionName], [ProgrammingLanguageId], [SalaryMax], [SalaryMin], [StatusId])
VALUES (1, N'Wroclaw', 1, '2022-01-30T18:37:15.7277174+00:00', N'Admin', 1, '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7277174+00:00', N'Admin', N'Junior .Net Developer', 1, 8000, 6000, 1),
(2, N'Wroclaw', 2, '2022-01-30T18:37:15.7277174+00:00', N'Admin', 2, '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7277174+00:00', N'Admin', N'.Net Developer', 1, 15000, 10000, 1),
(4, N'Warsaw', 2, '2022-01-30T18:37:15.7277174+00:00', N'Admin', 2, '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7277174+00:00', N'Admin', N'Java Developer', 2, 15000, 10000, 1),
(5, N'Warsaw', 2, '2022-01-30T18:37:15.7277174+00:00', N'Admin', 3, '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7277174+00:00', N'Admin', N'Senior Java Developer', 2, 20000, 15000, 1),
(6, N'Warsaw', 2, '2022-01-30T18:37:15.7277174+00:00', N'Admin', 4, '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7277174+00:00', N'Admin', N'Java Tech Lead', 2, 30000, 20000, 1),
(3, N'Wroclaw', 3, '2022-01-30T18:37:15.7277174+00:00', N'Admin', 3, '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7277174+00:00', N'Admin', N'Senior .Net Developer', 1, 20000, 15000, 1),
(7, N'Remote', 3, '2022-01-30T18:37:15.7277174+00:00', N'Admin', 2, '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7277174+00:00', N'Admin', N'.Net Developer', 1, 15000, 10000, 1),
(8, N'Poznan', 3, '2022-01-30T18:37:15.7277174+00:00', N'Admin', 2, '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7277174+00:00', N'Admin', N'Python Developer', 3, 15000, 10000, 1),
(9, N'Remote', 4, '2022-01-30T18:37:15.7277174+00:00', N'Admin', 4, '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7277174+00:00', N'Admin', N'C++ Tech Lead', 5, 30000, 20000, 1),
(10, N'Poznan', 4, '2022-01-30T18:37:15.7277174+00:00', N'Admin', 1, '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7277174+00:00', N'Admin', N'Junior JavaScript Developer', 4, 8000, 6000, 1),
(11, N'Gdansk', 4, '2022-01-30T18:37:15.7277174+00:00', N'Admin', 3, '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7277174+00:00', N'Admin', N'Senior JavaScript Developer', 4, 20000, 15000, 1),
(12, N'Katowice', 4, '2022-01-30T18:37:15.7277174+00:00', N'Admin', 4, '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7277174+00:00', N'Admin', N'Java Tech Lead', 2, 30000, 20000, 1),
(13, N'Crakow', 5, '2022-01-30T18:37:15.7277174+00:00', N'Admin', 4, '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7277174+00:00', N'Admin', N'.Net Tech Lead', 1, 30000, 20000, 1),
(14, N'Remote', 5, '2022-01-30T18:37:15.7277174+00:00', N'Admin', 2, '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7277174+00:00', N'Admin', N'Python Developer', 3, 15000, 10000, 1),
(15, N'Crakow', 5, '2022-01-30T18:37:15.7277174+00:00', N'Admin', 2, '0001-01-01T00:00:00.0000000+00:00', NULL, '2022-01-30T18:37:15.7277174+00:00', N'Admin', N'JavaScript Developer', 4, 15000, 10000, 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'City', N'CompanyId', N'Created', N'CreatedBy', N'ExperienceLevelId', N'Inactivated', N'InactivatedBy', N'Modified', N'ModifiedBy', N'PositionName', N'ProgrammingLanguageId', N'SalaryMax', N'SalaryMin', N'StatusId') AND [object_id] = OBJECT_ID(N'[JobOffers]'))
    SET IDENTITY_INSERT [JobOffers] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'About', N'Created', N'CreatedBy', N'Expectation', N'Inactivated', N'InactivatedBy', N'JobOfferId', N'Modified', N'ModifiedBy', N'Offer', N'Responsibilities', N'StatusId') AND [object_id] = OBJECT_ID(N'[JobDescriptions]'))
    SET IDENTITY_INSERT [JobDescriptions] ON;
INSERT INTO [JobDescriptions] ([Id], [About], [Created], [CreatedBy], [Expectation], [Inactivated], [InactivatedBy], [JobOfferId], [Modified], [ModifiedBy], [Offer], [Responsibilities], [StatusId])
VALUES (1, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.', '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.', '0001-01-01T00:00:00.0000000+00:00', NULL, 1, '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.', 1),
(10, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.', '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.', '0001-01-01T00:00:00.0000000+00:00', NULL, 10, '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.', 1),
(8, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.', '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.', '0001-01-01T00:00:00.0000000+00:00', NULL, 8, '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.', 1),
(11, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.', '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.', '0001-01-01T00:00:00.0000000+00:00', NULL, 11, '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.', 1),
(7, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.', '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.', '0001-01-01T00:00:00.0000000+00:00', NULL, 7, '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.', 1),
(12, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.', '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.', '0001-01-01T00:00:00.0000000+00:00', NULL, 12, '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.', 1),
(3, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.', '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.', '0001-01-01T00:00:00.0000000+00:00', NULL, 3, '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.', 1),
(6, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.', '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.', '0001-01-01T00:00:00.0000000+00:00', NULL, 6, '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.', 1),
(13, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.', '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.', '0001-01-01T00:00:00.0000000+00:00', NULL, 13, '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.', 1),
(5, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.', '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.', '0001-01-01T00:00:00.0000000+00:00', NULL, 5, '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.', 1),
(14, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.', '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.', '0001-01-01T00:00:00.0000000+00:00', NULL, 14, '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.', 1),
(9, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.', '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.', '0001-01-01T00:00:00.0000000+00:00', NULL, 9, '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.', 1),
(4, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.', '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.', '0001-01-01T00:00:00.0000000+00:00', NULL, 4, '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.', 1),
(2, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.', '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.', '0001-01-01T00:00:00.0000000+00:00', NULL, 2, '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.', 1),
(15, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.', '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.', '0001-01-01T00:00:00.0000000+00:00', NULL, 15, '2022-01-30T18:37:15.7288958+00:00', N'Admin', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'About', N'Created', N'CreatedBy', N'Expectation', N'Inactivated', N'InactivatedBy', N'JobOfferId', N'Modified', N'ModifiedBy', N'Offer', N'Responsibilities', N'StatusId') AND [object_id] = OBJECT_ID(N'[JobDescriptions]'))
    SET IDENTITY_INSERT [JobDescriptions] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'JobOfferId', N'TechnologyId') AND [object_id] = OBJECT_ID(N'[JobOfferTechnologies]'))
    SET IDENTITY_INSERT [JobOfferTechnologies] ON;
INSERT INTO [JobOfferTechnologies] ([JobOfferId], [TechnologyId])
VALUES (11, 16),
(11, 7),
(11, 6),
(11, 13),
(11, 12),
(11, 11),
(11, 10),
(10, 9),
(10, 8),
(10, 5),
(15, 4),
(10, 4),
(15, 5),
(14, 16),
(13, 7),
(14, 7),
(12, 2),
(13, 6),
(13, 15),
(13, 14),
(14, 17),
(13, 3),
(13, 2),
(13, 1),
(14, 18),
(12, 16),
(14, 2);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'JobOfferId', N'TechnologyId') AND [object_id] = OBJECT_ID(N'[JobOfferTechnologies]'))
    SET IDENTITY_INSERT [JobOfferTechnologies] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'JobOfferId', N'TechnologyId') AND [object_id] = OBJECT_ID(N'[JobOfferTechnologies]'))
    SET IDENTITY_INSERT [JobOfferTechnologies] ON;
INSERT INTO [JobOfferTechnologies] ([JobOfferId], [TechnologyId])
VALUES (12, 7),
(9, 19),
(12, 15),
(12, 14),
(12, 3),
(12, 1),
(12, 6),
(8, 18),
(8, 7),
(5, 2),
(5, 13),
(5, 12),
(5, 11),
(5, 10),
(4, 2),
(4, 13),
(4, 12),
(6, 10),
(4, 11),
(2, 15),
(2, 14),
(2, 3),
(2, 2),
(2, 1),
(1, 3),
(1, 2),
(1, 1),
(4, 10),
(8, 16),
(6, 11),
(6, 13),
(8, 2),
(15, 8),
(8, 17),
(7, 7),
(7, 6),
(7, 15),
(7, 14),
(7, 3),
(6, 12),
(7, 2),
(3, 15);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'JobOfferId', N'TechnologyId') AND [object_id] = OBJECT_ID(N'[JobOfferTechnologies]'))
    SET IDENTITY_INSERT [JobOfferTechnologies] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'JobOfferId', N'TechnologyId') AND [object_id] = OBJECT_ID(N'[JobOfferTechnologies]'))
    SET IDENTITY_INSERT [JobOfferTechnologies] ON;
INSERT INTO [JobOfferTechnologies] ([JobOfferId], [TechnologyId])
VALUES (3, 14),
(3, 3),
(3, 2),
(3, 1),
(6, 7),
(6, 6),
(6, 2),
(7, 1),
(15, 9);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'JobOfferId', N'TechnologyId') AND [object_id] = OBJECT_ID(N'[JobOfferTechnologies]'))
    SET IDENTITY_INSERT [JobOfferTechnologies] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220130183716_Seed', N'5.0.13');
GO

COMMIT;
GO

