using System.Collections.ObjectModel;

namespace CVApp.Models
{
    public class CVModel
    {
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public ObservableCollection<string> Idiomas { get; set; }
        public ObservableCollection<string> Aptitudes { get; set; }

        public CVModel()
        {
            // Datos iniciales
            Nombre = "José Martínez";
            Puesto = "Puesto ocupado / Buscado";
            Telefono = "999 999 999";
            Correo = "jose.martinez@gmail.com";
            Direccion = "México DF";
            Idiomas = new ObservableCollection<string>
            {
                "Español: Nativo",
                "Inglés: Bilingüe (TOEIC 950)",
                "Francés: Intermedio (B2)"
            };
            Aptitudes = new ObservableCollection<string>
            {
                "Inteligencia emocional",
                "Espíritu crítico",
                "Trabajo en equipo",
                "Capacidad analítica",
                "Habilidades físicas"
            };
        }
    }
}
