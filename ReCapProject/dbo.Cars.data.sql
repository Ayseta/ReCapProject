SET IDENTITY_INSERT [dbo].[Cars] ON
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description], [CarName]) VALUES (1, 1, 4, 2010, CAST(129 AS Decimal(18, 0)), N'Ekonomik', N'Corsa')
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description], [CarName]) VALUES (2, 2, 2, 2015, CAST(215 AS Decimal(18, 0)), N'Orta Sinif', N'Juke')
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description], [CarName]) VALUES (3, 4, 1, 2018, CAST(349 AS Decimal(18, 0)), N'Lux Sinif', N'Luxury Line')
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description], [CarName]) VALUES (4, 3, 5, 2018, CAST(289 AS Decimal(18, 0)), N'Suv', N'Ranger')
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description], [CarName]) VALUES (5, 4, 3, 2020, CAST(990 AS Decimal(18, 0)), N'', NULL)
SET IDENTITY_INSERT [dbo].[Cars] OFF
