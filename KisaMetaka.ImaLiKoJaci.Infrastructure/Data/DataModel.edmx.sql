
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/11/2014 22:36:42
-- Generated from EDMX file: C:\Dev\ima-li-ko-jaci\KisaMetaka.ImaLiKoJaci.Infrastructure\Data\DataModel.edmx
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


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
    [YoutubeUrl] nvarchar(max)  NOT NULL
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