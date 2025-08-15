CREATE TABLE [dbo].[tb_Treatment] (
    [TreatmentId]            BIGINT          IDENTITY (1, 1) NOT NULL,
    [AppointmentId]          BIGINT          NOT NULL,
    [DoctorId]               BIGINT          NOT NULL,
    [TreatmentDate]          DATETIME2 (7)   NOT NULL,
    [TreatmentCost]          DECIMAL (10, 2) NOT NULL,
    [TreatmentTime]          TIME (7)        NOT NULL,
    [TreatmentDescription]   VARCHAR (200)   NOT NULL,
    [RecommendedTest]        VARCHAR (500)   NOT NULL,
    [RecommendedPrecautions] VARCHAR (500)   NOT NULL,
    [CreatedByUserId]        BIGINT          NOT NULL,
    [CreatedOn]              DATETIME2 (7)   DEFAULT (getdate()) NOT NULL,
    [ModifiedByUserId]       BIGINT          NOT NULL,
    [ModifiedOn]             DATETIME2 (7)   NOT NULL,
    PRIMARY KEY CLUSTERED ([TreatmentId] ASC)
);

