using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext 
    {
        public MySQLContext() {}

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Camiseta geek jogos",
                Price = new decimal(69.9),
                Description = "Camiseta geek",
                ImageURL = "https://static3.tcdn.com.br/img/img_prod/460977/camiseta_masculina_unissex_jogos_classicos_nintendo_video_game_arcade_donkey_kong_sonic_preta_ev_98685_1_ec026f63f3151195828a42c0f48b2e45.jpg",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Bone Super Mario",
                Price = new decimal(49.9),
                Description = "Bone geek",
                ImageURL = "https://static3.tcdn.com.br/img/img_prod/460977/camiseta_masculina_unissex_jogos_classicos_nintendo_video_game_arcade_donkey_kong_sonic_preta_ev_98685_1_ec026f63f3151195828a42c0f48b2e45.jpg",
                CategoryName = "Bone"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Livro Sonic",
                Price = new decimal(59.9),
                Description = "Livro geek",
                ImageURL = "https://static3.tcdn.com.br/img/img_prod/460977/camiseta_masculina_unissex_jogos_classicos_nintendo_video_game_arcade_donkey_kong_sonic_preta_ev_98685_1_ec026f63f3151195828a42c0f48b2e45.jpg",
                CategoryName = "Book"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Logo Nintendo",
                Price = new decimal(69.9),
                Description = "Boneco geek",
                ImageURL = "https://static3.tcdn.com.br/img/img_prod/460977/camiseta_masculina_unissex_jogos_classicos_nintendo_video_game_arcade_donkey_kong_sonic_preta_ev_98685_1_ec026f63f3151195828a42c0f48b2e45.jpg",
                CategoryName = "Action Figure"
            });
        }

    }
}
