
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/16/2022 15:00:20
-- Generated from EDMX file: F:\bd\ver5\BD_cyrs\BD_cyrs\BD_curs.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DB_HUMAN_RESOURCES_DEP];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_DepartmentsEmployees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeesSet] DROP CONSTRAINT [FK_DepartmentsEmployees];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeesSeniority]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SenioritySet] DROP CONSTRAINT [FK_EmployeesSeniority];
GO
IF OBJECT_ID(N'[dbo].[FK_CompanyDepartments]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DepartmentsSet] DROP CONSTRAINT [FK_CompanyDepartments];
GO
IF OBJECT_ID(N'[dbo].[FK_PositionSeniority]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SenioritySet] DROP CONSTRAINT [FK_PositionSeniority];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EmployeesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeesSet];
GO
IF OBJECT_ID(N'[dbo].[SenioritySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SenioritySet];
GO
IF OBJECT_ID(N'[dbo].[CompanySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompanySet];
GO
IF OBJECT_ID(N'[dbo].[DepartmentsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DepartmentsSet];
GO
IF OBJECT_ID(N'[dbo].[PositionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PositionSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EmployeesSet'
CREATE TABLE [dbo].[EmployeesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FIO] nvarchar(100)  NOT NULL,
    [Date_of_birth] datetime  NOT NULL,
    [SNILS] nchar(14)  NOT NULL,
    [DepartmentsId] int  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SenioritySet'
CREATE TABLE [dbo].[SenioritySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date_of_hiring] datetime  NOT NULL,
    [Date_of_dismissal] datetime  NULL,
    [Wage_rate] float  NOT NULL,
    [EmployeesId] int  NOT NULL,
    [PositionId] int  NOT NULL
);
GO

-- Creating table 'CompanySet'
CREATE TABLE [dbo].[CompanySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name_Company] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'DepartmentsSet'
CREATE TABLE [dbo].[DepartmentsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name_Departments] nvarchar(100)  NOT NULL,
    [CompanyId] int  NOT NULL
);
GO

-- Creating table 'PositionSet'
CREATE TABLE [dbo].[PositionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name_Position] nvarchar(100)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EmployeesSet'
ALTER TABLE [dbo].[EmployeesSet]
ADD CONSTRAINT [PK_EmployeesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SenioritySet'
ALTER TABLE [dbo].[SenioritySet]
ADD CONSTRAINT [PK_SenioritySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CompanySet'
ALTER TABLE [dbo].[CompanySet]
ADD CONSTRAINT [PK_CompanySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DepartmentsSet'
ALTER TABLE [dbo].[DepartmentsSet]
ADD CONSTRAINT [PK_DepartmentsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PositionSet'
ALTER TABLE [dbo].[PositionSet]
ADD CONSTRAINT [PK_PositionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DepartmentsId] in table 'EmployeesSet'
ALTER TABLE [dbo].[EmployeesSet]
ADD CONSTRAINT [FK_DepartmentsEmployees]
    FOREIGN KEY ([DepartmentsId])
    REFERENCES [dbo].[DepartmentsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentsEmployees'
CREATE INDEX [IX_FK_DepartmentsEmployees]
ON [dbo].[EmployeesSet]
    ([DepartmentsId]);
GO

-- Creating foreign key on [EmployeesId] in table 'SenioritySet'
ALTER TABLE [dbo].[SenioritySet]
ADD CONSTRAINT [FK_EmployeesSeniority]
    FOREIGN KEY ([EmployeesId])
    REFERENCES [dbo].[EmployeesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeesSeniority'
CREATE INDEX [IX_FK_EmployeesSeniority]
ON [dbo].[SenioritySet]
    ([EmployeesId]);
GO

-- Creating foreign key on [CompanyId] in table 'DepartmentsSet'
ALTER TABLE [dbo].[DepartmentsSet]
ADD CONSTRAINT [FK_CompanyDepartments]
    FOREIGN KEY ([CompanyId])
    REFERENCES [dbo].[CompanySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyDepartments'
CREATE INDEX [IX_FK_CompanyDepartments]
ON [dbo].[DepartmentsSet]
    ([CompanyId]);
GO

-- Creating foreign key on [PositionId] in table 'SenioritySet'
ALTER TABLE [dbo].[SenioritySet]
ADD CONSTRAINT [FK_PositionSeniority]
    FOREIGN KEY ([PositionId])
    REFERENCES [dbo].[PositionSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PositionSeniority'
CREATE INDEX [IX_FK_PositionSeniority]
ON [dbo].[SenioritySet]
    ([PositionId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------