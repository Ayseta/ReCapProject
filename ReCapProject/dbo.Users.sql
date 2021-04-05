CREATE TABLE [dbo].[Users] (
    [UserId]    INT        IDENTITY (1, 1) NOT NULL,
    [FirstName] NCHAR (10) NOT NULL,
    [LastName]  NCHAR (10) NOT NULL,
    [Email]     NCHAR (40) NOT NULL,
    [Password]  NCHAR (8)  NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId] ASC)
);


GO
CREATE NONCLUSTERED INDEX [UserId]
    ON [dbo].[Users]([UserId] ASC);

