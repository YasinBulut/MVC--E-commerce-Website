USE [DBYeterZüccaciye]
GO
/****** Object:  Table [dbo].[Messages]    Script Date: 1.03.2021 16:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Messages](
	[MessageID] [int] IDENTITY(1,1) NOT NULL,
	[Gönderen] [varchar](50) NULL,
	[Alici] [varchar](50) NULL,
	[Konu] [varchar](50) NULL,
	[Icerik] [varchar](2000) NULL,
	[Tarih] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_dbo.Messages] PRIMARY KEY CLUSTERED 
(
	[MessageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Messages] ON 

INSERT [dbo].[Messages] ([MessageID], [Gönderen], [Alici], [Konu], [Icerik], [Tarih]) VALUES (1, N'yasinbulut_25@outlook.com', N'icayir@outlook.com', N'Satış Hakkında', N'Elinize ulaşan ürünümüz de herhangi bir sorun olursa bire bir düzelteceğiz', CAST(N'2021-02-08 00:00:00' AS SmallDateTime))
INSERT [dbo].[Messages] ([MessageID], [Gönderen], [Alici], [Konu], [Icerik], [Tarih]) VALUES (4, N'ayse_25@hotmail.com', N'aslı@hotmail.com', N'ÜRÜN HAKKINDA', N'ALDIĞIN BANYO TAKIMI NASIL. FOTOĞRFTAKİ GİBİ Mİ BANA DÖNÜŞ YAPARMISIN', CAST(N'2021-02-08 00:00:00' AS SmallDateTime))
INSERT [dbo].[Messages] ([MessageID], [Gönderen], [Alici], [Konu], [Icerik], [Tarih]) VALUES (7, N'aslı@hotmail.com', N'ayse_25@hotmail.com', N'ÜRÜN HAKKINDA', N'EVET CANIM ÇOK GÜZEL GELDİ TAVSİYE EDERİM', CAST(N'2021-02-08 00:00:00' AS SmallDateTime))
INSERT [dbo].[Messages] ([MessageID], [Gönderen], [Alici], [Konu], [Icerik], [Tarih]) VALUES (10, N'YETER ZÜCCACİYE', N'icayir@outlook.com', N'HEDİYE', N'100 TL HEDİYE ÇEKİ KAZANDINIZ', CAST(N'2021-02-08 00:00:00' AS SmallDateTime))
INSERT [dbo].[Messages] ([MessageID], [Gönderen], [Alici], [Konu], [Icerik], [Tarih]) VALUES (11, N'YETER ZÜCCACİYE', N'havva@outlook.com', N'İNDİRİM', N'İLK ALIŞVERİŞİNİZE ÖZEL %50 İNDİRİM', CAST(N'2021-02-08 00:00:00' AS SmallDateTime))
INSERT [dbo].[Messages] ([MessageID], [Gönderen], [Alici], [Konu], [Icerik], [Tarih]) VALUES (12, N'icayir@outlook.com', N'YETER ZÜCCACİYE', N'TEŞEKKÜR', N'HEDİYE İÇİN TEŞEKKÜR EDERİM', CAST(N'2021-02-08 00:00:00' AS SmallDateTime))
INSERT [dbo].[Messages] ([MessageID], [Gönderen], [Alici], [Konu], [Icerik], [Tarih]) VALUES (13, N'yasinbulut_25@outlook.com', N'icayir@outlook.com', N'TEST', N'Programlama ya da diğer adıyla yazılımlama (İng. İngilizce: programming), bilgisayarın donanıma nasıl davranacağını anlatan, bilgisayara yön veren komutlar, kelimeler, aritmetik işlemlerdir.Diğer bir tanım verecek olursak programlama, bilgisayar programlarının yazılması, test edilmesi ve bakımının yapılması sürecine verilen isimdir. Programlama, bir programlama dilinde yapılır. Bu programlama dili Java ve C# gibi yüksek seviyede bir dil olabileceği gibi C, assembly ve bazı durumlarda makine dili de olabilir. Yazılan kaynak kodu genellikle bir derleyici ve bağlayıcı yardımıyla belirli bir sistemde çalıştırılabilir hale getirilir. Ayrıca kaynak kodu, bir yorumlayıcı yardımıyla derlemeye gerek duyulmadan satır satır çalıştırılabilir.Derleyici, yazılan programları okuyup içerisinde mantıksal veya yazımsal hatalar olup olmadığını bulan, bulduğu hataları kullanıcıya göstererek programın düzeltilmesine yardım eden, hata yoksa programı çalıştırıp sonucunu gösteren, ayrıca çeşidine göre pek çok başka özelliği barındırabilen (bir değişkenin üzerine mouse ile gelindiğinde değişkenin özelliklerini gösterme, fonksiyonun üzerine gelindiğinde kod içerisinde fonksiyonu bulup yazıldığı satıra gidebilme, kodların daha kolay okunabilmesi için etiketler yardımıyla kodları toparlayacak bölgeler oluşturabilme...) birer platformdur.

Programcılar genelde programlamayı gerçek hayata benzetirler. Bir program yazmak veya bir problemi çözmek için öncelikle komutları unutmak ve çözümü gerçek hayatta yapıyormuş gibi düşünmek gerekir. Onlara göre komutlar sadece araçtır.

Programlamaya başlayanların kendi dilleriyle "Merhaba Dünya" (Genelde : "Hello World!") yazmalarıyla başlar ve bir programlama dilini öğrenmekteki tek zorluk programlamanın ne olduğunu öğrenmektir. Bundan sonraki aşamalar ise kolayca atlatılabilir.', CAST(N'2021-02-08 00:00:00' AS SmallDateTime))
INSERT [dbo].[Messages] ([MessageID], [Gönderen], [Alici], [Konu], [Icerik], [Tarih]) VALUES (14, N'icayir@outlook.com', N'aslı@hotmail.com', N'DENEME', N'Müşteriler arası deneme mesajıdır .
                    ', CAST(N'2021-02-09 00:00:00' AS SmallDateTime))
INSERT [dbo].[Messages] ([MessageID], [Gönderen], [Alici], [Konu], [Icerik], [Tarih]) VALUES (15, N'icayir@outlook.com', N'aslı@hotmail.com', N'DENEME', N'Müşteriler arası deneme mesajıdır .
                    ', CAST(N'2021-02-09 00:00:00' AS SmallDateTime))
INSERT [dbo].[Messages] ([MessageID], [Gönderen], [Alici], [Konu], [Icerik], [Tarih]) VALUES (16, N'YETER ZÜCCACİYE', N'yasinbulut_25@outlook.com', N'HEDİYE', N'ÇALIŞAN HEDİYE ÇEKİ 200TL', CAST(N'2021-02-13 00:00:00' AS SmallDateTime))
INSERT [dbo].[Messages] ([MessageID], [Gönderen], [Alici], [Konu], [Icerik], [Tarih]) VALUES (17, N'icayir@outlook.com', N'MURAT YÜCEDAĞ', N'TEŞEKKÜR', N'UDEMY VE YOUTUBE ÜZERİNDEKİ TÜM KURSLAR İÇİN TEŞEKKÜR EDERİZ :)', CAST(N'2021-02-21 00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[Messages] OFF
