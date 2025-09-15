namespace Pokedex.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) 
        : base(opt)
        {

        }

        public class DbSet<Genero> Generos { get; set;}

        public class DbSet<Pokemon> Pokemon { get; set;}
        
        public class DbSet<PokemonTipo> PokemonTipo { get; set;}

        public class DbSet<Regiao> Generos { get; set;}

        public class DbSet<Tipo> Generos { get; set;}

        protected override void onModelCreating(ModelBuilder ModelBuilder);
        {
            base.onModelCreating(ModelBuilder);
            ModelBuilder.Entity<PokemonTipo>()
            Haskey(pt => new {pt.PokemonNumero, pt.TipoId})
        }

        public int MyProperty { get; set; }
        
    }
}