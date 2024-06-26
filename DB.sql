USE [Students]
GO
/****** Object:  User [StudentUser]    Script Date: 6/6/2024 3:03:54 AM ******/
CREATE USER [StudentUser] FOR LOGIN [StudentUser] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [StudentUser]
GO
ALTER ROLE [db_datareader] ADD MEMBER [StudentUser]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [StudentUser]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/6/2024 3:03:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 6/6/2024 3:03:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Author] [nvarchar](max) NULL,
	[Shortcut] [nvarchar](max) NULL,
	[Category] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Instructors]    Script Date: 6/6/2024 3:03:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instructors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_Instructors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentBorrowBooks]    Script Date: 6/6/2024 3:03:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentBorrowBooks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
	[BorrowDate] [datetime2](7) NULL,
	[RecievedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_StudentBorrowBooks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 6/6/2024 3:03:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[MobileNumber] [nvarchar](max) NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240601215811_init', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240604200632_update-book', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240604201310_update-StudentBorrowBooks', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240604221535_remove-book-category', N'5.0.17')
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([Id], [Name], [ImagePath], [Author], [Shortcut], [Category]) VALUES (1, N'Pride and Prejudice', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSd1kRj1nnXtv-dZUhSj2n_xUDvtQFf5MzNXXcZouIU1FU_hY4A', N'Jane Austen', N'"Pride and Prejudice" is a classic novel by Jane Austen, published in 1813. It follows the story of Elizabeth Bennet, one of five sisters in the Bennet family, as she navigates the social norms, expectations, and romantic entanglements of early 19th-century England. The novel explores themes of love, marriage, class, and societal expectations, particularly through the complex relationship between Elizabeth and the wealthy and aloof Mr. Darcy. With its wit, social commentary, and memorable characters, "Pride and Prejudice" remains one of the most beloved and enduring works of English literature.', 4)
INSERT [dbo].[Books] ([Id], [Name], [ImagePath], [Author], [Shortcut], [Category]) VALUES (24, N'Pride and Prejudice', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSd1kRj1nnXtv-dZUhSj2n_xUDvtQFf5MzNXXcZouIU1FU_hY4A', N'Jane Austen', N'"Pride and Prejudice" is a classic novel by Jane Austen, published in 1813. It follows the story of Elizabeth Bennet, one of five sisters in the Bennet family, as she navigates the social norms, expectations, and romantic entanglements of early 19th-century England. The novel explores themes of love, marriage, class, and societal expectations, particularly through the complex relationship between Elizabeth and the wealthy and aloof Mr. Darcy. With its wit, social commentary, and memorable characters, "Pride and Prejudice" remains one of the most beloved and enduring works of English literature.', 4)
INSERT [dbo].[Books] ([Id], [Name], [ImagePath], [Author], [Shortcut], [Category]) VALUES (25, N'Pride and Prejudice', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSd1kRj1nnXtv-dZUhSj2n_xUDvtQFf5MzNXXcZouIU1FU_hY4A', N'Jane Austen', N'"Pride and Prejudice" is a classic novel by Jane Austen, published in 1813. It follows the story of Elizabeth Bennet, one of five sisters in the Bennet family, as she navigates the social norms, expectations, and romantic entanglements of early 19th-century England. The novel explores themes of love, marriage, class, and societal expectations, particularly through the complex relationship between Elizabeth and the wealthy and aloof Mr. Darcy. With its wit, social commentary, and memorable characters, "Pride and Prejudice" remains one of the most beloved and enduring works of English literature.', 4)
INSERT [dbo].[Books] ([Id], [Name], [ImagePath], [Author], [Shortcut], [Category]) VALUES (26, N'Pride and Prejudice', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSd1kRj1nnXtv-dZUhSj2n_xUDvtQFf5MzNXXcZouIU1FU_hY4A', N'Jane Austen', N'"Pride and Prejudice" is a classic novel by Jane Austen, published in 1813. It follows the story of Elizabeth Bennet, one of five sisters in the Bennet family, as she navigates the social norms, expectations, and romantic entanglements of early 19th-century England. The novel explores themes of love, marriage, class, and societal expectations, particularly through the complex relationship between Elizabeth and the wealthy and aloof Mr. Darcy. With its wit, social commentary, and memorable characters, "Pride and Prejudice" remains one of the most beloved and enduring works of English literature.', 4)
INSERT [dbo].[Books] ([Id], [Name], [ImagePath], [Author], [Shortcut], [Category]) VALUES (27, N'Pride and Prejudice', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSd1kRj1nnXtv-dZUhSj2n_xUDvtQFf5MzNXXcZouIU1FU_hY4A', N'Jane Austen', N'"Pride and Prejudice" is a classic novel by Jane Austen, published in 1813. It follows the story of Elizabeth Bennet, one of five sisters in the Bennet family, as she navigates the social norms, expectations, and romantic entanglements of early 19th-century England. The novel explores themes of love, marriage, class, and societal expectations, particularly through the complex relationship between Elizabeth and the wealthy and aloof Mr. Darcy. With its wit, social commentary, and memorable characters, "Pride and Prejudice" remains one of the most beloved and enduring works of English literature.', 4)
INSERT [dbo].[Books] ([Id], [Name], [ImagePath], [Author], [Shortcut], [Category]) VALUES (28, N'Pride and Prejudice', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSd1kRj1nnXtv-dZUhSj2n_xUDvtQFf5MzNXXcZouIU1FU_hY4A', N'Jane Austen', N'"Pride and Prejudice" is a classic novel by Jane Austen, published in 1813. It follows the story of Elizabeth Bennet, one of five sisters in the Bennet family, as she navigates the social norms, expectations, and romantic entanglements of early 19th-century England. The novel explores themes of love, marriage, class, and societal expectations, particularly through the complex relationship between Elizabeth and the wealthy and aloof Mr. Darcy. With its wit, social commentary, and memorable characters, "Pride and Prejudice" remains one of the most beloved and enduring works of English literature.', 4)
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
SET IDENTITY_INSERT [dbo].[Instructors] ON 

INSERT [dbo].[Instructors] ([Id], [Name], [Email], [Password]) VALUES (1, N'Fatin', N'Instructor@elibrary.com', N'123456')
SET IDENTITY_INSERT [dbo].[Instructors] OFF
GO
SET IDENTITY_INSERT [dbo].[StudentBorrowBooks] ON 

INSERT [dbo].[StudentBorrowBooks] ([Id], [StudentId], [BookId], [BorrowDate], [RecievedDate]) VALUES (1, 1, 1, CAST(N'2024-06-05T23:55:27.5500000' AS DateTime2), CAST(N'2024-06-06T01:04:30.9330244' AS DateTime2))
INSERT [dbo].[StudentBorrowBooks] ([Id], [StudentId], [BookId], [BorrowDate], [RecievedDate]) VALUES (2, 1, 24, CAST(N'2024-06-06T01:04:15.5278201' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[StudentBorrowBooks] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [Name], [Email], [Password], [MobileNumber]) VALUES (1, N'Fatin', N'Student@elibrary.com', N'123456', N'0795315533')
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
ALTER TABLE [dbo].[Books] ADD  DEFAULT ((0)) FOR [Category]
GO
ALTER TABLE [dbo].[StudentBorrowBooks]  WITH CHECK ADD  CONSTRAINT [FK_StudentBorrowBooks_Books_BookId] FOREIGN KEY([BookId])
REFERENCES [dbo].[Books] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StudentBorrowBooks] CHECK CONSTRAINT [FK_StudentBorrowBooks_Books_BookId]
GO
ALTER TABLE [dbo].[StudentBorrowBooks]  WITH CHECK ADD  CONSTRAINT [FK_StudentBorrowBooks_Students_StudentId] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StudentBorrowBooks] CHECK CONSTRAINT [FK_StudentBorrowBooks_Students_StudentId]
GO
