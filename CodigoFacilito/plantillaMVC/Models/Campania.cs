﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace plantillaMVC.Models
{
    public class Campania
    {
        public int CampaniaId { get; set; }
        public string Nombre  { get; set; }
        public DateTime FechaPlan { get; set; }
        public DateTime Fecha { get; set; }
        public ICollection<Actividad> Actividades { get; set; }

    }
}