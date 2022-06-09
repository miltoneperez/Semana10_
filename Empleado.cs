namespace JerarquiaEmpleados
{
    /// <summary>
    /// Definiendo la clase empleado.
    /// </summary>
    public abstract class Empleado
    {
        private long inss;
        private string nombre;
        private string apellido;
        private float salario;
       public Empleado(long id, string nomb, string ape)
       {
           this.inss=id;
           this.nombre=nomb;
           this.apellido=ape;
           this.salario=0;
       }
       /// <summary>
       /// salario float, retorna un valor.
       /// </summary>
       /// <value>
       /// The <c>Label</c> property represents a label
       /// for this instance.
       /// </value>
        public float Salario
        {
           get { return salario; }
            set { salario = value; }
        }
        /// <summary>
        /// Escribir apellido "string" y regresar el valor.
        /// </summary>
        /// <value>
        /// The <c>Label</c> property represents a label
        /// for this instance.
        /// </value>
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        /// <summary>
        /// Escribir Nombre "string" y regresar el valor.
        /// </summary>
        /// <value>
        /// The <c>Label</c> property represents a label
        /// for this instance.
        /// </value>
        public string Nombre
        { 
            get { return nombre; }
            set { nombre = value; }
        }
        /// <summary>
        /// Recive y regresa un "Inss".
        /// </summary>
        /// <value>
        /// Retorna un valor tipo logn.
        /// </value>
        public long Inss
        {
            get { return inss; }
            set { inss = value; }
        }
        /// <summary>
        /// Método público tipo string MostrarInformación.
        /// </summary>
        /// <returns>datos de usuarios</returns>
        public string MostrarInformacion( )
        {
            string Salida="";
		    Salida+=$"Inss   : {Inss}\n"
				+ $"Nombre :  {Nombre}\n"
				+ $"Salario:  {salario}\n";
		return  Salida;
        }
       /// <summary>
       /// Método público tipo float calcularSalario.
       /// </summary>
       /// <returns>De cantidad flotante</returns>
        public abstract  float calcularSalario();
    }
}