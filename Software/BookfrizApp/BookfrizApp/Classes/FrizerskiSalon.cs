﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookfrizApp.Classes;

namespace Trazilica
{
    public class FrizerskiSalon
    {
        public int IdFrizerski { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public Grad Grad { get; set; }
        public FrizerskiSalon()
        {

        }
    }
}
