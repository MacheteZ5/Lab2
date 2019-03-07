using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1.Models
{
    public class Juegos
    {
        public string nombre { get; set; }
        public int Id { get; set; }
        public float puntuacion { get; set; }
        public string categoria { get; set; }
        public string estudio { get; set; }
        public int año { get; set; }
        public string resultadoTiempo { get; set; }
        public string resultadoTiempoPID { get; set; }
    }
}