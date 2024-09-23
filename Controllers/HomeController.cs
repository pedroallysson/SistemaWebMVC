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
        Cliente cliente1 = new Cliente(01, "Pedro Alysson", "04409597352", "pedro@hotmail.com", "Lili");
        Cliente cliente2 = new Cliente(02, "Michele Silva", "04409597351", "michele@hotmail.com", "Lilica");
        Cliente cliente3 = new Cliente(03, "Andrea Layla", "04409597353", "andrea@hotmail.com", "Marley");
        Cliente cliente4 = new Cliente(04, "Andreson Ramos", "04409597354", "pedro@hotmail.com", "Popó");
        Cliente cliente5 = new Cliente(05, "Ila Maria", "04409597355", "pedro@hotmail.com", "Latifa");


        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01,"C# PET S/A", "14.182.102/0001-80", "c-sharp@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02,"Ctrl Alt Dog", "15.182.102/0001-80", "ctrl-alt-dog@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03,"BootsPet INC", "16.182.102/0001-80", "bootspet@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04,"Tik Tok Dogs", "17.182.102/0001-80", "tiktok-dogs@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05,"Bifinho Forever", "18.182.102/0001-80", "bifinho@gmail.com");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;


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
