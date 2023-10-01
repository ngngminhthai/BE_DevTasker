using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Capstone.DataAccess.Migrations
{
    public partial class UpdateAttachmentConstrain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_Tickets_AttachmentId",
                table: "Attachments");

            migrationBuilder.RenameColumn(
                name: "WorkItemId",
                table: "Attachments",
                newName: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_TicketId",
                table: "Attachments",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_Tickets_TicketId",
                table: "Attachments",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "TicketId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_Tickets_TicketId",
                table: "Attachments");

            migrationBuilder.DropIndex(
                name: "IX_Attachments_TicketId",
                table: "Attachments");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "Attachments",
                newName: "WorkItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_Tickets_AttachmentId",
                table: "Attachments",
                column: "AttachmentId",
                principalTable: "Tickets",
                principalColumn: "TicketId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
