using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CatalogoExpress.Models;

namespace CatalogoExpress.Controllers;

public class ProductosController : Controller
{
    public IActionResult Index(){
        //TODO 1:
        // - Crear un Catalogo
        // - Obtener la lista de Productos del catalogo
        // - Pasarla a la view usando Model

        return View();
    }

    public IActionResult Detalle(string nombre){
        //TODO 2:
        // - Crear un Catalogo
        // - Obtener el Producto por su nombre
        // - Si el nombre viene vacio/null o no existe -> View de no encontrado
        // - Si existe se muestra la view con su información

        return View();
     }
}
