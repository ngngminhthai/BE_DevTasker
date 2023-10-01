using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Capstone.DataAccess.Migrations
{
    public partial class UpdateEntityMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_Tickets_AttachmentId",
                table: "Attachments");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_Tickets_AttachmentId",
                table: "Attachments",
                column: "AttachmentId",
                principalTable: "Tickets",
                principalColumn: "TicketId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_Tickets_AttachmentId",
                table: "Attachments");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_Tickets_AttachmentId",
                table: "Attachments",
                column: "AttachmentId",
                principalTable: "Tickets",
                principalColumn: "TicketId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
