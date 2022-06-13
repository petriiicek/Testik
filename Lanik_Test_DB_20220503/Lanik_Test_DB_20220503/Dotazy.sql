CREATE TABLE [dbo].[Faktura] (
    [id]        INT           IDENTITY (1, 1) NOT NULL,
    [datum]     DATE          NOT NULL,
    [cislo]     INT           NOT NULL,
    [odberatel] NVARCHAR (35) NOT NULL,
    [nazev]     NVARCHAR (15) NOT NULL,
    [pocet]     INT           NOT NULL,
    [cena]      FLOAT (50)    NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

INSERT INTO dbo.Faktura VALUES ('21/5/2003', 5555544444, 'Vitus', 'Amogus', 1, 9999)