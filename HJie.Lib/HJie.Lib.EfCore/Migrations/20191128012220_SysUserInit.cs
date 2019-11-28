using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HJie.Lib.EfCore.Migrations
{
    public partial class SysUserInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sys_User",
                columns: table => new
                {
                    SysUserId = table.Column<string>(maxLength: 32, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateUser = table.Column<string>(maxLength: 32, nullable: true),
                    Status = table.Column<int>(nullable: true),
                    Sort = table.Column<int>(nullable: true),
                    Remark = table.Column<string>(maxLength: 200, nullable: true),
                    UserName = table.Column<string>(maxLength: 32, nullable: false),
                    Password = table.Column<string>(maxLength: 255, nullable: true),
                    TrueName = table.Column<string>(maxLength: 32, nullable: true),
                    NikeName = table.Column<string>(maxLength: 32, nullable: true),
                    Mobile = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    QQ = table.Column<string>(maxLength: 200, nullable: true),
                    WX = table.Column<string>(maxLength: 200, nullable: true),
                    Avatar = table.Column<string>(maxLength: 255, nullable: true),
                    Sex = table.Column<string>(maxLength: 1, nullable: true),
                    UserType = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_User", x => x.SysUserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sys_User");
        }
    }
}
