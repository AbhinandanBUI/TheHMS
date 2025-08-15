CREATE TABLE [dbo].[tb_Enquery_Form] (
    [EnqueryId]        BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name]             VARCHAR (100) NOT NULL,
    [Email]            VARCHAR (100) NOT NULL,
    [Phone]            NVARCHAR (10) NULL,
    [Message]          VARCHAR (MAX) NULL,
    [IsActive]         SMALLINT      DEFAULT ((0)) NOT NULL,
    [CreatedOn]        DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserId] BIGINT        NOT NULL,
    [ModifiedOn]       DATETIME2 (7) NOT NULL,
    PRIMARY KEY CLUSTERED ([EnqueryId] ASC)
);

