CREATE TABLE [dbo].[Rentals] (
    [RentalId]   INT      IDENTITY (1, 1) NOT NULL,
    [CarId]      INT      NOT NULL,
    [CustomerId] INT      NOT NULL,
    [RentDate]   DATETIME NOT NULL,
    [ReturnDate] DATETIME NULL,
    CONSTRAINT [PK_RentalId] PRIMARY KEY CLUSTERED ([RentalId] ASC),
    CONSTRAINT [FK_Rental_Cars] FOREIGN KEY ([CarId]) REFERENCES [dbo].[Cars] ([CarId]),
    CONSTRAINT [FK_Rental_Customers] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId])
);

