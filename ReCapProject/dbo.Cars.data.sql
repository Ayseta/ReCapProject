CREATE TABLE [dbo].[Cars] (
    [CarId]       INT           IDENTITY (1, 1) NOT NULL,
    [BrandId]     INT           NOT NULL,
    [ColorId]     INT           NOT NULL,
    [ModelYear]   INT           NULL,
    [DailyPrice]  DECIMAL (18)  NULL,
    [Description] VARCHAR (MAX) NULL,
    [CarName]     NVARCHAR (50) NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED ([CarId] ASC),
    CONSTRAINT [FK_Cars_Brands] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brands] ([BrandId]),
    CONSTRAINT [FK_Cars_Colors] FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Colors] ([ColorId]),
    CONSTRAINT [CK_Cars_DailyPrice] CHECK ([DailyPrice]>(0))
);


GO
CREATE NONCLUSTERED INDEX [BrandId]
    ON [dbo].[Cars]([BrandId] ASC);


GO
CREATE NONCLUSTERED INDEX [ColorId]
    ON [dbo].[Cars]([ColorId] ASC);


GO
CREATE NONCLUSTERED INDEX [BrandsCars]
    ON [dbo].[Cars]([BrandId] ASC);


GO
CREATE NONCLUSTERED INDEX [ColorsCars]
    ON [dbo].[Cars]([ColorId] ASC);

