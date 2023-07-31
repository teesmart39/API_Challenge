using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FruitAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "694934ad-8e27-4323-b14b-b1e1916b9dee", "ADMIN", "AQAAAAIAAYagAAAAEEMgLUrpgx13MlE6FWy7xSmzL2KUZWMHL0IcSXrGLm8cDHKG5ywgjEBwLs6CES59wQ==", "63ef96c2-844c-4a57-afe4-92f902e3f4ce", "Admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f71a2a00-cd7a-48eb-bd47-ad4e6f080d3d", "BACKOFFICE", "AQAAAAIAAYagAAAAEBGIGIUtVAwDWnloZF6HyhpKRdCgjUYpZZo5fCO/XOb1s0wyFBxFylWkd/007h3+gA==", "3eba9bd0-132a-44db-a102-cdcac687a8fb", "BackOffice" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e5399191-9779-4a96-9ce3-3ad82fe2fac9", "FRONTOFFICE", "AQAAAAIAAYagAAAAEE9O+/UoHKlfYnXla7tN8fT4kG21mBlChoSJbxVVzwsvAwmgaffMHxU0fXHAeQlQ4A==", "b92cb225-54a6-465d-912b-302ee94e1087", "FrontOffice" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2eec09ca-9cae-4fb2-907a-8246e1bbf8dd", "ADMINUSER", "AQAAAAIAAYagAAAAEIpfleD0nCm7G7xBKuOHYcv2qxm/Y4GlPJG92oyr4wfP1vpQpHgKhN/c/ttMOlswMg==", "5c12b709-accb-422e-9aa0-945ba7a6d17f", "AdminUser" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "32ceefa3-2790-49a9-bb52-1a79e53b4e69", "BACKOFFICEUSER", "AQAAAAIAAYagAAAAEBqptjFwE4hETCT8R8+lJw/5pHyiNia3fqSr6l3bZrB005x8Skcp5NYDL+ib0eJdng==", "cc3a1c92-11df-483d-af47-3f7587c47bf6", "BackOfficeUser" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "da8f319b-0415-4b68-8b7f-0ed4b6fdfc5f", "FRONTOFFICEUSER", "AQAAAAIAAYagAAAAEFBlW7Y1rC3Vsi4x5c+z5Z3kHVoAlj9+UUqefEXSlM1bQdtm73gnG6B+oiniStQRiw==", "47c7e9d7-a00a-408e-834b-24d765fd1f2a", "FrontOfficeUser" });
        }
    }
}
