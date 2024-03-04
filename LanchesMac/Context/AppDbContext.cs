using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Context;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
    {
        //ESTA CLASSE DEFINE AS OPÇÕES A SEREM USADAS PELO DBCONTEXT E IRÁ CARREGAR INFORMAÇÕES DE CONFIGURAÇÕES NECESSARIAS PARA CONFIGURAR O DBCONTEXT

    }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Lanche> Lanches { get; set; }
    public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

}
