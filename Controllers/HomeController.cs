using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente = new Cliente(01, "thiago", "123","email", "pet");
        List<Cliente> clientes = new List<Cliente>();
        clientes.Add(cliente);
        ViewBag.clientes = clientes;

        Fornecedor fornecedor = new Fornecedor(01, "nome", "cnpj", "mail");
        List<Fornecedor> fornecedores = new List<Fornecedor>();
        fornecedores.Add(fornecedor);
        ViewBag.fornecedores = fornecedores;
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
