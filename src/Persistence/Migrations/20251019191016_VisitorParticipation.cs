using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class VisitorParticipation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EventParticipants",
                table: "EventParticipants");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "EventParticipants",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<string>(
                name: "VisitorEmail",
                table: "EventParticipants",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VisitorFirstName",
                table: "EventParticipants",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "VisitorId",
                table: "EventParticipants",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VisitorLastName",
                table: "EventParticipants",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventParticipants",
                table: "EventParticipants",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_EventParticipants_EventId",
                table: "EventParticipants",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventParticipants_EventId_UserId",
                table: "EventParticipants",
                columns: new[] { "EventId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventParticipants_EventId_VisitorId",
                table: "EventParticipants",
                columns: new[] { "EventId", "VisitorId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventParticipants_VisitorEmail",
                table: "EventParticipants",
                column: "VisitorEmail");

            migrationBuilder.CreateIndex(
                name: "IX_EventParticipants_VisitorId",
                table: "EventParticipants",
                column: "VisitorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EventParticipants",
                table: "EventParticipants");

            migrationBuilder.DropIndex(
                name: "IX_EventParticipants_EventId",
                table: "EventParticipants");

            migrationBuilder.DropIndex(
                name: "IX_EventParticipants_EventId_UserId",
                table: "EventParticipants");

            migrationBuilder.DropIndex(
                name: "IX_EventParticipants_EventId_VisitorId",
                table: "EventParticipants");

            migrationBuilder.DropIndex(
                name: "IX_EventParticipants_VisitorEmail",
                table: "EventParticipants");

            migrationBuilder.DropIndex(
                name: "IX_EventParticipants_VisitorId",
                table: "EventParticipants");

            migrationBuilder.DropColumn(
                name: "VisitorEmail",
                table: "EventParticipants");

            migrationBuilder.DropColumn(
                name: "VisitorFirstName",
                table: "EventParticipants");

            migrationBuilder.DropColumn(
                name: "VisitorId",
                table: "EventParticipants");

            migrationBuilder.DropColumn(
                name: "VisitorLastName",
                table: "EventParticipants");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "EventParticipants",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventParticipants",
                table: "EventParticipants",
                columns: new[] { "EventId", "UserId" });
        }
    }
}
