using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeremias.Poropat._23
{
    public class PersonalMedico:Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        /// <summary>
        /// Sobreescribo FichaExtra
        /// </summary>
        /// <returns></returns>
        internal override string FichaExtra()
        {
            //se inicializa en si, si el medico es residente, de lo contrario se inicia en no
            string residencia = esResidente ? "SI" : "NO";
            //Almaceno las consultas
            string fichaConsultas = "";
            //itero las consultas
            foreach (Consulta consulta in consultas)
            {
                fichaConsultas += $"{consulta.Fecha} - Paciente: {consulta.Paciente.NombreCompleto}\n";
            }
            return $"¿Finalizó residencia? {residencia}\nATENCIONES:\n{fichaConsultas}";
        }
        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente) : base(nombre, apellido, nacimiento)
        {
            this.esResidente = esResidente;
            consultas = new List<Consulta>();
        }
        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta nuevaConsulta = new Consulta(DateTime.Now, paciente);
            doctor.consultas.Add(nuevaConsulta);
            return nuevaConsulta;
        }
    }
}
