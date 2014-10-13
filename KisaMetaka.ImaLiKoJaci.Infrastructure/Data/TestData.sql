﻿USE [KisaMetaka.ImaLiKoJaci]
GO

INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Mirela Holy', N'mirela-holy.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Učka učka', N'ucka-ucka.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Get funky', N'get-funky.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Imam zgodnu prijateljicu', N'imam-zgodnu-prijateljicu.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Megamasa', N'megamasa.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Niko nema meda', N'niko-nema-meda.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Paka', N'paka.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Posudi', N'posudi.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Tarzan', N'tarzan.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Zaboravi', N'zaboravi.mp3')
GO
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Pljačkam turiste', N'pljackam-turiste.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Daj pare', N'daj-pare.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Drei millioner', N'drei-millioner.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Hayabusa', N'hayabusa.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Komuna', N'komuna.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Konan', N'konan.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Mejasi', N'mejasi.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Model', N'model.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Pazar', N'pazar.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Skidaj gace', N'skidaj-gace.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Swag iznad svega', N'swag-iznad-svega.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Swagusa', N'swagusa.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Umjetnik erotike', N'umjetnik-erotike.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Apartman', N'apartman.mp3')
INSERT [dbo].[Songs] ([Title], [FileName]) VALUES (N'Fani money', N'fani-money.mp3')
GO
INSERT [dbo].[Lyrics] ([Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (N'ima li ko jaci, ima li ko jaci', N'S ovakvim modelima ne isplati se kacit', 19, 24, 10, 1)
INSERT [dbo].[Lyrics] ([Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (N'ganđa mi je sirova, nosin je u đepu', N'obavim poziv eto me za sekund ', 30, 34, 10, 1)
INSERT [dbo].[Lyrics] ([Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (N'ćim uđem u tommya ukradem bocu đonija', N'kad te vidin pitan sta si donija ', 36, 39, 10, 1)
INSERT [dbo].[Lyrics] ([Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (N'pročita sam ti tekst i pogodija koš ', N'jadranka kosor nosi moj broš ', 72, 75, 10, 1)
INSERT [dbo].[Lyrics] ([Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (N'kad sidin na školjci čitan samo story', N'veča san kutija nego igor vori', 117, 121, 10, 1)
INSERT [dbo].[Lyrics] ([Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (N'liti kad si u splitu kad ti triba trava', N'nađi me u biloj majici bez rukava', 19, 23, 10, 2)
INSERT [dbo].[Lyrics] ([Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES (N'stalno žrtve smjeran dok po rivi se gegan ', N'ako nešto tribaš brate nema čega nemam', 64, 68, 10, 2)
INSERT [dbo].[Lyrics] ([Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES ( N's dvi kune te pošaljen po veliki topli', N'ako ne vratiš ostatak batine ćeš dobit', 114, 116, 20, 3)
INSERT [dbo].[Lyrics] ([Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES ( N'non-stop kendan, kendan non-stop', N'pušin dop držin misu ka pop ', 66, 68, 10, 3)
INSERT [dbo].[Lyrics] ([Question], [Answer], [FromSecond], [ToSecond], [ScoreValue], [SongId]) VALUES ( N'bičve armani, mudante prada ', N'u pandurskoj škodi kružin priko grada', 35, 38, 10, 3)

GO
INSERT [dbo].[Users] ([DisplayName], [FacebookId], [JoinedOn], [TotalScore]) VALUES (N'Nebojsa Veron', N'10204203015810020', CAST(0x0000A3C2001EB67B AS DateTime), 0)
INSERT [dbo].[Users] ([DisplayName], [FacebookId], [JoinedOn], [TotalScore]) VALUES (N'KM BOT', N'bot', CAST(0x0000A3C200000000 AS DateTime), 0)
INSERT [dbo].[Users] ([DisplayName], [FacebookId], [JoinedOn], [TotalScore]) VALUES (N'Marko Marinovic', N'10152572816673509', CAST(0x0000A3C200000000 AS DateTime), 0)
GO
