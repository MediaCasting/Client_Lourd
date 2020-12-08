CREATE TABLE [dbo].[Image] (
    [Identifier] BIGINT        IDENTITY (1, 1) NOT NULL,
    [Format]     CHAR (4)      NOT NULL,
    [Libelle]    NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED ([Identifier] ASC)
);

