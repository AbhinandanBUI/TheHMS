CREATE TABLE [dbo].[tb_News_Comment] (
    [NewsCommentId]      BIGINT        IDENTITY (1, 1) NOT NULL,
    [NewsId]             BIGINT        NOT NULL,
    [DoctorId]           BIGINT        NOT NULL,
    [CommentDescription] VARCHAR (MAX) NOT NULL,
    [DateOfComment]      DATE          NOT NULL,
    [Status]             BIT           DEFAULT ((1)) NOT NULL,
    [CreatedByUserId]    BIGINT        NOT NULL,
    [CreatedOn]          DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserId]   BIGINT        NOT NULL,
    [ModifiedOn]         DATETIME2 (7) NOT NULL,
    PRIMARY KEY CLUSTERED ([NewsCommentId] ASC),
    CONSTRAINT [FK_tb_News_Comment_tb_mst_User] FOREIGN KEY ([DoctorId]) REFERENCES [dbo].[tb_mst_User] ([UserID]),
    CONSTRAINT [FK_tb_News_Comment_tbNews] FOREIGN KEY ([NewsId]) REFERENCES [dbo].[tbNews] ([NewsId])
);

