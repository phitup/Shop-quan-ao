USE [ShopOnline]
GO
/****** Object:  Table [dbo].[category]    Script Date: 02/04/2018 3:55:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[link] [nvarchar](max) NULL,
	[meta] [nvarchar](50) NULL,
	[hide] [bit] NULL,
	[order] [int] NULL,
	[datebegin] [smalldatetime] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[menu]    Script Date: 02/04/2018 3:55:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[link] [nvarchar](max) NULL,
	[meta] [nvarchar](50) NULL,
	[hide] [bit] NULL,
	[order] [int] NULL,
	[datebegin] [smalldatetime] NULL,
 CONSTRAINT [PK_menu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[News]    Script Date: 02/04/2018 3:55:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](30) NULL,
	[img] [nvarchar](30) NULL,
	[description] [nvarchar](max) NULL,
	[detail] [ntext] NULL,
	[meta] [nvarchar](max) NULL,
	[hide] [bit] NULL,
	[order] [int] NULL,
	[datebegin] [smalldatetime] NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[product]    Script Date: 02/04/2018 3:55:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[price] [float] NULL,
	[img] [nvarchar](50) NULL,
	[img1] [nvarchar](50) NULL,
	[img2] [nvarchar](50) NULL,
	[img3] [nvarchar](50) NULL,
	[description] [ntext] NULL,
	[meta] [nvarchar](max) NULL,
	[size] [nvarchar](10) NULL,
	[color] [nvarchar](30) NULL,
	[hdie] [bit] NULL,
	[order] [int] NULL,
	[datebegin] [smalldatetime] NULL,
	[categoryid] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[category] ON 

INSERT [dbo].[category] ([id], [name], [link], [meta], [hide], [order], [datebegin]) VALUES (1, N'Quần áo Nam', NULL, N'quan-ao-nam', 1, 1, CAST(N'2018-03-13 00:00:00' AS SmallDateTime))
INSERT [dbo].[category] ([id], [name], [link], [meta], [hide], [order], [datebegin]) VALUES (2, N'Quần áo Nữ', NULL, N'quan-ao-nu', 1, 2, CAST(N'2018-03-13 00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[category] OFF
SET IDENTITY_INSERT [dbo].[menu] ON 

INSERT [dbo].[menu] ([id], [name], [link], [meta], [hide], [order], [datebegin]) VALUES (1, N'Giới thiệu', NULL, N'gioi-thieu', 1, 2, CAST(N'2018-03-09 00:00:00' AS SmallDateTime))
INSERT [dbo].[menu] ([id], [name], [link], [meta], [hide], [order], [datebegin]) VALUES (2, N'Quần áo Nam', NULL, N'san-pham/quan-ao-nam', 1, 3, CAST(N'2018-03-09 00:00:00' AS SmallDateTime))
INSERT [dbo].[menu] ([id], [name], [link], [meta], [hide], [order], [datebegin]) VALUES (3, N'Quần áo Nữ', NULL, N'san-pham/quan-ao-nu', 1, 4, CAST(N'2018-03-09 00:00:00' AS SmallDateTime))
INSERT [dbo].[menu] ([id], [name], [link], [meta], [hide], [order], [datebegin]) VALUES (4, N'Tin tức - sự kiện', NULL, N'tin-tuc-su-kien', 1, 5, CAST(N'2018-03-09 00:00:00' AS SmallDateTime))
INSERT [dbo].[menu] ([id], [name], [link], [meta], [hide], [order], [datebegin]) VALUES (5, N'Dịch vụ', NULL, N'dich-vu', 1, 6, CAST(N'2018-03-09 00:00:00' AS SmallDateTime))
INSERT [dbo].[menu] ([id], [name], [link], [meta], [hide], [order], [datebegin]) VALUES (6, N'Liên hệ', NULL, N'lien-he', 1, 7, CAST(N'2018-03-09 00:00:00' AS SmallDateTime))
INSERT [dbo].[menu] ([id], [name], [link], [meta], [hide], [order], [datebegin]) VALUES (1002, N'Trang chủ', NULL, N'trang-chu', 1, 1, CAST(N'2018-03-09 00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[menu] OFF
SET IDENTITY_INSERT [dbo].[News] ON 

INSERT [dbo].[News] ([id], [name], [img], [description], [detail], [meta], [hide], [order], [datebegin]) VALUES (1, N'tuyển dụng nhân viên giao hàng', N'men1.jpg', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined', N'tuyen-dung-nv-giao-hang', 1, 1, CAST(N'2018-03-09 00:00:00' AS SmallDateTime))
INSERT [dbo].[News] ([id], [name], [img], [description], [detail], [meta], [hide], [order], [datebegin]) VALUES (2, N'khai trương cửa hàng 1', N'men2.jpg', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined', N'khai-truong-cua-hang', 1, 1, CAST(N'2018-03-09 00:00:00' AS SmallDateTime))
INSERT [dbo].[News] ([id], [name], [img], [description], [detail], [meta], [hide], [order], [datebegin]) VALUES (1002, N'khai trương cửa hàng 1', N'pi.jpg', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined', N'khai-truong-cua-hang', 1, 1, CAST(N'2018-03-09 00:00:00' AS SmallDateTime))
INSERT [dbo].[News] ([id], [name], [img], [description], [detail], [meta], [hide], [order], [datebegin]) VALUES (1003, N'khai trương cửa hàng 1', N'pi4.jpg', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined', N'khai-truong-cua-hang', 1, 1, CAST(N'2018-03-09 00:00:00' AS SmallDateTime))
INSERT [dbo].[News] ([id], [name], [img], [description], [detail], [meta], [hide], [order], [datebegin]) VALUES (1004, N'khai trương cửa hàng 1', N'men2.jpg', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined', N'khai-truong-cua-hang', 1, 1, CAST(N'2018-03-09 00:00:00' AS SmallDateTime))
INSERT [dbo].[News] ([id], [name], [img], [description], [detail], [meta], [hide], [order], [datebegin]) VALUES (1005, N'khai trương cửa hàng 1', N'logo.png', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined', N'khai-truong-cua-hang', 1, 1, CAST(N'2018-03-09 00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[News] OFF
SET IDENTITY_INSERT [dbo].[product] ON 

INSERT [dbo].[product] ([id], [name], [price], [img], [img1], [img2], [img3], [description], [meta], [size], [color], [hdie], [order], [datebegin], [categoryid]) VALUES (1, N'Quần jean nam', 230000, N'sin1.jpg', N'pi.jpg', N'sin1.jpg', N'sin4.jpg', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined', N'quan-jean-nam', NULL, NULL, 1, 1, CAST(N'2018-03-13 00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[product] ([id], [name], [price], [img], [img1], [img2], [img3], [description], [meta], [size], [color], [hdie], [order], [datebegin], [categoryid]) VALUES (2, N'Áo thun nam', 230000, N'sin2.jpg', N'pi4.jpg', N'sin1.jpg', N'sin3.jpg', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined', N'ao-thun-nam', NULL, NULL, 1, 2, CAST(N'2018-03-13 00:00:00' AS SmallDateTime), 2)
INSERT [dbo].[product] ([id], [name], [price], [img], [img1], [img2], [img3], [description], [meta], [size], [color], [hdie], [order], [datebegin], [categoryid]) VALUES (3, N'Áo nam', 230000, N'sin3.jpg', N'pi4.jpg', N'sin1.jpg', N'sin3.jpg', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined', N'ao-nam', NULL, NULL, 1, 3, CAST(N'2018-03-13 00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[product] ([id], [name], [price], [img], [img1], [img2], [img3], [description], [meta], [size], [color], [hdie], [order], [datebegin], [categoryid]) VALUES (4, N'Áo nam', 230000, N'sin1.jpg', N'pi5.jpg', N'sin1.jpg', N'sin2.jpg', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined', N'ao-nam', NULL, NULL, 1, 3, CAST(N'2018-03-13 00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[product] ([id], [name], [price], [img], [img1], [img2], [img3], [description], [meta], [size], [color], [hdie], [order], [datebegin], [categoryid]) VALUES (5, N'Quần jean nam', 230000, N'sin4.jpg', N'pi.jpg', N'sin4.jpg', N'sin2.jpg', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined', N'quan-jean-nam', NULL, NULL, 1, 1, CAST(N'2018-03-13 00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[product] ([id], [name], [price], [img], [img1], [img2], [img3], [description], [meta], [size], [color], [hdie], [order], [datebegin], [categoryid]) VALUES (6, N'Áo thun nam', 230000, N'sin1.jpg', N'pi6.jpg', N'sin4.jpg', N'sin2.jpg', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined', N'ao-thun-nam', NULL, NULL, 1, 2, CAST(N'2018-03-13 00:00:00' AS SmallDateTime), 2)
INSERT [dbo].[product] ([id], [name], [price], [img], [img1], [img2], [img3], [description], [meta], [size], [color], [hdie], [order], [datebegin], [categoryid]) VALUES (7, NULL, NULL, N'sin1.jpg', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[product] OFF
