using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GranStore.Models;

namespace GranStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
       Categoria categoria2 = new()
        {
           new Categoria {Id = 1, Nome = "Instrumentos sinfonicos"},
           new Categoria {Id = 2, Nome = "Teclas e eletronicos"},
           new Categoria{Id = 3, Nome = "Cordas não sinfonicos"}

        };

        List<Produto> produtos = [
            new() {
                Id = 1,
                Categoria = categoria[1],
                Nome = "Violino Giannini",
                Descricao = "Violino Giannini acústico 4/4, ideal para iniciantes e estudantes, com acabamento envernizado e som equilibrado.",
                ValorCusto = 400,
                ValorVenda = 559,
                QtdeEstoque = 25,
                Foto = "/img/produtos/1.jpg"
            },
            new() {
                Id = 2,
                Categoria = categoria[1],
                Nome = "Tuba Sinônica 4/4 Michael",
                Descricao = "Tuba Sinfônica 4/4 Michael, instrumento de sopro robusto com timbre encorpado, ideal para bandas e orquestras.",
                ValorCusto = 8000,
                ValorVenda = 10500,
                QtdeEstoque = 5,
                Foto = "/img/produtos/2.jpg"
            },
            new() {
                Id = 3,
                Categoria = categoria[1],
                Nome = "Clarinete Yamaha YCL 255",
                Descricao = "Clarinete Yamaha YCL 255, modelo em resina ABS com afinação precisa e ótima resposta, ideal para estudantes e músicos intermediários.",
                ValorCusto = 3570,
                ValorVenda = 4769,
                QtdeEstoque = 12,
                Foto = "/img/produtos/3.jpg"
            },
            new() {
                Id = 4,
                Categoria = categoria[1],
                Nome = "Saxofone Alto Yamaha YAS 280",
                Descricao = "Saxofone Alto Yamaha YAS-280, leve e de fácil resposta, ideal para iniciantes que buscam qualidade sonora e durabilidade.",
                ValorCusto = 1850,
                ValorVenda = 2534,
                QtdeEstoque = 18,
                Foto = "/img/produtos/4.jpg"
            },
            new() {
                Id = 5,
                Categoria = categoria[2],
                Nome = "Órgão Eletrônico Rohnes Rs 40 – Completo",
                Descricao = "Órgão Eletrônico Rohnes RS 40 completo, com dois teclados, pedaleira, vários timbres e ritmos, Bluetooth e efeitos para tocar diversos estilos.",
                ValorCusto = 3200,
                ValorVenda = 4890,
                QtdeEstoque = 2,
                Foto = "/img/produtos/5.jpg"
            },
            new() {
                Id = 6,
                Categoria = categoria[2],
                Nome = "Teclado Yamaha PSR SX720",
                Descricao = "Teclado Yamaha PSR-SX720, com 61 teclas, muitos sons, ritmos e gravação, perfeito para quem quer versatilidade e fácil uso.",
                ValorCusto = 10000,
                ValorVenda = 12500,
                QtdeEstoque = 7,
                Foto = "/img/produtos/6.jpg"
            },
            new() {
                Id = 7,
                Categoria = categoria[3],
                Nome = " Guitarra Elétrica Queen's 6 Cordas D137561 Vermelha",
                Descricao = "Guitarra elétrica Queen's 6 cordas vermelha, ideal para iniciantes, com som versátil e acabamento clássico.",
                ValorCusto = 460,
                ValorVenda = 570,
                QtdeEstoque = 30,
                Foto = "/img/produtos/7.jpg"
            },
            new() {
                Id = 8,
                Categoria = categoria[3],
                Nome = "Violão Acústico Nylon GNA-111 Harmonics",
                Descricao = "Violão acústico nylon GNA-111 Harmonics, ideal para iniciantes, com som suave e acabamento básico.",
                ValorCusto = 180,
                ValorVenda = 220,
                QtdeEstoque = 40,
                Foto = "/img/produtos/8.jpg"
            },

        ];

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
