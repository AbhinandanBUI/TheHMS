CREATE TABLE [dbo].[tb_Hospital] (
    [HospitalId]       BIGINT        IDENTITY (1, 1) NOT NULL,
    [HospitalName]     VARCHAR (50)  NULL,
    [AddressId]        BIGINT        NULL,
    [RegistrationDate] DATETIME2 (7) NULL,
    [Description]      VARCHAR (50)  NULL,
    [Timing]           VARCHAR (50)  NULL,
    [Phone]            NUMERIC (18)  NULL,
    [Email]            VARCHAR (50)  NULL,
    [Website]          VARCHAR (50)  NULL,
    [Status]           BIT           CONSTRAINT [DF__tb_Hospit__Statu__4D94879B] DEFAULT ((1)) NOT NULL,
    [CreatedByUserId]  BIGINT        NOT NULL,
    [CreatedOn]        DATETIME2 (7) CONSTRAINT [DF__tb_Hospit__Creat__4E88ABD4] DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserId] BIGINT        NOT NULL,
    [ModifiedOn]       DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK__tb_Hospi__38C2E5AF97E16EFE] PRIMARY KEY CLUSTERED ([HospitalId] ASC)
);

