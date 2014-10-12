
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/12/2014 20:34:59
-- Generated from EDMX file: D:\Projects\ima-li-ko-jaci\KisaMetaka.ImaLiKoJaci.Infrastructure\Data\DataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [KisaMetaka.ImaLiKoJaci];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AS_Song_Lyrics]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Lyrics] DROP CONSTRAINT [FK_AS_Song_Lyrics];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Songs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Songs];
GO
IF OBJECT_ID(N'[dbo].[Lyrics]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Lyrics];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DisplayName] nvarchar(max)  NOT NULL,
    [FacebookId] nvarchar(max)  NOT NULL,
    [JoinedOn] datetime  NOT NULL,
    [TotalScore] int  NOT NULL
);
GO

-- Creating table 'Songs'
CREATE TABLE [dbo].[Songs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [FileName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Lyrics'
CREATE TABLE [dbo].[Lyrics] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Question] nvarchar(max)  NOT NULL,
    [Answer] nvarchar(max)  NOT NULL,
    [FromSecond] int  NOT NULL,
    [ToSecond] int  NOT NULL,
    [ScoreValue] int  NOT NULL,
    [SongId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Songs'
ALTER TABLE [dbo].[Songs]
ADD CONSTRAINT [PK_Songs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Lyrics'
ALTER TABLE [dbo].[Lyrics]
ADD CONSTRAINT [PK_Lyrics]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SongId] in table 'Lyrics'
ALTER TABLE [dbo].[Lyrics]
ADD CONSTRAINT [FK_AS_Song_Lyrics]
    FOREIGN KEY ([SongId])
    REFERENCES [dbo].[Songs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AS_Song_Lyrics'
CREATE INDEX [IX_FK_AS_Song_Lyrics]
ON [dbo].[Lyrics]
    ([SongId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------