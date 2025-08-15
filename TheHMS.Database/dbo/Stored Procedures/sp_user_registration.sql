
create proc [dbo].[sp_user_registration]
	@pFirstName varchar(200),
	@pLastName varchar(200),
	@pUserName varchar(10),
	@pEmail varchar(200),
	@pPassword varchar(8),
	@pSaltPassword varchar(max),
	@pMobile nvarchar(10)
   as begin 
   INSERT INTO dbo.tb_mst_User
           ([FirstName]
           ,[LastName]
           ,[UserName]
           ,[Email]
           ,[Password]
           ,HashPassword
           ,Phone
            )
     VALUES(@pFirstName,@pLastName,@pUserName,@pEmail,@pPassword,@pSaltPassword,@pMobile);

select 'success';

end;