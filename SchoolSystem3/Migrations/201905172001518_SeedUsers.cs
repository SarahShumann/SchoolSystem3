namespace SchoolSystem3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4f5ed39e-50cf-4478-9a98-916f07b58d9a', N'admin@springfield.edu.lb', 0, N'AHj0p+LX5h6ZK77vyejjdXE7bVwDEfLdOuOQtPtY3nR7z2wMlvgf9FuIac2LRUoU4Q==', N'07499bda-583c-4596-a172-c3a6447d35b7', NULL, 0, 0, NULL, 1, 0, N'admin@springfield.edu.lb')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cf1c25b3-0bb2-4bda-8d6a-c475867e3dfb', N'guest1@springfield.edu.lb', 0, N'AGvC7fOdx8PWC6yO6oKEsutqqm6oIm0kuNnEGvHf2DOKMEGLC1mcGzr7v8XQI2XDeQ==', N'f9597f6d-7e7a-4d7e-b6ba-000b5897f324', NULL, 0, 0, NULL, 1, 0, N'guest1@springfield.edu.lb')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'88800567-f846-4598-818e-3433362493d6', N'CanManagePage')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4f5ed39e-50cf-4478-9a98-916f07b58d9a', N'88800567-f846-4598-818e-3433362493d6')

");
        }
        
        public override void Down()
        {
        }
    }
}
