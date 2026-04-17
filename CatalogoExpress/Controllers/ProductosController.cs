using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CatalogoExpress.Models;

namespace CatalogoExpress.Controllers;

public class ProductosController : Controller
{
    public IActionResult Index(){
        Catalogo catalogo = new Catalogo();
        ViewBag.Productos = catalogo.ObtenerProductos();

        return View();
    }

    public IActionResult Detalle(string nombre){
        //TODO 2:
        // - Crear un Catalogo
        // - Obtener el Producto por su nombre
        // - Si el nombre viene vacio/null o no existe -> View de no encontrado
        // - Si existe se muestra la view con su información
        Catalogo catalogo = new Catalogo();
        ViewBag.item = catalogo.ObtenerProductoPorNombre(nombre);

        if(String.IsNullOrWhiteSpace(nombre))
        {
            return RedirectToAction("NoEncontrado", "Productos");
        }
        else{
            return View();
        }

     }
}
