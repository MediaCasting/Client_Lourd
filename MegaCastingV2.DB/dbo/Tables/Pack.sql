CREATE TABLE [dbo].[Pack] (
    [Identifier]  BIGINT     IDENTITY (1, 1) NOT NULL,
    [Name]        NCHAR (50) NULL,
    [Prix]        INT        NULL,
    [OfferNumber] INT        NULL,
    CONSTRAINT [PK_Pack] PRIMARY KEY CLUSTERED ([Identifier] ASC)
);



