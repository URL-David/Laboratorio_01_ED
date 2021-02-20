using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Laboratorio_01_Implementación_y_análisis_de_estructuras__lineales.Models.Storage;
using System.Diagnostics;
using System.Threading;
using System.IO;


namespace Laboratorio_01_Implementación_y_análisis_de_estructuras__lineales.Controllers
{
    public class Player : Controller
    {
        public static Stopwatch Time = new Stopwatch();
        static TimeSpan ts;
        public static string elapsedTime;
        // GET: Player
        public ActionResult Index(IFormCollection collection)
        {

            return View(Singleton.Instance.Ljugadores);
        }
        // GET: Player/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Player/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Player/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var newPlayer = new Models.Jugadores
                {
                    Club = collection["Club"],
                    Pos = collection["Pos"],
                    Name = collection["Name"],
                    Surname = collection["Surname"],
                    Salary = Convert.ToInt32(collection["Salary"]),
                };
                Singleton.Instance.Ljugadores.AddLast(newPlayer);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Player/Edit/5
        public ActionResult Edit(String surname)
        {
            var EditPlayer = Singleton.Instance.PlayerList.Find(x => x.Surname == surname);
            return View(EditPlayer);
        }

        // POST: Player/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string surname, IFormCollection collection)
        {
            try
            {
                Time.Restart();
                Time.Start();

                var EditPlayer = Singleton.Instance.PlayerList.Find(x => x.Surname == collection["Surname"]);
                EditPlayer.Club = collection["Club"];
                EditPlayer.Salary = Convert.ToInt32(collection["Salary"]);
                

                Time.Stop();
                ts = Time.Elapsed;
                elapsedTime = String.Format("{0} h, {1} min, {2} s, {3} ms", ts.Hours, ts.Minutes, ts.Seconds, ts.TotalMilliseconds * 1000);
                return RedirectToAction(nameof(VTime));

            }
            catch
            {
                return View();
            }
        }

        // GET: Player/Delete/5
        public ActionResult Delete(string surname)
        {

               var EditPlayer = Singleton.Instance.PlayerList.Find(x => x.Surname == surname);
            Singleton.Instance.PlayerList.Remove(EditPlayer);



            return RedirectToAction(nameof(Index));
        }

        // POST: Player/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string surname, IFormCollection collection)
        {
            try
            {
                Time.Restart();
                Time.Start();


                Time.Stop();
                ts = Time.Elapsed;
                elapsedTime = String.Format("{0} h, {1} min, {2} s, {3} ms", ts.Hours, ts.Minutes, ts.Seconds, ts.TotalMilliseconds * 1000);
                return RedirectToAction(nameof(VTime));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult SelectArc()
        {
            return View();
        }


        [HttpPost]

        public ActionResult SelectArc(IFormCollection Collection)
        {
            try
            {

                Time.Restart();
                Time.Start();
                StreamReader LeerAr = new StreamReader(Collection["xlsx"]);
                var Ajugador = (LeerAr.ReadToEnd().Split('\r'));

                for (int i = 0; i < Ajugador.Length; i++)
                {
                    if (Ajugador[i][0] == '\n')
                    {
                        Ajugador[i] = Ajugador[i].Substring(1);
                    }
                }
                foreach (var AtJugador in Ajugador)
                {
                    var AAtJugador = AtJugador.Split(',');
                    if (AAtJugador[0] != "")
                    {
                        Player Jugador = new Player
                        {
     
                        };
                    }
                }
                Time.Stop();
                ts = Time.Elapsed;
                elapsedTime = String.Format("{0} h, {1} min, {2} s, {3} ms", ts.Hours, ts.Minutes, ts.Seconds, ts.TotalMilliseconds * 1000);
                return RedirectToAction(nameof(VTime));


            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VTime()
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
}
