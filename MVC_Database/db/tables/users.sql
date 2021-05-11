CREATE TABLE [dbo].[users]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [userName] NCHAR(100) NOT NULL,
    [firstName] NCHAR(50) NOT NULL, 
    [lastName] NCHAR(50) NOT NULL, 
    [email] NCHAR(100) NOT NULL, 
    [confirmEmail] NCHAR(100) NOT NULL, 
    [password] NCHAR(50) NOT NULL, 
    [confirmPassword] NCHAR(50) NOT NULL
    
)
