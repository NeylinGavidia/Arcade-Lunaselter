﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio2
{
    public class Juego2
    {
        private string[] frutas = { "manzana", "plátano", "naranja", "piña", "fresa" };
        private string[] pistas = {
            "Es roja, dulce y crujiente.",
            "Es amarilla y tiene una cáscara fácil de pelar.",
            "es redonda y su color es su nombre.",
            "Tiene una corona y es tropical.",
            "Es pequeña, roja y con semillas por fuera."};

        private string frutaSecreta;
        private string pista;

        public Juego2()
        {
            SeleccionarFrutaAleatoria();
        }

        private void SeleccionarFrutaAleatoria()
        {
            Random rand = new Random();
            int indice = rand.Next(frutas.Length);
            frutaSecreta = frutas[indice];
            pista = pistas[indice];
        }

        public string ObtenerPista()
        {
            return pista;
        }

        public bool Adivinar(string intento)
        {
            return intento.Trim().ToLower() == frutaSecreta;
        }

        public string ObtenerFruta()
        {
            return frutaSecreta;
        }
    }
}
