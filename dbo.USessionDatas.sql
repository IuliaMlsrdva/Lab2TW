CREATE TABLE [dbo].[USessionDatas] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL ,
    [UserName]     NVARCHAR (30)  NOT NULL ,
    [UserPassword] NVARCHAR (30)  NOT NULL ,
    [SessionDate]  DATETIME       NOT NULL,
    [Level]        INT            NOT NULL,
    [Credential]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.USessionDatas] PRIMARY KEY CLUSTERED ([Id] ASC)
);

