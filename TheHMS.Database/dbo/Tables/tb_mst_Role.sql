CREATE TABLE [dbo].[tb_mst_Role] (
    [Id]             BIGINT        IDENTITY (1, 1) NOT NULL,
    [RoleName]       NVARCHAR (50) NOT NULL,
    [IsActive]       BIT           DEFAULT ((0)) NULL,
    [CreateByUserId] BIGINT        NULL,
    [CreateOn]       DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

