IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191208081116_Initial')
BEGIN
    CREATE TABLE [Users] (
        [UserID] int NOT NULL IDENTITY,
        [Email] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [Password] nvarchar(max) NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([UserID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191208081116_Initial')
BEGIN
    CREATE TABLE [Characters] (
        [CharacterID] int NOT NULL IDENTITY,
        [IsMonster] bit NOT NULL,
        [IsPlayer] bit NOT NULL,
        [IsNPC] bit NOT NULL,
        [Name] nvarchar(max) NULL,
        [Gender] nvarchar(max) NULL,
        [Species] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [UserID] int NULL,
        CONSTRAINT [PK_Characters] PRIMARY KEY ([CharacterID]),
        CONSTRAINT [FK_Characters_Users_UserID] FOREIGN KEY ([UserID]) REFERENCES [Users] ([UserID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191208081116_Initial')
BEGIN
    CREATE TABLE [Abilities] (
        [AbilityID] int NOT NULL IDENTITY,
        [Ability1] nvarchar(max) NULL,
        [Ability2] nvarchar(max) NULL,
        [Ability3] nvarchar(max) NULL,
        [Ability4] nvarchar(max) NULL,
        [Ability5] nvarchar(max) NULL,
        [CharacterID] int NULL,
        CONSTRAINT [PK_Abilities] PRIMARY KEY ([AbilityID]),
        CONSTRAINT [FK_Abilities_Characters_CharacterID] FOREIGN KEY ([CharacterID]) REFERENCES [Characters] ([CharacterID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191208081116_Initial')
BEGIN
    CREATE INDEX [IX_Abilities_CharacterID] ON [Abilities] ([CharacterID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191208081116_Initial')
BEGIN
    CREATE INDEX [IX_Characters_UserID] ON [Characters] ([UserID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191208081116_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191208081116_Initial', N'2.2.6-servicing-10079');
END;

GO

