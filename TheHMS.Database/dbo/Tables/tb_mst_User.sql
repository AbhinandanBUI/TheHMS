CREATE TABLE [dbo].[tb_mst_User] (
    [UserID]            BIGINT         IDENTITY (1, 1) NOT NULL,
    [UserName]          NVARCHAR (8)   NULL,
    [FirstName]         NVARCHAR (50)  NOT NULL,
    [LastName]          NVARCHAR (50)  NOT NULL,
    [Phone]             NVARCHAR (10)  NOT NULL,
    [Email]             NVARCHAR (200) NOT NULL,
    [Password]          NVARCHAR (8)   NOT NULL,
    [HashPassword]      NVARCHAR (200) NOT NULL,
    [AddressId]         BIGINT         NULL,
    [IsActive]          BIT            CONSTRAINT [DF__tb_mst_Us__IsAct__5165187F] DEFAULT ((0)) NOT NULL,
    [RoleId]            BIGINT         CONSTRAINT [DF__tb_mst_Us__RoleI__52593CB8] DEFAULT ((4)) NOT NULL,
    [Registration_Date] DATETIME2 (7)  CONSTRAINT [DF__tb_mst_Us__Regis__534D60F1] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK__tb_mst_U__1788CCAC1E77B8F8] PRIMARY KEY CLUSTERED ([UserID] ASC),
    CONSTRAINT [FK_tb_mst_User_tb_mst_Role] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[tb_mst_Role] ([Id])
);

