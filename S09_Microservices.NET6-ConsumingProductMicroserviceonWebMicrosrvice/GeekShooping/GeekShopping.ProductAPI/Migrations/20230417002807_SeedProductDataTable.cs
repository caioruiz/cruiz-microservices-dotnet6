using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GeekShopping.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductDataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "T-Shirt", "Camiseta geek", "https://static3.tcdn.com.br/img/img_prod/460977/camiseta_masculina_unissex_jogos_classicos_nintendo_video_game_arcade_donkey_kong_sonic_preta_ev_98685_1_ec026f63f3151195828a42c0f48b2e45.jpg", "Camiseta geek jogos", 69.9m },
                    { 3L, "Bone", "Bone geek", "https://static3.tcdn.com.br/img/img_prod/460977/camiseta_masculina_unissex_jogos_classicos_nintendo_video_game_arcade_donkey_kong_sonic_preta_ev_98685_1_ec026f63f3151195828a42c0f48b2e45.jpg", "Bone Super Mario", 49.9m },
                    { 4L, "Book", "Livro geek", "https://static3.tcdn.com.br/img/img_prod/460977/camiseta_masculina_unissex_jogos_classicos_nintendo_video_game_arcade_donkey_kong_sonic_preta_ev_98685_1_ec026f63f3151195828a42c0f48b2e45.jpg", "Livro Sonic", 59.9m },
                    { 5L, "Action Figure", "Boneco geek", "https://static3.tcdn.com.br/img/img_prod/460977/camiseta_masculina_unissex_jogos_classicos_nintendo_video_game_arcade_donkey_kong_sonic_preta_ev_98685_1_ec026f63f3151195828a42c0f48b2e45.jpg", "Logo Nintendo", 69.9m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);
        }
    }
}
