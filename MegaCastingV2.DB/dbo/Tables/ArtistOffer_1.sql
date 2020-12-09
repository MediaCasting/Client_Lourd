CREATE TABLE [dbo].[ArtistOffer] (
    [Identifier]       BIGINT IDENTITY (1, 1) NOT NULL,
    [IdentifierArtist] BIGINT NOT NULL,
    [IdentifierOffer]  BIGINT NOT NULL,
    CONSTRAINT [PK_ArtistOffer] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_ArtistOffer_Artist] FOREIGN KEY ([IdentifierArtist]) REFERENCES [dbo].[Artist] ([Identifier]),
    CONSTRAINT [FK_ArtistOffer_Offer] FOREIGN KEY ([IdentifierOffer]) REFERENCES [dbo].[Offer] ([Identifier])
);

