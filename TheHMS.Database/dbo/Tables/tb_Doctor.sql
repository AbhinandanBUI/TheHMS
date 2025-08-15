CREATE TABLE [dbo].[tb_Doctor] (
    [DoctorId]             BIGINT        IDENTITY (1, 1) NOT NULL,
    [Qualification]        VARCHAR (50)  NOT NULL,
    [Experience]           NUMERIC (18)  NULL,
    [Specialization]       VARCHAR (50)  NOT NULL,
    [HospitalId]           BIGINT        NULL,
    [PreviousHospitalName] VARCHAR (100) NOT NULL,
    [Details]              VARCHAR (50)  NOT NULL,
    [CreatedByUserId]      BIGINT        NOT NULL,
    [CreatedOn]            DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserId]     BIGINT        NOT NULL,
    [ModifiedOn]           DATETIME2 (7) NOT NULL,
    PRIMARY KEY CLUSTERED ([DoctorId] ASC),
    CONSTRAINT [FK_tb_Doctor_tb_Hospital] FOREIGN KEY ([HospitalId]) REFERENCES [dbo].[tb_Hospital] ([HospitalId]),
    CONSTRAINT [FK_tb_Doctor_tb_mst_User] FOREIGN KEY ([CreatedByUserId]) REFERENCES [dbo].[tb_mst_User] ([UserID])
);

