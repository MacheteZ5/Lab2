using Lab1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MostrarJuegos(string NOMBRE, string cat, string Estudio)
        {
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            Juegos juego1 = new Juegos() { Id = 1, nombre = "Super Meat Boy", año = 2010, categoria = "Arcade", estudio = "Estudio", puntuacion = 3 };
            if (NOMBRE != null)
            {
                juego1.nombre = NOMBRE;
            }
            TimeSpan stop = new TimeSpan(DateTime.Now.Ticks);
            string resultado = "Esto tarda " + (stop.TotalMilliseconds - start.TotalMilliseconds) + " Milisegundos";
            juego1.resultadoTiempo = resultado;
            Process currentProcces = Process.GetCurrentProcess();
            if (cat != null)
            {
                juego1.categoria = cat;
            }
            string pid = "El PID es " + currentProcces.Id.ToString();
            juego1.resultadoTiempoPID = pid;
            if (Estudio != null)
            {
                juego1.estudio = Estudio;
            }
            return View(juego1);
        }



        public ActionResult Parte1(int ID, string NOMBRE, string cat, string Estudio)
        {
            Juegos opc = opciones[ID];
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            TimeSpan stop = new TimeSpan(DateTime.Now.Ticks);
            string resultado = "Esto tarda " + (stop.TotalMilliseconds - start.TotalMilliseconds) + " Milisegundos";
            Process currentProcces = Process.GetCurrentProcess();
            string pid = "El PID es " + currentProcces.Id.ToString();
            opc.resultadoTiempoPID = pid;
            opc.resultadoTiempo = resultado;
            if (NOMBRE != null)
            {
                opc.nombre = NOMBRE;
            }
            else
            {
                if (cat != null)
                {
                    opc.categoria = cat;
                }
                else
                {
                    if (Estudio != null)
                    {
                        opc.estudio = Estudio;
                    }
                }
            }
            return View(opc);
        }
        List<Juegos> opciones = new List<Juegos>();
        public GamesController()
        {
            Juegos acción = new Juegos();
            acción.Id = 2;
            acción.nombre = "Super Meat Boy";
            acción.año = 2010;
            acción.categoria = "Arcade";
            acción.estudio = "Estudio";
            acción.puntuacion = 2;
            opciones.Add(acción);

            Juegos amor = new Juegos();
            amor.Id = 3;
            amor.nombre = "Call of Duty";
            amor.año = 2014;
            amor.categoria = "Action";
            amor.estudio = "Infinity ward";
            amor.puntuacion = 1;
            opciones.Add(amor);

            Juegos Terror = new Juegos();
            Terror.Id = 1;
            Terror.nombre = "Resident Evil";
            Terror.año = 2008;
            Terror.categoria = "Terror";
            Terror.estudio = "Capcom";
            Terror.puntuacion = 2;
            opciones.Add(Terror);
        }
    }
}