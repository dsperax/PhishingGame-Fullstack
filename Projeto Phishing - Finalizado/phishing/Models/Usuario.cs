﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace phishing.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public int Pontuacao { get; set; }

        public int Status { get; set; }
    }
}
