namespace EasyWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'50101599-dcc8-4b27-83af-9cb2a12f8979', N'firstadmin@easyway.com', 0, N'AOJcmi1WfKqnDqclZ/oKmkapQoKKGmJ4GPo2nWmUcEZ1NSylkOslz2Un7KxlixdpjQ==', N'b1408ce4-ea1c-416d-a745-22a64145cb94', NULL, 0, 0, NULL, 1, 0, N'firstadmin@easyway.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'928edc7e-b0e1-4765-a717-c81a9b2ba9db', N'admin@easyway.com', 0, N'AJucg4iyeiGQAD47f/yzycP5Ea4i08hetnGRqHQPCG2TTP4q7OhlNmwp7TnzwnGRlA==', N'539f899d-4bae-4290-a9d9-ff17aa6b3774', NULL, 0, 0, NULL, 1, 0, N'admin@easyway.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e0160c7b-ac15-4bef-a48e-7a7c3ca61d0b', N'guest@easyway.com', 0, N'AP9lqnWDJzPByOj/3xiTx4aSTH4A95W6ZPAtoENYM8lcuv2bMQRBWcOnF8wXccRgKA==', N'0ad5b784-ea5b-4e02-abdc-02ef34aa84e3', NULL, 0, 0, NULL, 1, 0, N'guest@easyway.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'843ce04e-f2b3-40a7-8e1a-e3ed0e4e936c', N'CanManagePackages')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'50101599-dcc8-4b27-83af-9cb2a12f8979', N'843ce04e-f2b3-40a7-8e1a-e3ed0e4e936c')

");
        }
        
        public override void Down()
        {
        }
    }
}
