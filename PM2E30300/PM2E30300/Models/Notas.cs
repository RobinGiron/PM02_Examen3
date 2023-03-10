using System;
using System.Collections.Generic;
using System.Text;

namespace PM2E30300.Models
{
    public class Notas
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string contenido { get; set; }
        public DateTime fecha { get; set; }
        public string audio { get; set; }
        public string foto { get; set; }
        public string firma { get; set; }
        public int favorito { get; set; }
        public string estado{ get; set; }
        public int usuarioID { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }
        public DateTime fecha_ULT_mod { get; set; }
        public bool ContainFoto
        {
            get {
                if (!string.IsNullOrEmpty(foto)) { return true; } else { return false; } 
            }
        }
        public bool ContainAudio
        {
            get
            {
                if (!string.IsNullOrEmpty(audio)) { return true; } else { return false; }
            }
        }
        public bool ContainFavorite
        {
            get
            {
                if (favorito==1) { return true; } else { return false; }
            }
        }
    }
}
