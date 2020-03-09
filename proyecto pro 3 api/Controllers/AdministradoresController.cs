using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using proyecto_pro_3_api.Models;

namespace proyecto_pro_3_api.Controllers
{
    public class AdministradoresController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Administradores
        public ActionResult Index()
        {
            return View(db.Administradores.ToList());
        }

        // GET: Administradores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administradore administradore = db.Administradores.Find(id);
            if (administradore == null)
            {
                return HttpNotFound();
            }
            return View(administradore);
        }

        // GET: Administradores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administradores/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Documento,Nombre,Apellido,Carrera,Egresado,Cargo,Edad,Usuario,Clave")] Administradore administradore)
        {
            if (ModelState.IsValid)
            {
                db.Administradores.Add(administradore);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(administradore);
        }

        // GET: Administradores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administradore administradore = db.Administradores.Find(id);
            if (administradore == null)
            {
                return HttpNotFound();
            }
            return View(administradore);
        }

        // POST: Administradores/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Documento,Nombre,Apellido,Carrera,Egresado,Cargo,Edad,Usuario,Clave")] Administradore administradore)
        {
            if (ModelState.IsValid)
            {
                db.Entry(administradore).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administradore);
        }

        // GET: Administradores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administradore administradore = db.Administradores.Find(id);
            if (administradore == null)
            {
                return HttpNotFound();
            }
            return View(administradore);
        }

        // POST: Administradores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Administradore administradore = db.Administradores.Find(id);
            db.Administradores.Remove(administradore);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

       

        public ActionResult indexDocentes()
        {
            return View(db.Docentes.ToList());
        }

        //Administrador
        public ActionResult DetailsAdministradores(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administradore administradore = db.Administradores.Find(id);
            if (administradore == null)
            {
                return HttpNotFound();
            }
            return View(administradore);
        }

        //Estudiante 
        public ActionResult DetailsEstudiante(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudiante estudiante = db.Estudiantes.Find(id);
            if (estudiante == null)
            {
                return HttpNotFound();
            }
            return View(estudiante);
        }

        //Docente
        public ActionResult DetailsDocente(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Docente docente = db.Docentes.Find(id);
            if (docente == null)
            {
                return HttpNotFound();
            }
            return View(docente);
        }

        public ActionResult CreateAdministradores()
        {
            return View();
        }
        // POST: Administrador/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAdministradores([Bind(Include = "ID,Correo")] Administradore administradore)
        {
            if (ModelState.IsValid)
            {
                db.Administradores.Add(administradore);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administradore);
        }

        public ActionResult EditAdministradores(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administradore administradore = db.Administradores.Find(id);
            if (administradore == null)
            {
                return HttpNotFound();
            }
            return View(administradore);
        }
        public ActionResult EditEstudiante(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudiante estudiante = db.Estudiantes.Find(id);
            if (estudiante == null)
            {
                return HttpNotFound();
            }
            return View(estudiante);
        }

        public ActionResult EditDocente(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Docente docente = db.Docentes.Find(id);
            if (docente == null)
            {
                return HttpNotFound();
            }
            return View(docente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditAdministradores([Bind(Include = "ID,Correo")] Administradore administradore)
        {
            if (ModelState.IsValid)
            {
                db.Entry(administradore).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administradore);
        }
        public ActionResult DeleteAdministradores(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administradore administradore = db.Administradores.Find(id);
            if (administradore == null)
            {
                return HttpNotFound();
            }
            return View(administradore);
        }
        // POST: Administrador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmedAdmin(int id)
        {
            Administradore administradore = db.Administradores.Find(id);
            db.Administradores.Remove(administradore);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEstudiante(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudiante estudiante = db.Estudiantes.Find(id);
            if (estudiante == null)
            {
                return HttpNotFound();
            }
            return View(estudiante);
        }
        // POST: Administrador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteEstudianteConfirmed(int id)
        {
            Estudiante estudiante = db.Estudiantes.Find(id);
            db.Estudiantes.Remove(estudiante);
            db.SaveChanges();
            return RedirectToAction("IndexEstudiantes");
        }
        public ActionResult DeleteDocente(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           
            Docente docente = db.Docentes.Find(id);
            if (docente == null)
            {
                return HttpNotFound();
            }
            return View(docente);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteDocenteConfirmed(int id)
        {
            Docente docente = db.Docentes.Find(id);
            db.Docentes.Remove(docente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }



}