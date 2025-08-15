CREATE TABLE [dbo].[tb_Address] (
    [AddressID]    BIGINT        IDENTITY (1, 1) NOT NULL,
    [UserId]       BIGINT        NOT NULL,
    [HouseNo]      VARCHAR (100) NULL,
    [Street]       VARCHAR (100) NULL,
    [Landmark]     VARCHAR (100) NULL,
    [AddressLine1] VARCHAR (100) NULL,
    [AddressLine2] VARCHAR (100) NULL,
    [CityId]       BIGINT        NULL,
    [DistrictId]   BIGINT        NOT NULL,
    [StateId]      BIGINT        NOT NULL,
    [PinCode]      NVARCHAR (6)  NOT NULL,
    [CountryId]    BIGINT        NOT NULL,
    [IsActive]     BIT           DEFAULT ((1)) NOT NULL,
    [CreatedBy]    BIGINT        NOT NULL,
    [CreatedOn]    DATETIME2 (7) DEFAULT (getdate()) NULL,
    [ModifiedOn]   DATETIME2 (7) NULL,
    [ModifiedBy]   BIGINT        NULL,
    PRIMARY KEY CLUSTERED ([AddressID] ASC)
);

