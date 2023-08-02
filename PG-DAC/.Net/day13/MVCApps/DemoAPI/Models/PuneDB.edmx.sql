
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/11/2023 21:55:12
-- Generated from EDMX file: C:\PGDACS\Sunbeam\.Net\day13\MVCApps\DemoAPI\Models\PuneDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [punedb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Emps]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Emps];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Emps'
CREATE TABLE [dbo].[Emps] (
    [No] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [Address] varchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [No] in table 'Emps'
ALTER TABLE [dbo].[Emps]
ADD CONSTRAINT [PK_Emps]
    PRIMARY KEY CLUSTERED ([No] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------