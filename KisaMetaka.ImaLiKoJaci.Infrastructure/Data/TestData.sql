USE [KisaMetaka.ImaLiKoJaci]
GO
SET IDENTITY_INSERT [dbo].[Songs] ON 

GO
INSERT [dbo].[Songs] ([Id], [Title], [YoutubeUrl]) VALUES (1, N'Mirela Holy', N'https://www.youtube.com/watch?v=7aLcw8nddok')
GO
INSERT [dbo].[Songs] ([Id], [Title], [YoutubeUrl]) VALUES (2, N'Pljačkam turiste', N'https://www.youtube.com/watch?v=aL80LbssDVc')
GO
SET IDENTITY_INSERT [dbo].[Songs] OFF
GO
SET IDENTITY_INSERT [dbo].[Lyrics] ON 

GO
INSERT [dbo].[Lyrics] ([Id], [Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (1, N'ima li ko jaci, ima li ko jaci', N'S ovakvim modelima ne isplati se kacit', 0, 0, 10, 1)
GO
INSERT [dbo].[Lyrics] ([Id], [Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (3, N'ganđa mi je sirova, nosin je u đepu', N'obavim poziv eto me za sekund ', 0, 0, 10, 1)
GO
INSERT [dbo].[Lyrics] ([Id], [Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (5, N'ćim uđem u tommya ukradem bocu đonija', N'kad te vidin pitan sta si donija ', 0, 0, 10, 1)
GO
INSERT [dbo].[Lyrics] ([Id], [Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (6, N'pročita sam ti tekst i pogodija koš ', N'jadranka kosor nosi moj broš ', 0, 0, 10, 1)
GO
INSERT [dbo].[Lyrics] ([Id], [Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (7, N'kad sidin na školjci čitan samo story', N'veča san kutija nego igor vori', 0, 0, 10, 1)
GO
INSERT [dbo].[Lyrics] ([Id], [Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (8, N'liti kad si u splitu kad ti triba trava', N'nađi me u biloj majici bez rukava', 0, 0, 10, 2)
GO
INSERT [dbo].[Lyrics] ([Id], [Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (9, N'stalno žrtve smjeran dok po rivi se gegan ', N'ako nešto tribaš brate nema čega nemam', 0, 0, 10, 2)
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
