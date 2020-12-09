CREATE TABLE [dbo].[Messagerie] (
    [Identifier]         BIGINT         IDENTITY (1, 1) NOT NULL,
    [Texte]              NVARCHAR (500) NULL,
    [Date]               DATE           NULL,
    [QuiEcrit]           BIT            NULL,
    [IdentifierArtist]   BIGINT         NOT NULL,
    [IdentifierProducer] BIGINT         NOT NULL,
    CONSTRAINT [PK_Messagerie] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_Messagerie_Artist] FOREIGN KEY ([IdentifierArtist]) REFERENCES [dbo].[Artist] ([Identifier]),
    CONSTRAINT [FK_Messagerie_Producer] FOREIGN KEY ([IdentifierProducer]) REFERENCES [dbo].[Producer] ([Identifier])
);





