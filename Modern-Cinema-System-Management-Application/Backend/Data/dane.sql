USE [Cinema]
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([Id], [Title], [Description], [Duaration], [Director], [ReleaseDate], [WithdrawalDate], [ImageFileName], [IsArchived]) VALUES (1, N'Tytul', N'Opis', 130, N'Rezyser', N'2023-12-01', N'2023-12-27', N'4170e6ab0f6d30dca42c2df7cf52fb999351cb63d11203175d4ddb638955e9c2.jpg', 0)
INSERT [dbo].[Movies] ([Id], [Title], [Description], [Duaration], [Director], [ReleaseDate], [WithdrawalDate], [ImageFileName], [IsArchived]) VALUES (2, N'Tytul1', N'Opis1', 150, N'Rezyser1', N'2023-12-01', N'2023-12-30', N'hobbit.jpg', 0)
INSERT [dbo].[Movies] ([Id], [Title], [Description], [Duaration], [Director], [ReleaseDate], [WithdrawalDate], [ImageFileName], [IsArchived]) VALUES (3, N'Tytul2', N'Opis2', 150, N'Rezyser2', N'2023-12-05', N'2023-12-22', N'7627292.3.jpg', 0)
INSERT [dbo].[Movies] ([Id], [Title], [Description], [Duaration], [Director], [ReleaseDate], [WithdrawalDate], [ImageFileName], [IsArchived]) VALUES (4, N'Tytul3', N'Opis3', 120, N'Rezyser3', N'2023-12-02', N'2024-01-22', N'image_2be71e6c.jpeg', 0)
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
SET IDENTITY_INSERT [dbo].[Screenings] ON 

INSERT [dbo].[Screenings] ([Id], [StartTime], [MovieId], [RoomId]) VALUES (1, N'13:00', 1, 1)
INSERT [dbo].[Screenings] ([Id], [StartTime], [MovieId], [RoomId]) VALUES (2, N'15:30', 2, 2)
INSERT [dbo].[Screenings] ([Id], [StartTime], [MovieId], [RoomId]) VALUES (3, N'13:30', 3, 3)
INSERT [dbo].[Screenings] ([Id], [StartTime], [MovieId], [RoomId]) VALUES (4, N'16:30', 4, 1)
SET IDENTITY_INSERT [dbo].[Screenings] OFF
GO
