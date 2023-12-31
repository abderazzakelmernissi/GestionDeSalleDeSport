USE [master]
GO
/****** Object:  Database [GGYM]    Script Date: 09/05/2016 00:28:50 ******/
CREATE DATABASE [GGYM] ON  PRIMARY 
( NAME = N'GGYM', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\GGYM.mdf' , SIZE = 3328KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GGYM_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\GGYM_log.LDF' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GGYM] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GGYM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GGYM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GGYM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GGYM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GGYM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GGYM] SET ARITHABORT OFF 
GO
ALTER DATABASE [GGYM] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [GGYM] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [GGYM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GGYM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GGYM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GGYM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GGYM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GGYM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GGYM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GGYM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GGYM] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GGYM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GGYM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GGYM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GGYM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GGYM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GGYM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GGYM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GGYM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GGYM] SET  MULTI_USER 
GO
ALTER DATABASE [GGYM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GGYM] SET DB_CHAINING OFF 
GO
USE [GGYM]
GO
/****** Object:  StoredProcedure [dbo].[ADD_ENTRAINEUR]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ADD_ENTRAINEUR]
@NomEntraineur varchar(25),
@PrenomEntraineur varchar(25),
@sexeEntraineur varchar(25),
@DDNEntraineur Date,
@NumPhoneEntraineur varchar(25),
@EmailEntraineur varchar(50),
@AdressEntraineur varchar(50),
@IdSport int,
@ImageEntraineur image

as
INSERT INTO [dbo].[entraineur]
           ([NomEntraineur]
           ,[PrenomEntraineur]
           ,[SexeEntraineur]
           ,[DDNEntraineur]
           ,[NumPhoneEntraineur]
           ,[EmailEntraineur]
           ,[AdresseEntraineur]
           ,[IdSport]
           ,ImageEntraineur)
     VALUES
           (@NomEntraineur
           ,@PrenomEntraineur
           ,@sexeEntraineur
           ,@DDNEntraineur
           ,@NumPhoneEntraineur
           ,@EmailEntraineur
           ,@AdressEntraineur
           ,@IdSport
           ,@ImageEntraineur )

GO
/****** Object:  StoredProcedure [dbo].[ADD_MEMBER]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ADD_MEMBER]
@nomMember varchar(25),
@PrenomMember varchar (25),
@SexeMember varchar(25),
@DDNMember date,
@NumPhoneMember varchar(25),
@EmailMember varchar(50),
@AdresseMember varchar(50),
@PoisMember int,
@HauteurMember float,
@IdEntraineur int,
@IdGroupe int,
@image image,
@IdSport int,
@assurance varchar(3),
@ceinture varchar(30)
as
INSERT INTO member
           ([NomMember]
           ,[PrenomMember]
           ,[SexeMember]
           ,[DDNMember]
           ,[NumPhoneMember]
           ,[EmailMember]
           ,[AdresseMember]
           ,[PoisMember]
           ,[HauteurMember]
           ,[IdEntraineur]
           ,[IdGroupe]
           ,[ImageMember]
		   ,idSport
		   ,assurance,
		   ceinture)
     VALUES
           (@NomMember
           ,@PrenomMember
           ,@SexeMember
           ,@DDNMember
           ,@NumPhoneMember
           ,@EmailMember
           ,@AdresseMember
           ,@PoisMember
           ,@HauteurMember
           ,@IdEntraineur
           ,@IdGroupe
           ,@image
		   ,@IdSport
		   ,@assurance
		   ,@ceinture);
	insert into Mois values('0','0','0','0','0','0','0','0','0','0','0','0');


GO
/****** Object:  StoredProcedure [dbo].[AddGroup]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[AddGroup]
@nomG varchar(30),
@idEntrineur int,
@idSport int

as
INSERT INTO [dbo].[groupe]
           ([NomGroupe]
           ,[IdEntraineur]
           ,[IdSport])
     VALUES
           (@nomG
           ,@idEntrineur
           ,@idSport)

GO
/****** Object:  StoredProcedure [dbo].[AddSport]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddSport]
@NomSport varchar(30)
as
insert into sport values(@NomSport);
GO
/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddUser]
@user varchar(30), @password varchar(30),@type varchar(30)
as

INSERT INTO [dbo].[Users]
           ([ID]
           ,[MDP]
           ,[Typ])
     VALUES
           (@user,@password,@type)

GO
/****** Object:  StoredProcedure [dbo].[archiverMember]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[archiverMember]
@id int
as
update member set Archive = 'yes' where IdMember=@id;
GO
/****** Object:  StoredProcedure [dbo].[DELETE_ENTRAINEUR]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[DELETE_ENTRAINEUR]
 @IdE int
 as
 delete from entraineur where IdEntraineur=@Ide;
GO
/****** Object:  StoredProcedure [dbo].[delete_event]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[delete_event]
 @id int
 as 
 delete from evenement where IdEvent = @id;
GO
/****** Object:  StoredProcedure [dbo].[DeleteMember]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DeleteMember]
@ID int
as
delete from member where IdMember=@ID;
delete from Mois where IdM=@ID
GO
/****** Object:  StoredProcedure [dbo].[Edit_Entraineur]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Edit_Entraineur]
@NomEntraineur varchar(25),
@PrenomEntraineur varchar(25),
@sexeEntraineur varchar(25),
@DDNEntraineur Date,
@NumPhoneEntraineur varchar(25),
@EmailEntraineur varchar(50),
@AdressEntraineur varchar(50),
@IdSport int,
@ImageEntraineur image,
@IdEntraineur int
as 

UPDATE [dbo].[entraineur]
   SET [NomEntraineur] = @NomEntraineur
      ,[PrenomEntraineur] = @PrenomEntraineur
      ,[SexeEntraineur] = @sexeEntraineur
      ,[DDNEntraineur] = @DDNEntraineur
      ,[NumPhoneEntraineur] = @NumPhoneEntraineur
      ,[EmailEntraineur] = @EmailEntraineur
      ,[AdresseEntraineur] = @AdressEntraineur
      ,[IdSport] = @IdSport
      ,[ImageEntraineur] = @ImageEntraineur
 WHERE  IdEntraineur=@IdEntraineur
GO
/****** Object:  StoredProcedure [dbo].[Edit_Member]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Edit_Member]
@ID int,
@nomMember varchar(25),
@PrenomMember varchar (25),
@SexeMember varchar(25),
@DDNMember date,
@NumPhoneMember varchar(25),
@EmailMember varchar(50),
@AdresseMember varchar(50),
@PoisMember int,
@HauteurMember float,
@IdEntraineur int,
@IdGroupe int,
@image image,
@IdSport int,
@assurance varchar(3),
@ceinture varchar(30)
as

UPDATE [dbo].[member]
   SET [NomMember] = @nomMember
      ,[PrenomMember] = @PrenomMember
      ,[DDNMember] = @DDNMember
      ,[NumPhoneMember] = @NumPhoneMember
      ,[EmailMember] = @EmailMember
      ,[AdresseMember] = @AdresseMember
      ,[PoisMember] = @PoisMember
      ,[HauteurMember] = @HauteurMember
      ,[IdEntraineur] = @IdEntraineur
      ,[IdGroupe] = @IdGroupe
      ,[ImageMember] = @image
      ,[SexeMember] = @SexeMember
      ,[idSport] = @IdSport
	  ,assurance = @assurance
	  ,ceinture = @ceinture
 WHERE IdMember = @ID;

GO
/****** Object:  StoredProcedure [dbo].[Get_Member]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Get_Member]
 @id int
 as 
SELECT [IdMember]
      ,[NomMember]
      ,[PrenomMember]
      ,[DDNMember]
      ,[NumPhoneMember]
      ,[EmailMember]
      ,[AdresseMember]
      ,[PoisMember]
      ,[HauteurMember]
      ,[NomEntraineur] +' '+ PrenomEntraineur as 'NomCE'
      ,[NomGroupe]
      ,[ImageMember]
      ,[SexeMember]
      ,[NomSport]
	  ,assurance
	  ,ceinture
 from member m , entraineur e,sport s, groupe g
 where IdMember = @id
 and e.IdEntraineur = m.IdEntraineur
 and m.idSport = s.IdSport
 and m.IdGroupe = g.IdGroupe
GO
/****** Object:  StoredProcedure [dbo].[GetAllEntraineur]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllEntraineur]
as
 SELECT [IdEntraineur]
      ,[NomEntraineur]
      ,[PrenomEntraineur]
      ,[SexeEntraineur]
      ,[DDNEntraineur]
      ,[NumPhoneEntraineur]
      ,[EmailEntraineur]
      ,[AdresseEntraineur]
      ,[NomSport]

 from entraineur, sport where entraineur.IdSport = sport.IdSport;
GO
/****** Object:  StoredProcedure [dbo].[GetAllEvent]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllEvent]
as
select * from evenement
GO
/****** Object:  StoredProcedure [dbo].[GetAllMember]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllMember]
as

SELECT [IdMember]
      ,[NomMember]
      ,[PrenomMember]
      ,[DDNMember]
      ,[NumPhoneMember]
      ,[EmailMember]
      ,[AdresseMember]
      ,[PoisMember]
      ,[HauteurMember]
      ,[NomEntraineur]
      ,[IdGroupe]
      ,[SexeMember]
      ,[nomSport]
	  ,assurance
	  ,ceinture
	  
  FROM [dbo].[member],entraineur,sport  
  where member.IdEntraineur=entraineur.IdEntraineur and member.idSport = sport.IdSport and member.Archive='no'
GO
/****** Object:  StoredProcedure [dbo].[GetAllMemberArchiver]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllMemberArchiver]
as

SELECT [IdMember]
      ,[NomMember]
      ,[PrenomMember]
      ,[DDNMember]
      ,[NumPhoneMember]
      ,[EmailMember]
      ,[AdresseMember]
      ,[PoisMember]
      ,[HauteurMember]
      ,[NomEntraineur]
      ,[IdGroupe]
      ,[SexeMember]
      ,[nomSport]
	  ,assurance
	  ,ceinture
	  
  FROM [dbo].[member],entraineur,sport  
  where member.IdEntraineur=entraineur.IdEntraineur and member.idSport = sport.IdSport and member.Archive='yes'
GO
/****** Object:  StoredProcedure [dbo].[GetALLMemberForPrint]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[GetALLMemberForPrint]
 as 
SELECT [IdMember]
      ,[NomMember]
      ,[PrenomMember]
      ,[DDNMember]
      ,[NumPhoneMember]
      ,[EmailMember]
      ,[AdresseMember]
      ,[PoisMember]
      ,[HauteurMember]
      ,[NomEntraineur] +' '+ PrenomEntraineur as 'NomCE'
      ,[NomGroupe]
      ,[ImageMember]
      ,[SexeMember]
      ,[NomSport]
	  ,assurance
	  ,ceinture
 from member m , entraineur e,sport s, groupe g
 where 
  e.IdEntraineur = m.IdEntraineur
 and m.idSport = s.IdSport
 and m.IdGroupe = g.IdGroupe
and m.Archive='no'
GO
/****** Object:  StoredProcedure [dbo].[GetALLMemberForPrintArchiver]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetALLMemberForPrintArchiver]
 as 
SELECT [IdMember]
      ,[NomMember]
      ,[PrenomMember]
      ,[DDNMember]
      ,[NumPhoneMember]
      ,[EmailMember]
      ,[AdresseMember]
      ,[PoisMember]
      ,[HauteurMember]
      ,[NomEntraineur] +' '+ PrenomEntraineur as 'NomCE'
      ,[NomGroupe]
      ,[ImageMember]
      ,[SexeMember]
      ,[NomSport]
	  ,assurance
	  ,ceinture
 from member m , entraineur e,sport s, groupe g
 where 
  e.IdEntraineur = m.IdEntraineur
 and m.idSport = s.IdSport
 and m.IdGroupe = g.IdGroupe
and m.Archive='yes'
GO
/****** Object:  StoredProcedure [dbo].[GetAllSports]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllSports]
as 
select * from sport
GO
/****** Object:  StoredProcedure [dbo].[GetEntraineur]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetEntraineur]
@IdSport int
as 
select * from entraineur where IdSport = @IdSport;
GO
/****** Object:  StoredProcedure [dbo].[GetGroup]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetGroup]
@IdEntraineur int
as 
select * from groupe where IdEntraineur =@IdEntraineur;
GO
/****** Object:  StoredProcedure [dbo].[GETIMAGEENTRAINEUR]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create proc [dbo].[GETIMAGEENTRAINEUR]
 @IDE int
 as
 select ImageEntraineur from entraineur where IdEntraineur=@IDE
GO
/****** Object:  StoredProcedure [dbo].[GetImageMember]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetImageMember]
@ID  int
as
select ImageMember from member where IdMember=@ID;

GO
/****** Object:  StoredProcedure [dbo].[GetMemberMonth]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetMemberMonth]
@idm int
as
select * from mois where IdM =@idm
GO
/****** Object:  StoredProcedure [dbo].[GetNomPaye]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetNomPaye]
 @idmonth int
 as 
if(@idmonth= 1 ) select [IdMember],[NomMember],[PrenomMember],[DDNMember],[NumPhoneMember],[EmailMember],[AdresseMember],[PoisMember],[HauteurMember],[IdEntraineur],[IdGroupe],[SexeMember],[idSport] from Mois mo , member m where jan ='0' and mo.IdM = m.IdMember 
if(@idmonth= 2 ) select [IdMember],[NomMember],[PrenomMember],[DDNMember],[NumPhoneMember],[EmailMember],[AdresseMember],[PoisMember],[HauteurMember],[IdEntraineur],[IdGroupe],[SexeMember],[idSport] from Mois mo , member m where Feb ='0' and mo.IdM = m.IdMember
if(@idmonth= 3 ) select [IdMember],[NomMember],[PrenomMember],[DDNMember],[NumPhoneMember],[EmailMember],[AdresseMember],[PoisMember],[HauteurMember],[IdEntraineur],[IdGroupe],[SexeMember],[idSport] from Mois mo , member m where  Mar ='0' and mo.IdM = m.IdMember
if(@idmonth= 4 ) select [IdMember],[NomMember],[PrenomMember],[DDNMember],[NumPhoneMember],[EmailMember],[AdresseMember],[PoisMember],[HauteurMember],[IdEntraineur],[IdGroupe],[SexeMember],[idSport] from Mois mo , member m where Apr ='0' and mo.IdM = m.IdMember
if(@idmonth= 5 ) select [IdMember],[NomMember],[PrenomMember],[DDNMember],[NumPhoneMember],[EmailMember],[AdresseMember],[PoisMember],[HauteurMember],[IdEntraineur],[IdGroupe],[SexeMember],[idSport] from Mois mo , member m where May ='0' and mo.IdM = m.IdMember
if(@idmonth= 6 ) select [IdMember],[NomMember],[PrenomMember],[DDNMember],[NumPhoneMember],[EmailMember],[AdresseMember],[PoisMember],[HauteurMember],[IdEntraineur],[IdGroupe],[SexeMember],[idSport] from Mois mo , member m where Jun ='0' and mo.IdM = m.IdMember
if(@idmonth= 7 ) select [IdMember],[NomMember],[PrenomMember],[DDNMember],[NumPhoneMember],[EmailMember],[AdresseMember],[PoisMember],[HauteurMember],[IdEntraineur],[IdGroupe],[SexeMember],[idSport] from Mois mo , member m where Jul ='0' and mo.IdM = m.IdMember
if(@idmonth= 8 ) select [IdMember],[NomMember],[PrenomMember],[DDNMember],[NumPhoneMember],[EmailMember],[AdresseMember],[PoisMember],[HauteurMember],[IdEntraineur],[IdGroupe],[SexeMember],[idSport] from Mois mo , member m where Aug ='0' and mo.IdM = m.IdMember
if(@idmonth= 9 ) select [IdMember],[NomMember],[PrenomMember],[DDNMember],[NumPhoneMember],[EmailMember],[AdresseMember],[PoisMember],[HauteurMember],[IdEntraineur],[IdGroupe],[SexeMember],[idSport] from Mois mo , member m where Sep ='0' and mo.IdM = m.IdMember
if(@idmonth= 10 ) select [IdMember],[NomMember],[PrenomMember],[DDNMember],[NumPhoneMember],[EmailMember],[AdresseMember],[PoisMember],[HauteurMember],[IdEntraineur],[IdGroupe],[SexeMember],[idSport] from Mois mo , member m where Oct ='0'  and mo.IdM = m.IdMember
if(@idmonth= 11 ) select [IdMember],[NomMember],[PrenomMember],[DDNMember],[NumPhoneMember],[EmailMember],[AdresseMember],[PoisMember],[HauteurMember],[IdEntraineur],[IdGroupe],[SexeMember],[idSport] from Mois mo , member m where Nov ='0' and mo.IdM = m.IdMember
if(@idmonth= 12 ) select [IdMember],[NomMember],[PrenomMember],[DDNMember],[NumPhoneMember],[EmailMember],[AdresseMember],[PoisMember],[HauteurMember],[IdEntraineur],[IdGroupe],[SexeMember],[idSport] from Mois mo , member m where Dece ='0' and mo.IdM = m.IdMember

GO
/****** Object:  StoredProcedure [dbo].[Insert_event]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_event]
 @nomE varchar(100), @desc varchar(200), @Dte date
as
INSERT INTO [dbo].[evenement]
           ([NomEvent]
           ,[DateEvent]
           ,[DescriptionEvent])
     VALUES
           (@nomE
           ,@Dte
           ,@desc)

GO
/****** Object:  StoredProcedure [dbo].[ReArchiverMember]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReArchiverMember]
@id int
as
update member set Archive = 'no' where IdMember=@id;
GO
/****** Object:  StoredProcedure [dbo].[RECHENTRAINEUR]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[RECHENTRAINEUR]
@mot varchar(30)
as
SELECT [IdEntraineur]
      ,[NomEntraineur]
      ,[PrenomEntraineur]
      ,[SexeEntraineur]
      ,[DDNEntraineur]
      ,[NumPhoneEntraineur]
      ,[EmailEntraineur]
      ,[AdresseEntraineur]
      ,[NomSport]

from entraineur E, sport S
where convert(varchar,IdEntraineur)
		+ NomEntraineur+PrenomEntraineur+SexeEntraineur+
		convert(varchar,DDNEntraineur)+NumPhoneEntraineur+EmailEntraineur
		+AdresseEntraineur + NomSport like '%'+@mot+'%' 
and E.IdSport = S.IdSport;
GO
/****** Object:  StoredProcedure [dbo].[RechMember]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[RechMember]
@Mot varchar(50)
as

SELECT [IdMember]
      ,[NomMember]
      ,[PrenomMember]
      ,[DDNMember]
      ,[NumPhoneMember]
      ,[EmailMember]
      ,[AdresseMember]
      ,[PoisMember]
      ,[HauteurMember]
      ,[NomEntraineur]
      ,[IdGroupe]
      ,[SexeMember]
      ,[nomSport]
	  ,assurance
	  ,ceinture

  FROM member m , entraineur e,sport s
  where 
  e.IdEntraineur = m.IdEntraineur
 and m.idSport = s.IdSport and [NomMember]
      +[PrenomMember]
      +convert(varchar,[DDNMember])
      +[NumPhoneMember]
      +[EmailMember]
      +[AdresseMember]
      +convert(varchar,[PoisMember])
      +convert(varchar,[HauteurMember])
      +[NomEntraineur]+PrenomEntraineur
      +convert(varchar,IdGroupe)+ceinture+assurance
      +[SexeMember] like '%'+@Mot+'%'
GO
/****** Object:  StoredProcedure [dbo].[SP_LOGIN]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_LOGIN]
@ID varchar(30), @MDP varchar(30)
as 
select * from Users where ID =@ID and MDP = @MDP;
GO
/****** Object:  StoredProcedure [dbo].[Test1]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Test1]
@m varchar(20)
as
select count(*)
from Mois 
where @m='1'

GO
/****** Object:  StoredProcedure [dbo].[update_event]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[update_event]
@id int,
@nome varchar(100),
@dte date,
@desc varchar(500)
as 

UPDATE [dbo].[evenement]
   SET NomEvent= @nome
      ,DateEvent=@dte
      ,DescriptionEvent=@desc
 WHERE IdEvent = @id;
GO
/****** Object:  StoredProcedure [dbo].[Update_Month]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Update_Month]
@idm int , @t int
as
update Mois set
Jan = (case when @t=1 then '1' else Jan end),
Feb = (case when @t=2 then '1' else Feb end),
Mar = (case when @t=3 then '1' else Mar end),
Apr = (case when @t=4 then '1' else Apr end),
May = (case when @t=5 then '1' else May end),
Jun = (case when @t=6 then '1' else Jun end),
Jul = (case when @t=7 then '1' else Jul end),
Aug = (case when @t=8 then '1' else Aug end),
Sep = (case when @t=9 then '1' else Sep end),
Oct = (case when @t=10 then '1' else Oct end),
Nov = (case when @t=11 then '1' else Nov end),
Dece = (case when @t=12 then '1' else Dece end)
where IdM = @idm;
GO
/****** Object:  Table [dbo].[entraineur]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[entraineur](
	[IdEntraineur] [int] IDENTITY(1,1) NOT NULL,
	[NomEntraineur] [varchar](25) NULL,
	[PrenomEntraineur] [varchar](25) NULL,
	[SexeEntraineur] [varchar](25) NULL,
	[DDNEntraineur] [date] NULL,
	[NumPhoneEntraineur] [varchar](25) NULL,
	[EmailEntraineur] [varchar](50) NULL,
	[AdresseEntraineur] [varchar](50) NULL,
	[IdSport] [int] NULL,
	[ImageEntraineur] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEntraineur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[evenement]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[evenement](
	[IdEvent] [int] IDENTITY(1,1) NOT NULL,
	[NomEvent] [varchar](100) NULL,
	[DateEvent] [date] NULL,
	[DescriptionEvent] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEvent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[groupe]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[groupe](
	[IdGroupe] [int] IDENTITY(1,1) NOT NULL,
	[NomGroupe] [varchar](25) NULL,
	[IdEntraineur] [int] NULL,
	[IdSport] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdGroupe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Manager](
	[IdManager] [int] IDENTITY(1,1) NOT NULL,
	[NomManager] [varchar](25) NULL,
	[PrenomManager] [varchar](25) NULL,
	[AgeManager] [int] NULL,
	[DDNManager] [datetime] NULL,
	[NumPhoneManager] [varchar](25) NULL,
	[EmailManager] [varchar](50) NULL,
	[AdresseManager] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdManager] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[member]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[member](
	[IdMember] [int] IDENTITY(1,1) NOT NULL,
	[NomMember] [varchar](25) NULL,
	[PrenomMember] [varchar](25) NULL,
	[DDNMember] [date] NULL,
	[NumPhoneMember] [varchar](25) NULL,
	[EmailMember] [varchar](50) NULL,
	[AdresseMember] [varchar](50) NULL,
	[PoisMember] [int] NULL,
	[HauteurMember] [int] NULL,
	[IdEntraineur] [int] NULL,
	[IdGroupe] [int] NULL,
	[ImageMember] [image] NULL,
	[SexeMember] [varchar](25) NULL,
	[idSport] [int] NULL,
	[assurance] [varchar](3) NULL,
	[ceinture] [varchar](30) NULL,
	[Archive] [varchar](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMember] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mois]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mois](
	[IdM] [int] IDENTITY(1,1) NOT NULL,
	[Jan] [char](1) NULL,
	[Feb] [char](1) NULL,
	[Mar] [char](1) NULL,
	[Apr] [char](1) NULL,
	[May] [char](1) NULL,
	[Jun] [char](1) NULL,
	[Jul] [char](1) NULL,
	[Aug] [char](1) NULL,
	[Sep] [char](1) NULL,
	[Oct] [char](1) NULL,
	[Nov] [char](1) NULL,
	[Dece] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sessione]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sessione](
	[IdSession] [int] IDENTITY(1,1) NOT NULL,
	[DureeSession] [int] NULL,
	[DateDebut] [datetime] NULL,
	[DateFin] [datetime] NULL,
	[IdE] [int] NULL,
	[IdG] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSession] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sport]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sport](
	[IdSport] [int] IDENTITY(1,1) NOT NULL,
	[NomSport] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSport] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[staff]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[staff](
	[IdStaff] [int] IDENTITY(1,1) NOT NULL,
	[NomStaff] [varchar](25) NULL,
	[PrenomStaff] [varchar](25) NULL,
	[DDNStaff] [datetime] NULL,
	[EmailStaff] [varchar](50) NULL,
	[AdresseStaff] [varchar](50) NULL,
	[NumPhoneStaff] [varchar](25) NULL,
	[FonctionStaff] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdStaff] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09/05/2016 00:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [varchar](30) NOT NULL,
	[MDP] [varchar](30) NULL,
	[Typ] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[member] ADD  DEFAULT ('no') FOR [Archive]
GO
ALTER TABLE [dbo].[entraineur]  WITH CHECK ADD FOREIGN KEY([IdSport])
REFERENCES [dbo].[sport] ([IdSport])
GO
ALTER TABLE [dbo].[groupe]  WITH CHECK ADD FOREIGN KEY([IdEntraineur])
REFERENCES [dbo].[entraineur] ([IdEntraineur])
GO
ALTER TABLE [dbo].[groupe]  WITH CHECK ADD FOREIGN KEY([IdSport])
REFERENCES [dbo].[sport] ([IdSport])
GO
ALTER TABLE [dbo].[member]  WITH CHECK ADD FOREIGN KEY([idSport])
REFERENCES [dbo].[sport] ([IdSport])
GO
ALTER TABLE [dbo].[member]  WITH CHECK ADD FOREIGN KEY([IdEntraineur])
REFERENCES [dbo].[entraineur] ([IdEntraineur])
GO
ALTER TABLE [dbo].[member]  WITH CHECK ADD FOREIGN KEY([IdGroupe])
REFERENCES [dbo].[groupe] ([IdGroupe])
GO
ALTER TABLE [dbo].[Sessione]  WITH CHECK ADD FOREIGN KEY([IdE])
REFERENCES [dbo].[entraineur] ([IdEntraineur])
GO
ALTER TABLE [dbo].[Sessione]  WITH CHECK ADD FOREIGN KEY([IdG])
REFERENCES [dbo].[groupe] ([IdGroupe])
GO
USE [master]
GO
ALTER DATABASE [GGYM] SET  READ_WRITE 
GO
