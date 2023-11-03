using Microsoft.AspNetCore.Mvc;
using ProyectoReservas.Data.Models;
using ProyectoReservas.Data.Repositories;

namespace ProyectoReservas.Web.Controllers;

public class UsuariosController : Controller
{

    private IUsuariosCollection db = new UsuariosCollection();
   
    public ActionResult Index()
    {
        return View();
    }

   
    public ActionResult Details(int id)
    {
        return View();
    }

  
    public ActionResult Crear()
    {
        return View();
    }

    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Crear(IFormCollection collection)
    {
        try
        {
            var usuario = new Usuario()
            {
                Nombre = collection["Nombre"]
            };
            db.Crear(usuario);
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

  
    public ActionResult Edit(int id)
    {
        return View();
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }


    public ActionResult Delete(int id)
    {
        return View();
    }

   
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }




}
