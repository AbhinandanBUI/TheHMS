CREATE TABLE [dbo].[tb_MasterCity] (
    [CityId]     BIGINT         IDENTITY (1, 1) NOT NULL,
    [CityName]   NVARCHAR (255) NOT NULL,
    [StateId]    BIGINT         NOT NULL,
    [CountryId]  BIGINT         NOT NULL,
    [IsActive]   BIT            NOT NULL,
    [CreatedBy]  BIGINT         NOT NULL,
    [CreatedOn]  DATETIME2 (7)  DEFAULT (getdate()) NULL,
    [ModifiedOn] DATETIME2 (7)  NULL,
    [ModifiedBy] BIGINT         NULL,
    PRIMARY KEY CLUSTERED ([CityId] ASC)
);

