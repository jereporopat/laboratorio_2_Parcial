namespace Jeremias.Poropat._23
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioRecidencia;
        protected DateTime nacimiento;
        protected string nombre;

        /// <summary>
        /// retrono el calculo de la edad en funcion a su fecha de nacimiento
        /// </summary>
        public int Edad
        {
            get 
            {
                DateTime hoy = DateTime.Today;
                int edad = hoy.Year - nacimiento.Year;
                if (nacimiento.Date > hoy.AddYears(-edad)) edad--;
                return edad;
            }
        }
        /// <summary>
        /// Retorna el nombre completo de la persona
        /// </summary>
        public string NombreCompleto
        {
            get { return $"{apellido}, {nombre}"; }
        }

        /// <summary>
        /// Lo uso para sobreescribirlo en otras clases
        /// </summary>
        /// <returns></returns>
        internal abstract string FichaExtra();

        /// <summary>
        /// Reutilizo el metodo "NombreCompleto"
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public string FichaPersonal(Persona p)
        {
            return $"{NombreCompleto}\nEDAD: {Edad}\n{FichaExtra()}";
        }
        /// <summary>
        /// Constructor de la clase persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacimiento"></param>
        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }

        /// <summary>
        /// Asigno valor y llamo al constructor de arriba de la misma clase con :this
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacimiento"></param>
        /// <param name="barrioRecidencia"></param>
        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia):this(nombre, apellido, nacimiento)
        {
            this.barrioRecidencia = barrioRecidencia;
        }
        public override string ToString()
        {
            return NombreCompleto;      
        }
    }
}