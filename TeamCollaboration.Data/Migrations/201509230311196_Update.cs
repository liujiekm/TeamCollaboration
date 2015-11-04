namespace TeamCollaboration.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attends",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UId = c.Guid(nullable: false),
                        MId = c.Guid(nullable: false),
                        IsSign = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Meetings", t => t.MId)
                .ForeignKey("dbo.Users", t => t.UId)
                .Index(t => t.UId)
                .Index(t => t.MId);
            
            CreateTable(
                "dbo.Meetings",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Theme = c.String(maxLength: 50),
                        StartTime = c.DateTime(nullable: false),
                        Room = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 100),
                        IsPublic = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Sponsor = c.Guid(nullable: false),
                        ChatRoomId = c.Guid(nullable: false),
                        Code = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ChatRooms", t => t.Id)
                .ForeignKey("dbo.Users", t => t.Sponsor)
                .Index(t => t.Id)
                .Index(t => t.Sponsor);
            
            CreateTable(
                "dbo.ChatRooms",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Sponsor = c.Guid(nullable: false),
                        LaunchTime = c.DateTime(nullable: false),
                        MId = c.Guid(),
                        Theme = c.String(nullable: false, maxLength: 20),
                        Status = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Sponsor)
                .Index(t => t.Sponsor);
            
            CreateTable(
                "dbo.ChatRoomUsers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CId = c.Guid(nullable: false),
                        UId = c.Guid(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ChatRooms", t => t.CId)
                .ForeignKey("dbo.Users", t => t.UId)
                .Index(t => t.CId)
                .Index(t => t.UId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 20),
                        Phone = c.String(maxLength: 15),
                        Mail = c.String(nullable: false, maxLength: 50),
                        Code = c.String(nullable: false, maxLength: 20),
                        Enable = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Boards",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Author = c.Guid(nullable: false),
                        PublishTime = c.DateTime(nullable: false),
                        Title = c.String(maxLength: 20),
                        Content = c.String(nullable: false, maxLength: 100),
                        Code = c.String(nullable: false, maxLength: 20),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Author)
                .Index(t => t.Author);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SendTime = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        FromId = c.Guid(nullable: false),
                        CId = c.Guid(),
                        ToId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ChatRooms", t => t.CId)
                .ForeignKey("dbo.Users", t => t.FromId)
                .ForeignKey("dbo.Users", t => t.ToId)
                .Index(t => t.FromId)
                .Index(t => t.CId)
                .Index(t => t.ToId);
            
            CreateTable(
                "dbo.Notices",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SendTime = c.DateTime(nullable: false),
                        Title = c.String(maxLength: 50),
                        Content = c.String(nullable: false, maxLength: 200),
                        Path = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        IsRead = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 20),
                        MId = c.Guid(),
                        TId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Meetings", t => t.MId)
                .ForeignKey("dbo.Tasks", t => t.TId)
                .Index(t => t.MId)
                .Index(t => t.TId);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Sponsor = c.Guid(nullable: false),
                        Description = c.String(maxLength: 100),
                        WorkHours = c.Single(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Priority = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Sponsor)
                .Index(t => t.Sponsor);
            
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FileName = c.String(nullable: false, maxLength: 50),
                        UploadTime = c.DateTime(nullable: false),
                        Description = c.String(maxLength: 50),
                        Path = c.String(nullable: false, maxLength: 50),
                        Code = c.String(nullable: false, maxLength: 20),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Dictionaries",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FoldName = c.String(nullable: false, maxLength: 20),
                        Code = c.String(nullable: false, maxLength: 20),
                        Status = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Dictionary_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dictionaries", t => t.Dictionary_Id)
                .Index(t => t.Dictionary_Id);
            
            CreateTable(
                "dbo.FileInDictionary",
                c => new
                    {
                        FId = c.Guid(nullable: false),
                        DId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.FId, t.DId })
                .ForeignKey("dbo.Files", t => t.FId, cascadeDelete: true)
                .ForeignKey("dbo.Dictionaries", t => t.DId, cascadeDelete: true)
                .Index(t => t.FId)
                .Index(t => t.DId);
            
            CreateTable(
                "dbo.MeetingToFile",
                c => new
                    {
                        FId = c.Guid(nullable: false),
                        MId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.FId, t.MId })
                .ForeignKey("dbo.Files", t => t.FId, cascadeDelete: true)
                .ForeignKey("dbo.Meetings", t => t.MId, cascadeDelete: true)
                .Index(t => t.FId)
                .Index(t => t.MId);
            
            CreateTable(
                "dbo.TaskToFile",
                c => new
                    {
                        FId = c.Guid(nullable: false),
                        TId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.FId, t.TId })
                .ForeignKey("dbo.Files", t => t.FId, cascadeDelete: true)
                .ForeignKey("dbo.Tasks", t => t.TId, cascadeDelete: true)
                .Index(t => t.FId)
                .Index(t => t.TId);
            
            CreateTable(
                "dbo.NoticeToUser",
                c => new
                    {
                        UId = c.Guid(nullable: false),
                        NId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.UId, t.NId })
                .ForeignKey("dbo.Users", t => t.UId, cascadeDelete: true)
                .ForeignKey("dbo.Notices", t => t.NId, cascadeDelete: true)
                .Index(t => t.UId)
                .Index(t => t.NId);
            
            CreateTable(
                "dbo.Assign",
                c => new
                    {
                        UId = c.Guid(nullable: false),
                        TId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.UId, t.TId })
                .ForeignKey("dbo.Users", t => t.UId, cascadeDelete: true)
                .ForeignKey("dbo.Tasks", t => t.TId, cascadeDelete: true)
                .Index(t => t.UId)
                .Index(t => t.TId);
            
            CreateTable(
                "dbo.UserHaveDictionary",
                c => new
                    {
                        UId = c.Guid(nullable: false),
                        DId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.UId, t.DId })
                .ForeignKey("dbo.Users", t => t.UId, cascadeDelete: true)
                .ForeignKey("dbo.Dictionaries", t => t.DId, cascadeDelete: true)
                .Index(t => t.UId)
                .Index(t => t.DId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attends", "UId", "dbo.Users");
            DropForeignKey("dbo.Attends", "MId", "dbo.Meetings");
            DropForeignKey("dbo.Meetings", "Sponsor", "dbo.Users");
            DropForeignKey("dbo.Meetings", "Id", "dbo.ChatRooms");
            DropForeignKey("dbo.ChatRooms", "Sponsor", "dbo.Users");
            DropForeignKey("dbo.ChatRoomUsers", "UId", "dbo.Users");
            DropForeignKey("dbo.UserHaveDictionary", "DId", "dbo.Dictionaries");
            DropForeignKey("dbo.UserHaveDictionary", "UId", "dbo.Users");
            DropForeignKey("dbo.Assign", "TId", "dbo.Tasks");
            DropForeignKey("dbo.Assign", "UId", "dbo.Users");
            DropForeignKey("dbo.NoticeToUser", "NId", "dbo.Notices");
            DropForeignKey("dbo.NoticeToUser", "UId", "dbo.Users");
            DropForeignKey("dbo.Notices", "TId", "dbo.Tasks");
            DropForeignKey("dbo.TaskToFile", "TId", "dbo.Tasks");
            DropForeignKey("dbo.TaskToFile", "FId", "dbo.Files");
            DropForeignKey("dbo.MeetingToFile", "MId", "dbo.Meetings");
            DropForeignKey("dbo.MeetingToFile", "FId", "dbo.Files");
            DropForeignKey("dbo.FileInDictionary", "DId", "dbo.Dictionaries");
            DropForeignKey("dbo.FileInDictionary", "FId", "dbo.Files");
            DropForeignKey("dbo.Dictionaries", "Dictionary_Id", "dbo.Dictionaries");
            DropForeignKey("dbo.Tasks", "Sponsor", "dbo.Users");
            DropForeignKey("dbo.Notices", "MId", "dbo.Meetings");
            DropForeignKey("dbo.Messages", "ToId", "dbo.Users");
            DropForeignKey("dbo.Messages", "FromId", "dbo.Users");
            DropForeignKey("dbo.Messages", "CId", "dbo.ChatRooms");
            DropForeignKey("dbo.Boards", "Author", "dbo.Users");
            DropForeignKey("dbo.ChatRoomUsers", "CId", "dbo.ChatRooms");
            DropIndex("dbo.UserHaveDictionary", new[] { "DId" });
            DropIndex("dbo.UserHaveDictionary", new[] { "UId" });
            DropIndex("dbo.Assign", new[] { "TId" });
            DropIndex("dbo.Assign", new[] { "UId" });
            DropIndex("dbo.NoticeToUser", new[] { "NId" });
            DropIndex("dbo.NoticeToUser", new[] { "UId" });
            DropIndex("dbo.TaskToFile", new[] { "TId" });
            DropIndex("dbo.TaskToFile", new[] { "FId" });
            DropIndex("dbo.MeetingToFile", new[] { "MId" });
            DropIndex("dbo.MeetingToFile", new[] { "FId" });
            DropIndex("dbo.FileInDictionary", new[] { "DId" });
            DropIndex("dbo.FileInDictionary", new[] { "FId" });
            DropIndex("dbo.Dictionaries", new[] { "Dictionary_Id" });
            DropIndex("dbo.Tasks", new[] { "Sponsor" });
            DropIndex("dbo.Notices", new[] { "TId" });
            DropIndex("dbo.Notices", new[] { "MId" });
            DropIndex("dbo.Messages", new[] { "ToId" });
            DropIndex("dbo.Messages", new[] { "CId" });
            DropIndex("dbo.Messages", new[] { "FromId" });
            DropIndex("dbo.Boards", new[] { "Author" });
            DropIndex("dbo.ChatRoomUsers", new[] { "UId" });
            DropIndex("dbo.ChatRoomUsers", new[] { "CId" });
            DropIndex("dbo.ChatRooms", new[] { "Sponsor" });
            DropIndex("dbo.Meetings", new[] { "Sponsor" });
            DropIndex("dbo.Meetings", new[] { "Id" });
            DropIndex("dbo.Attends", new[] { "MId" });
            DropIndex("dbo.Attends", new[] { "UId" });
            DropTable("dbo.UserHaveDictionary");
            DropTable("dbo.Assign");
            DropTable("dbo.NoticeToUser");
            DropTable("dbo.TaskToFile");
            DropTable("dbo.MeetingToFile");
            DropTable("dbo.FileInDictionary");
            DropTable("dbo.Dictionaries");
            DropTable("dbo.Files");
            DropTable("dbo.Tasks");
            DropTable("dbo.Notices");
            DropTable("dbo.Messages");
            DropTable("dbo.Boards");
            DropTable("dbo.Users");
            DropTable("dbo.ChatRoomUsers");
            DropTable("dbo.ChatRooms");
            DropTable("dbo.Meetings");
            DropTable("dbo.Attends");
        }
    }
}
