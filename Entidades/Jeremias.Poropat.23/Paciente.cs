using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jeremias.Poropat._23
{
    public class Paciente:Persona
    {
        public string diagnostico;

        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }
        /// <summary>
        /// sobreescribo el metodo de FichaExtra de la clase Persona
        /// </summary>
        /// <returns></returns>
        internal override string FichaExtra()
        {
            return $"Reside en: {barrioRecidencia}\n{diagnostico}";
        }
        /// <summary>
        /// Constructor de la clase Paciente, llamo al constructo de la clase base con :base
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacimiento"></param>
        /// <param name="barrioRecidencia"></param>
        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia):base(nombre, apellido, nacimiento, barrioRecidencia)
        {

        }
    }
}
