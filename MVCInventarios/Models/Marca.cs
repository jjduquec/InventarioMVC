﻿namespace MVCInventarios.Models;

    public class Marca
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Producto>productos { get; set; }
    }
