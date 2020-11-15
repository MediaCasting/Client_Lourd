/*USE [MegaCasting]
GO
SET IDENTITY_INSERT [dbo].[City] ON 
GO
INSERT [dbo].[City] ([Identifier], [Name], [ZipCode]) VALUES (1, N'Paris                                             ', 75000)
GO
INSERT [dbo].[City] ([Identifier], [Name], [ZipCode]) VALUES (2, N'Laval                                             ', 53000)
GO
INSERT [dbo].[City] ([Identifier], [Name], [ZipCode]) VALUES (3, N'Rennes                                            ', 35000)
GO
SET IDENTITY_INSERT [dbo].[City] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 
GO
INSERT [dbo].[User] ([Identifier], [FirstName], [LastName], [Password], [Salt], [IsAdmin], [IdentifierCity]) VALUES (1, N'Laddé', N'Koba', N'LeBat7', NULL, 1, 1)
GO
INSERT [dbo].[User] ([Identifier], [FirstName], [LastName], [Password], [Salt], [IsAdmin], [IdentifierCity]) VALUES (2, N'Galace', N'Damien', N'Banane', NULL, 0, 2)
GO
INSERT [dbo].[User] ([Identifier], [FirstName], [LastName], [Password], [Salt], [IsAdmin], [IdentifierCity]) VALUES (3, N'Stocrate', N'Larry', N'Faismoilabise', NULL, 1, 3)
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[ContractType] ON 
GO
INSERT [dbo].[ContractType] ([Identifier], [Name]) VALUES (2, N'CDI                                               ')
GO
INSERT [dbo].[ContractType] ([Identifier], [Name]) VALUES (3, N'CDD                                               ')
GO
INSERT [dbo].[ContractType] ([Identifier], [Name]) VALUES (4, N'Interim                                           ')
GO
SET IDENTITY_INSERT [dbo].[ContractType] OFF
GO
SET IDENTITY_INSERT [dbo].[DomainJob] ON 
GO
INSERT [dbo].[DomainJob] ([Identifier], [Name]) VALUES (1, N'Musique                                           ')
GO
INSERT [dbo].[DomainJob] ([Identifier], [Name]) VALUES (2, N'Danse                                             ')
GO
INSERT [dbo].[DomainJob] ([Identifier], [Name]) VALUES (3, N'Cinema                                            ')
GO
SET IDENTITY_INSERT [dbo].[DomainJob] OFF
GO
SET IDENTITY_INSERT [dbo].[Job] ON 
GO
INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierDomainJob]) VALUES (1, N'Trompetiste                                       ', 1)
GO
INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierDomainJob]) VALUES (2, N'Guitariste                                        ', 1)
GO
INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierDomainJob]) VALUES (3, N'Pianiste                                          ', 1)
GO
INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierDomainJob]) VALUES (4, N'Jazz                                              ', 2)
GO
INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierDomainJob]) VALUES (5, N'Pop                                               ', 2)
GO
INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierDomainJob]) VALUES (6, N'Salsa                                             ', 2)
GO
INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierDomainJob]) VALUES (7, N'Perchiste                                         ', 3)
GO
INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierDomainJob]) VALUES (8, N'Acteur                                            ', 3)
GO
INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierDomainJob]) VALUES (9, N'Cadreur                                           ', 3)
GO
SET IDENTITY_INSERT [dbo].[Job] OFF
GO
SET IDENTITY_INSERT [dbo].[Pack] ON 
GO
INSERT [dbo].[Pack] ([Identifier], [Name], [Prix], [OfferNumber]) VALUES (1, N'Premium                                           ', 500, 100)
GO
INSERT [dbo].[Pack] ([Identifier], [Name], [Prix], [OfferNumber]) VALUES (2, N'Avancé                                            ', 200, 30)
GO
INSERT [dbo].[Pack] ([Identifier], [Name], [Prix], [OfferNumber]) VALUES (3, N'Débutant                                          ', 75, 10)
GO
SET IDENTITY_INSERT [dbo].[Pack] OFF
GO
SET IDENTITY_INSERT [dbo].[Producer] ON 
GO
INSERT [dbo].[Producer] ([Identifier], [CompanyName], [FirstName], [LastName], [Password], [Salt], [IdentifierPack]) VALUES (1, N'Design10', N'Vignac', N'Louis', N'plusde10', NULL, 1)
GO
INSERT [dbo].[Producer] ([Identifier], [CompanyName], [FirstName], [LastName], [Password], [Salt], [IdentifierPack]) VALUES (2, N'Deter et de Feu', N'Doe', N'John', N'Password', NULL, 2)
GO
INSERT [dbo].[Producer] ([Identifier], [CompanyName], [FirstName], [LastName], [Password], [Salt], [IdentifierPack]) VALUES (3, N'Auto Cine Cascade', N'Rosso', N'Patrick', N'Jentenbieng', NULL, 3)
GO
SET IDENTITY_INSERT [dbo].[Producer] OFF
GO
SET IDENTITY_INSERT [dbo].[Offer] ON 
GO
INSERT [dbo].[Offer] ([Identifier], [Name], [Reference], [PublishDateTime], [Duration], [StartContractDate], [PostCount], [JobDescription], [ProfilDescription], [Street], [IdentifierCity], [IdentifierProducer], [IdentifierJob], [IdentifierContractType]) VALUES (1, N'Guitariste', N'AAAA1A', CAST(N'2020-10-16T00:00:00.0000000' AS DateTime2), 10, CAST(N'2020-11-24' AS Date), 3, N'Guitariste pour une chorale', N'Talentueux et tenace', N'26 rue du Roi lion', 1, 2, 1, 4)
GO
INSERT [dbo].[Offer] ([Identifier], [Name], [Reference], [PublishDateTime], [Duration], [StartContractDate], [PostCount], [JobDescription], [ProfilDescription], [Street], [IdentifierCity], [IdentifierProducer], [IdentifierJob], [IdentifierContractType]) VALUES (2, N'Pop', N'BBBB2B', CAST(N'2020-10-20T00:00:00.0000000' AS DateTime2), 20, CAST(N'2021-02-04' AS Date), 2, N'Danseur Pop pour clip', N'Danseurs motivé, agile', N'27 rue du Peter Pan', 3, 3, 5, 2)
GO
INSERT [dbo].[Offer] ([Identifier], [Name], [Reference], [PublishDateTime], [Duration], [StartContractDate], [PostCount], [JobDescription], [ProfilDescription], [Street], [IdentifierCity], [IdentifierProducer], [IdentifierJob], [IdentifierContractType]) VALUES (3, N'Cascadeur', N'CCCC2C', CAST(N'2020-12-16T00:00:00.0000000' AS DateTime2), 10, CAST(N'2020-12-24' AS Date), 5, N'Cascade crash voiture', N'Muclé,Courageux et précis', N'2 rue du Trois', 2, 1, 8, 3)
GO
SET IDENTITY_INSERT [dbo].[Offer] OFF
GO
SET IDENTITY_INSERT [dbo].[BroadcastPartner] ON 
GO
INSERT [dbo].[BroadcastPartner] ([Identifier], [LastName], [FirstName], [Phone], [Email], [Street], [IdentifierCity]) VALUES (1, N'Dupond                                            ', N'Pierre                                            ', 604056408, N'p.dupond@gmail.com                                ', N'1 rue de droite                                                       ', 1)
GO
INSERT [dbo].[BroadcastPartner] ([Identifier], [LastName], [FirstName], [Phone], [Email], [Street], [IdentifierCity]) VALUES (2, N'Poupion                                           ', N'Mickael                                           ', 60854698, N'm.poupion@gmail.com                               ', N'1 rue de gauche                                                       ', 2)
GO
INSERT [dbo].[BroadcastPartner] ([Identifier], [LastName], [FirstName], [Phone], [Email], [Street], [IdentifierCity]) VALUES (3, N'Deshaies                                          ', N'Antoine                                           ', 89485316, N'a.deshaies@gmail.com                              ', N'1 rue de derrière                                                     ', 3)
GO
SET IDENTITY_INSERT [dbo].[BroadcastPartner] OFF
GO
SET IDENTITY_INSERT [dbo].[UserOffer] ON 
GO
INSERT [dbo].[UserOffer] ([Identifier], [IdentifierUser], [IdentifierOffer]) VALUES (1, 2, 1)
GO
INSERT [dbo].[UserOffer] ([Identifier], [IdentifierUser], [IdentifierOffer]) VALUES (2, 1, 2)
GO
INSERT [dbo].[UserOffer] ([Identifier], [IdentifierUser], [IdentifierOffer]) VALUES (3, 3, 3)
GO
SET IDENTITY_INSERT [dbo].[UserOffer] OFF
GO
*/