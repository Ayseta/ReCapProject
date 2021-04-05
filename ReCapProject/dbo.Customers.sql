CREATE TABLE [dbo].[Customers] (
    [CustomerId]  INT           IDENTITY (1, 1) NOT NULL,
    [UserId]      INT           NOT NULL,
    [CompanyName] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_CustomerId] PRIMARY KEY CLUSTERED ([CustomerId] ASC),
    CONSTRAINT [FK_Customers_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

GO
CREATE NONCLUSTERED INDEX [UserId]
    ON [dbo].[Customers]([UserId] ASC);
	GO
CREATE NONCLUSTERED INDEX [UsersCustomers]
    ON [dbo].[Customers]([UserId] ASC);

