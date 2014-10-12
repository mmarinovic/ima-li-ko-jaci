USE [KisaMetaka.ImaLiKoJaci]
GO
SET IDENTITY_INSERT [dbo].[Songs] ON 

GO
INSERT [dbo].[Songs] ([Id], [Title], [FileName]) VALUES (1, N'Mirela Holy', N'mirela-holy.mp3')
GO
INSERT [dbo].[Songs] ([Id], [Title], [FileName]) VALUES (2, N'Pljačkam turiste', N'pljackam-turiste.mp3')
GO
INSERT [dbo].[Songs] ([Id], [Title], [FileName]) VALUES (3, N'Učka učka', N'ucka-ucka.mp3')
GO
SET IDENTITY_INSERT [dbo].[Songs] OFF
GO
SET IDENTITY_INSERT [dbo].[Lyrics] ON 

GO
INSERT [dbo].[Lyrics] ([Id], [Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (1, N'ima li ko jaci, ima li ko jaci', N'S ovakvim modelima ne isplati se kacit', 19, 24, 10, 1)
GO
INSERT [dbo].[Lyrics] ([Id], [Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (3, N'ganđa mi je sirova, nosin je u đepu', N'obavim poziv eto me za sekund ', 30, 34, 10, 1)
GO
INSERT [dbo].[Lyrics] ([Id], [Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (5, N'ćim uđem u tommya ukradem bocu đonija', N'kad te vidin pitan sta si donija ', 36, 39, 10, 1)
GO
INSERT [dbo].[Lyrics] ([Id], [Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (6, N'pročita sam ti tekst i pogodija koš ', N'jadranka kosor nosi moj broš ', 72, 75, 10, 1)
GO
INSERT [dbo].[Lyrics] ([Id], [Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (7, N'kad sidin na školjci čitan samo story', N'veča san kutija nego igor vori', 117, 121, 10, 1)
GO
INSERT [dbo].[Lyrics] ([Id], [Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (8, N'liti kad si u splitu kad ti triba trava', N'nađi me u biloj majici bez rukava', 19, 23, 10, 2)
GO
INSERT [dbo].[Lyrics] ([Id], [Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (9, N'stalno žrtve smjeran dok po rivi se gegan ', N'ako nešto tribaš brate nema čega nemam', 64, 68, 10, 2)
GO
INSERT [dbo].[Lyrics] ([Id], [Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (10, N's dvi kune te pošaljen po veliki topli', N'ako ne vratiš ostatak batine ćeš dobit', 114, 116, 20, 3)
GO
INSERT [dbo].[Lyrics] ([Id], [Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (11, N'non-stop kendan, kendan non-stop', N'pušin dop, držin misu ka pop ', 65, 67, 10, 3)
GO
INSERT [dbo].[Lyrics] ([Id], [Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (12, N'bičve armani, mudante prada ', N'u pandurskoj škodi kružin priko grada', 35, 38, 10, 3)
GO
SET IDENTITY_INSERT [dbo].[Lyrics] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

GO
INSERT [dbo].[Users] ([Id], [DisplayName], [FacebookId], [JoinedOn], [TotalScore]) VALUES (12, N'Nebojsa Veron', N'10204203015810020', CAST(0x0000A3C2001EB67B AS DateTime), 0)
GO
INSERT [dbo].[Users] ([Id], [DisplayName], [FacebookId], [JoinedOn], [TotalScore]) VALUES (13, N'KM BOT', N'bot', CAST(0x0000A3C200000000 AS DateTime), 0)
GO
INSERT [dbo].[Users] ([Id], [DisplayName], [FacebookId], [JoinedOn], [TotalScore]) VALUES (15, N'Marko Marinovic', N'10152572816673509', CAST(0x0000A3C200000000 AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
