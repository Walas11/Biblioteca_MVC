Buen día Ing. BARRETO SANDOVAL MARIA LUISA
Cordial saludo.

Mediante este READ presentamos nuestro proyecto de Informatica I, el proyecto esta realizado en .Net Core 8.0 en modelo MVC.

Los integrantes del grupo son:

-  Ivan Rene Rodriguez Bedoya.
-  Laura Daniela Borrero Romero.
-  Sebastian Acero Leon.

Quedamos atentos a cualquier comentario.
Gracias.





// ----------------- //
// Script cración DB //
// ----------------- //

USE [db.Inventario_libros]
GO
/****** Object:  Table [dbo].[Autores]    Script Date: 6/06/2024 10:32:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autores](
	[Codigo_autor] [varchar](6) NOT NULL,
	[Nombre_autor] [varchar](50) NOT NULL,
	[Nacionalidad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Autores] PRIMARY KEY CLUSTERED 
(
	[Codigo_autor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Editoriales]    Script Date: 6/06/2024 10:32:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Editoriales](
	[Codigo_editorial] [varchar](6) NOT NULL,
	[Nombre_editorial] [varchar](30) NOT NULL,
	[Contacto] [varchar](30) NULL,
	[Telefono] [varchar](9) NULL,
 CONSTRAINT [PK_Editoriales] PRIMARY KEY CLUSTERED 
(
	[Codigo_editorial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Generos]    Script Date: 6/06/2024 10:32:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Generos](
	[Id_genero] [int] NOT NULL,
	[Nombre_genero] [varchar](40) NOT NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Generos] PRIMARY KEY CLUSTERED 
(
	[Id_genero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Libros]    Script Date: 6/06/2024 10:32:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libros](
	[Codigo_libro] [varchar](9) NOT NULL,
	[Nombre_libro] [varchar](50) NOT NULL,
	[Existencias] [int] NOT NULL,
	[Precio] [decimal](10, 2) NOT NULL,
	[Codigo_autor] [varchar](6) NOT NULL,
	[Codigo_editorial] [varchar](6) NOT NULL,
	[Id_genero] [int] NOT NULL,
	[Descripcion] [text] NULL,
 CONSTRAINT [PK_Libros] PRIMARY KEY CLUSTERED 
(
	[Codigo_libro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Libros]  WITH CHECK ADD  CONSTRAINT [FK_Libros_Autores] FOREIGN KEY([Codigo_autor])
REFERENCES [dbo].[Autores] ([Codigo_autor])
GO
ALTER TABLE [dbo].[Libros] CHECK CONSTRAINT [FK_Libros_Autores]
GO
ALTER TABLE [dbo].[Libros]  WITH CHECK ADD  CONSTRAINT [FK_Libros_Editoriales] FOREIGN KEY([Codigo_editorial])
REFERENCES [dbo].[Editoriales] ([Codigo_editorial])
GO
ALTER TABLE [dbo].[Libros] CHECK CONSTRAINT [FK_Libros_Editoriales]
GO
ALTER TABLE [dbo].[Libros]  WITH CHECK ADD  CONSTRAINT [FK_Libros_Generos] FOREIGN KEY([Id_genero])
REFERENCES [dbo].[Generos] ([Id_genero])
GO
ALTER TABLE [dbo].[Libros] CHECK CONSTRAINT [FK_Libros_Generos]
GO
