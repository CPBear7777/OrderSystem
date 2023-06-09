USE [master]
GO
/****** Object:  Database [HoneyBearDB]    Script Date: 2023/4/19 下午 04:49:02 ******/
CREATE DATABASE [HoneyBearDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HoneyBearDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HoneyBearDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HoneyBearDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HoneyBearDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HoneyBearDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HoneyBearDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HoneyBearDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HoneyBearDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HoneyBearDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HoneyBearDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HoneyBearDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [HoneyBearDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HoneyBearDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HoneyBearDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HoneyBearDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HoneyBearDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HoneyBearDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HoneyBearDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HoneyBearDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HoneyBearDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HoneyBearDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HoneyBearDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HoneyBearDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HoneyBearDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HoneyBearDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HoneyBearDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HoneyBearDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HoneyBearDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HoneyBearDB] SET RECOVERY FULL 
GO
ALTER DATABASE [HoneyBearDB] SET  MULTI_USER 
GO
ALTER DATABASE [HoneyBearDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HoneyBearDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HoneyBearDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HoneyBearDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HoneyBearDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HoneyBearDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HoneyBearDB', N'ON'
GO
ALTER DATABASE [HoneyBearDB] SET QUERY_STORE = OFF
GO
USE [HoneyBearDB]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 2023/4/19 下午 04:49:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[p_ID] [int] IDENTITY(10001,1) NOT NULL,
	[p_Name] [nvarchar](50) NOT NULL,
	[p_Desc] [nvarchar](300) NULL,
	[p_Element] [nvarchar](150) NULL,
	[p_Price] [int] NOT NULL,
	[p_Quantity] [int] NOT NULL,
	[p_SoldQuantity] [int] NOT NULL,
	[p_Type] [nvarchar](20) NOT NULL,
	[p_Image] [nvarchar](50) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[p_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([p_ID], [p_Name], [p_Desc], [p_Element], [p_Price], [p_Quantity], [p_SoldQuantity], [p_Type], [p_Image]) VALUES (10001, N'提拉米蘇', N'刷過咖啡酒糖液的海綿蛋糕為蛋糕體，夾入瑪斯卡邦乳酪，口感滑順，奶香十足，最後做出波浪紋路再撒上可可粉，整體口感多層次，且帶點酒香的成熟風味。', N'蛋、杏仁粉、可可粉、瑪斯卡邦乳酪、赤藻糖醇、牛奶、鹽、檸檬汁、咖啡酒糖液', 90, 20, 0, N'PType01', N'Tiramisu.jpg')
INSERT [dbo].[Products] ([p_ID], [p_Name], [p_Desc], [p_Element], [p_Price], [p_Quantity], [p_SoldQuantity], [p_Type], [p_Image]) VALUES (10002, N'舒芙蕾', N'蓬鬆入口即化的舒芙蕾，搭配香草冰淇淋與安格斯醬。', N'蛋、低筋麵粉、香草精、砂糖、牛奶、泡打粉、蜂蜜、香草、安格斯醬', 120, 15, 0, N'PType01', N'Souffle.jpg')
INSERT [dbo].[Products] ([p_ID], [p_Name], [p_Desc], [p_Element], [p_Price], [p_Quantity], [p_SoldQuantity], [p_Type], [p_Image]) VALUES (10003, N'巧克力塔', N'嚴選比利時進口巧克力，不甜不膩的生巧克力內餡，如愛情般的濃情滋味。', N'比利時頂級巧克力、手作自製果醬、動物性鮮奶油、法國發酵奶油、全脂鮮奶、二砂糖、低筋麵粉', 60, 20, 0, N'PType01', N'ChocolateTart.jpg')
INSERT [dbo].[Products] ([p_ID], [p_Name], [p_Desc], [p_Element], [p_Price], [p_Quantity], [p_SoldQuantity], [p_Type], [p_Image]) VALUES (10004, N'藍莓塔', N'藍莓的香甜汁液遇上就是好吃的塔塔家主廚乳酪醬，襯著酥酥脆脆的塔皮 ，這就是幸福的味道。', N'新鮮藍莓、手作自製果醬、法國動物性鮮奶油、法國發酵奶油、全脂鮮奶、二砂糖、低筋麵粉', 70, 20, 0, N'PType01', N'BlueberryTart.jpg')
INSERT [dbo].[Products] ([p_ID], [p_Name], [p_Desc], [p_Element], [p_Price], [p_Quantity], [p_SoldQuantity], [p_Type], [p_Image]) VALUES (10005, N'鬆餅', N'輕盈、鬆軟，口感十分豐富的鬆餅，加上新鮮的水果和香草冰淇淋，感受完美的口感和豐富的風味。', N'鬆餅粉、蛋、香草冰淇淋、奶油、水果', 110, 15, 0, N'PType01', N'Pancake.jpg')
INSERT [dbo].[Products] ([p_ID], [p_Name], [p_Desc], [p_Element], [p_Price], [p_Quantity], [p_SoldQuantity], [p_Type], [p_Image]) VALUES (10006, N'聖代', N'沖繩縣產的芒果，並透過不同的刀法呈現出多層次口感。使用自製的熱帶芒果果露與異國風味的醬汁、牛奶冰淇淋以及蔓越梅醬的盛夏組合。', N'芒果、牛奶冰淇淋、蔓越莓醬、其他水果', 140, 10, 0, N'PType01', N'Churros.jpg')
INSERT [dbo].[Products] ([p_ID], [p_Name], [p_Desc], [p_Element], [p_Price], [p_Quantity], [p_SoldQuantity], [p_Type], [p_Image]) VALUES (10007, N'香草千層', N'滑順的香草鮮奶油，內餡與蛋皮的黃金比例，大人小孩都喜歡的人氣口味。', N'蛋、牛奶、糖、鹽、奶油、中筋麵粉、香草精', 70, 15, 0, N'PType01', N'VanillaLayerCake.jpg')
INSERT [dbo].[Products] ([p_ID], [p_Name], [p_Desc], [p_Element], [p_Price], [p_Quantity], [p_SoldQuantity], [p_Type], [p_Image]) VALUES (10008, N'巧克力千層', N'苦甜可可鮮奶油層層堆疊出濃郁滋味，表層獨創的長頸鹿圖案，讓您同時擁有視覺與味覺的雙重享受。', N'蛋、牛奶、糖、鹽、奶油、中筋麵粉、巧克力', 70, 15, 0, N'PType01', N'ChocolateLayerCake.jpg')
INSERT [dbo].[Products] ([p_ID], [p_Name], [p_Desc], [p_Element], [p_Price], [p_Quantity], [p_SoldQuantity], [p_Type], [p_Image]) VALUES (10009, N'蜂蜜蛋糕', N'嚴選頂級龍眼蜜、新鮮雞蛋，透過鬆軟綿密的蛋糕，甜香經典讓味蕾享受最真的原味。', N'蛋、高筋麵粉、蜂蜜、牛奶、砂糖、植物油、中雙糖、檸檬汁', 55, 30, 0, N'PType01', N'HoneyCake.jpg')
INSERT [dbo].[Products] ([p_ID], [p_Name], [p_Desc], [p_Element], [p_Price], [p_Quantity], [p_SoldQuantity], [p_Type], [p_Image]) VALUES (10010, N'草莓蛋糕', N'酸酸甜甜的草莓，綿密口感的奶油與蓬鬆的海綿蛋糕結合成有戀愛滋味的草莓蛋糕。', N'蛋、砂糖、低筋麵粉、無鹽奶油、玉米粉、檸檬汁', 70, 15, 0, N'PType01', N'StrawberryCake.jpg')
INSERT [dbo].[Products] ([p_ID], [p_Name], [p_Desc], [p_Element], [p_Price], [p_Quantity], [p_SoldQuantity], [p_Type], [p_Image]) VALUES (10011, N'錫蘭紅茶', N'我們的錫蘭紅茶是來自斯里蘭卡優質茶葉，香氣撲鼻，滋味獨特。我們的紅茶口感濃郁，帶有淡淡的果香，口感平衡，帶來一份清新和平靜。此茶可與牛奶或糖搭配飲用，或單獨品嚐。', N'錫蘭紅茶葉、水', 55, 30, 0, N'PType02', N'BlackTea.jpg')
INSERT [dbo].[Products] ([p_ID], [p_Name], [p_Desc], [p_Element], [p_Price], [p_Quantity], [p_SoldQuantity], [p_Type], [p_Image]) VALUES (10012, N'紅茶拿鐵', N'我們的紅茶拿鐵是混合了濃郁的錫蘭紅茶和香濃的牛奶，口感濃郁且充滿層次感。這種茶飲是一種兼具醇香和滑順的口感，絕對是您享受午後茶時的完美伴侶。', N'錫蘭紅茶、水、鮮乳', 70, 30, 0, N'PType02', N'MilkTea.jpg')
INSERT [dbo].[Products] ([p_ID], [p_Name], [p_Desc], [p_Element], [p_Price], [p_Quantity], [p_SoldQuantity], [p_Type], [p_Image]) VALUES (10013, N'黑咖啡', N'我們的黑咖啡使用了最優質的咖啡豆，風味濃郁，口感豐富。您可以品嚐到咖啡的微苦和淡淡的焦糖香氣。這種咖啡最好單獨飲用，以便充分品嚐咖啡的口感和風味。', N'嚴選咖啡豆、水', 60, 30, 0, N'PType02', N'Coffee.jpg')
INSERT [dbo].[Products] ([p_ID], [p_Name], [p_Desc], [p_Element], [p_Price], [p_Quantity], [p_SoldQuantity], [p_Type], [p_Image]) VALUES (10014, N'拿鐵', N'我們的拿鐵是將濃郁的咖啡與香濃的牛奶混合製作而成，口感豐富且奶味濃郁。這種咖啡可根據您的喜好調整糖和奶的比例，來達到您的理想口感。', N'嚴選咖啡豆、水、鮮乳', 75, 30, 0, N'PType02', N'Latte.jpg')
INSERT [dbo].[Products] ([p_ID], [p_Name], [p_Desc], [p_Element], [p_Price], [p_Quantity], [p_SoldQuantity], [p_Type], [p_Image]) VALUES (10015, N'麥茶', N'我們的麥茶是用新鮮的麥子製作而成，帶有清新的口感和獨特的風味。麥茶的口感爽口，有助於消暑解渴。您還可以加入檸檬或蜜糖，以增加風味層次。', N'大麥、水', 45, 30, 0, N'PType02', N'BarleyTea.jpg')
INSERT [dbo].[Products] ([p_ID], [p_Name], [p_Desc], [p_Element], [p_Price], [p_Quantity], [p_SoldQuantity], [p_Type], [p_Image]) VALUES (10016, N'餐具', N'無', N'無', 0, 100, 0, N'PType03', N'Tableware.jpg')
INSERT [dbo].[Products] ([p_ID], [p_Name], [p_Desc], [p_Element], [p_Price], [p_Quantity], [p_SoldQuantity], [p_Type], [p_Image]) VALUES (10017, N'提袋', N'無', N'無', 1, 100, 0, N'PType03', N'Bag.jpg')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
USE [master]
GO
ALTER DATABASE [HoneyBearDB] SET  READ_WRITE 
GO
