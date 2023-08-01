using Pilas;

namespace Pilas
{
    public partial class Form1 : Form
    {
        // SE CREAN LOS NODOS DE AMBAS PILAS
        Nodo PRIMERO1 = null;
        Nodo ULTIMO1 = null;

        Nodo PRIMERO2 = null;
        Nodo ULTIMO2 = null;

        public Form1()
        {
            InitializeComponent();
        }
        // Evento Boton AGREGAR
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Nodo NUEVO = new Nodo();            // Se crea al nodo NUEVO
            NUEVO.nombre = txtNombre.Text;     // Carga de datos de NUEVO, con los datos ingresados de Usuario.
            NUEVO.dni = txtDNI.Text;
            if (PRIMERO1 == null)               // Si la fila esta VACIA. PRIMERO no existe.     
            {
                NUEVO.ANTERIOR = null;          // Como es primero, no hay nada ANTERIOR al elemento NUEVO          
                PRIMERO1 = NUEVO;               // PRIMERO1 Y ULTIMO1 es igual a NUEVO. (Ya que es el unico)
                ULTIMO1 = NUEVO;

            }
            else                             // Si ya hay elementos en la PILA
            {
                NUEVO.ANTERIOR = ULTIMO1;   // Se carga a ANTERIOR del NUEVO con los datos de ULTIMO1
                ULTIMO1 = NUEVO;            // Se reasigna ULTIMO1 al nuevo.

            }
            txtDNI.Text = "";               // Se vacian los campos de carga de datos.
            txtNombre.Text = "";
            Listar();                       // Se llama al Metodo LISTAR.
        }

        private void Listar()
        {
            Nodo AUXILIAR = new Nodo();      // Se crea el nodo AUXILIAR
            AUXILIAR = ULTIMO1;              // AXILIAR copia los datos del ULTIMO1

            lstPila1.Items.Clear();          // Se limpia la PILA1

            if (AUXILIAR != null)            // Si ya hay elemento en la PILA.
            {
                while (AUXILIAR != null)     //BUCLE que agrega los datos a la pila.
                {
                    lstPila1.Items.Add(AUXILIAR.nombre + " - " + AUXILIAR.dni);
                    AUXILIAR = AUXILIAR.ANTERIOR;   // AUXILIAR copia los datos de AUXILIAR ANTERIOR
                }
            }
        }

        // Boton MOVER DERECHA
        private void cmdQuitarPila1_Click(object sender, EventArgs e)
        {
            Nodo AUXILIAR = new Nodo();         // Se crea el nodo AUXILIAR
            AUXILIAR = ULTIMO1;                 // AUXILIAR copia los datos de ULTIMO1

            if (AUXILIAR != null)               // Si la pila 1 no esta vacia
            {
                ULTIMO1 = AUXILIAR.ANTERIOR;    // ULTIMO1 copia los datos de AUXILIAR ANTERIOR. Ya que se cambiara de PILA

                if (PRIMERO2 == null)           // Si la pila 2 esta vacía
                {
                    AUXILIAR.ANTERIOR = null;   // EL elemento que se agregue no tiene nada anterior.
                    PRIMERO2 = AUXILIAR;        // PRIMERO2 y ULTIMO2 toma los datos de AUXILIAR (ULTIMO1). 
                    ULTIMO2 = AUXILIAR;         // Los dos punteros de la pila2 Apunta al unico elemento que tiene.

                }
                else                                // Si la pila 2 ya tiene elementos.
                {
                    AUXILIAR.ANTERIOR = ULTIMO2;    // AUXILIAR.ANTERIOR toma los datos de ULTIMO2
                    ULTIMO2 = AUXILIAR;             // ULTIMO2 toma los datos de AUXILIAR.

                }
            }
            else MessageBox.Show("Pila 1 vacia");

            Listar2();
            Listar();
        }

        private void Listar2()
        {
            Nodo AUXILIAR = new Nodo();      // Se crea el nodo AUXILIAR
            AUXILIAR = ULTIMO2;              // AXILIAR copia los datos del ULTIMO1

            lstPila2.Items.Clear();          // Se limpia la PILA1

            if (AUXILIAR != null)            // Si ya hay elemento en la PILA.
            {
                while (AUXILIAR != null)     //BUCLE que agrega los datos a la pila.
                {
                    lstPila2.Items.Add(AUXILIAR.nombre + " - " + AUXILIAR.dni);
                    AUXILIAR = AUXILIAR.ANTERIOR;   // AUXILIAR copia los datos de AUXILIAR ANTERIOR
                }
            }
        }

        private void cmdQuitarPila2_Click(object sender, EventArgs e)
        {
            Nodo AUXILIAR = new Nodo();         // Se crea el nodo AUXILIAR
            AUXILIAR = ULTIMO2;                 // AUXILIAR copia los datos de ULTIMO1

            if (AUXILIAR != null)               // Si la pila 2 no esta vacia
            {
                ULTIMO2 = AUXILIAR.ANTERIOR;    // ULTIMO1 copia los datos de AUXILIAR ANTERIOR. Ya que se cambiara de PILA

                if (PRIMERO1 == null)           // Si la pila 1 esta vacía
                {
                    AUXILIAR.ANTERIOR = null;   // EL elemento que se agregue no tiene nada anterior.
                    PRIMERO1 = AUXILIAR;        // PRIMERO1 y ULTIMO1 toma los datos de AUXILIAR (ULTIMO2). 
                    ULTIMO1 = AUXILIAR;         // Los dos punteros de la pila2 Apunta al unico elemento que tiene.

                }
                else                                // Si la pila 1 ya tiene elementos.
                {
                    AUXILIAR.ANTERIOR = ULTIMO1;    // AUXILIAR.ANTERIOR toma los datos de ULTIMO2
                    ULTIMO1 = AUXILIAR;             // ULTIMO2 toma los datos de AUXILIAR.

                }
            }
            else MessageBox.Show("Pila 2 vacia");

            Listar2();
            Listar();
        }
    }
}

