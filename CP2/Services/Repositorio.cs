using System.Text.Json;
using LojaInstrumentos.Models;

namespace LojaInstrumentos.Services;

public static class Repositorio
{
    private static readonly string ArquivoVendas =
        Path.Combine(AppContext.BaseDirectory, "vendas.json");

    public static List<Instrumento> Catalogo { get; } = new()
    {
        new() { Id = 1, Nome = "Violão Acústico",       Categoria = "Cordas",     Preco = 899.90m,  Estoque = 15 },
        new() { Id = 2, Nome = "Guitarra Stratocaster", Categoria = "Cordas",     Preco = 3499.00m, Estoque = 8 },
        new() { Id = 3, Nome = "Baixo 4 Cordas",        Categoria = "Cordas",     Preco = 2799.00m, Estoque = 6 },
        new() { Id = 4, Nome = "Teclado 61 Teclas",     Categoria = "Teclas",     Preco = 1899.00m, Estoque = 10 },
        new() { Id = 5, Nome = "Piano Digital 88",      Categoria = "Teclas",     Preco = 5990.00m, Estoque = 4 },
        new() { Id = 6, Nome = "Bateria Acústica",      Categoria = "Percussão",  Preco = 4590.00m, Estoque = 3 },
        new() { Id = 7, Nome = "Cajón",                 Categoria = "Percussão",  Preco = 349.90m,  Estoque = 20 },
        new() { Id = 8, Nome = "Flauta Doce",           Categoria = "Sopro",      Preco = 59.90m,   Estoque = 40 },
        new() { Id = 9, Nome = "Saxofone Alto",         Categoria = "Sopro",      Preco = 6200.00m, Estoque = 2 },
        new() { Id = 10, Nome = "Ukulele Soprano",      Categoria = "Cordas",     Preco = 399.00m,  Estoque = 12 },
    };

    public static List<Venda> Vendas { get; private set; } = new();

    static Repositorio()
    {
        CarregarVendas();
    }

    public static Venda RegistrarVenda(string cliente, IEnumerable<ItemVenda> itens)
    {
        var venda = new Venda
        {
            Id = Vendas.Count == 0 ? 1 : Vendas.Max(v => v.Id) + 1,
            Data = DateTime.Now,
            Cliente = cliente,
            Itens = itens.ToList()
        };

        foreach (var item in venda.Itens)
        {
            var instrumento = Catalogo.First(i => i.Id == item.InstrumentoId);
            instrumento.Estoque -= item.Quantidade;
        }

        Vendas.Add(venda);
        SalvarVendas();
        return venda;
    }

    private static void CarregarVendas()
    {
        try
        {
            if (!File.Exists(ArquivoVendas)) return;

            var json = File.ReadAllText(ArquivoVendas);
            Vendas = JsonSerializer.Deserialize<List<Venda>>(json) ?? new();

            // Reaplica o estoque já vendido em execuções anteriores
            foreach (var item in Vendas.SelectMany(v => v.Itens))
            {
                var instrumento = Catalogo.FirstOrDefault(i => i.Id == item.InstrumentoId);
                if (instrumento != null)
                    instrumento.Estoque = Math.Max(0, instrumento.Estoque - item.Quantidade);
            }
        }
        catch
        {
            Vendas = new();
        }
    }

    private static void SalvarVendas()
    {
        try
        {
            var json = JsonSerializer.Serialize(Vendas, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ArquivoVendas, json);
        }
        catch
        {
            // Persistência é opcional: a aplicação continua funcionando em memória.
        }
    }
}
