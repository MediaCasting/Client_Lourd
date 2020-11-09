CREATE TABLE [dbo].[City] (
    [Identifier] BIGINT     IDENTITY (1, 1) NOT NULL,
    [Name]       NCHAR (50) NULL,
    [ZipCode]    INT        NULL,
    CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED ([Identifier] ASC)
);

