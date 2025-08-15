CREATE TABLE [dbo].[tbNews] (
    [NewsId]           BIGINT        IDENTITY (1, 1) NOT NULL,
    [NewsDate]         DATETIME2 (7) NULL,
    [NewsTitle]        VARCHAR (100) NOT NULL,
    [NewsDescription]  VARCHAR (500) NULL,
    [Status]           BIT           DEFAULT ((1)) NOT NULL,
    [CreatedByUserId]  BIGINT        NOT NULL,
    [CreatedOn]        DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserId] BIGINT        NOT NULL,
    [ModifiedOn]       DATETIME2 (7) NOT NULL,
    PRIMARY KEY CLUSTERED ([NewsId] ASC),
    CONSTRAINT [FK_tbNews_tb_mst_User] FOREIGN KEY ([CreatedByUserId]) REFERENCES [dbo].[tb_mst_User] ([UserID]),
    CONSTRAINT [FK_tbNews_tb_mst_User1] FOREIGN KEY ([ModifiedByUserId]) REFERENCES [dbo].[tb_mst_User] ([UserID])
);

