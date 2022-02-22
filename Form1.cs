using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace SQLite
{
    public partial class DlgPrincipal : Form
    {
        //Conexión a la Base de datos.
        public SQLiteConnection connection = new SQLiteConnection("Data source = C:/Users/aaron/source/repos/SQLite/src/db.db");
        
        public DlgPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            //Consultar contenido de tabla alumnos.
            SQLiteDataAdapter DataAdapter = new SQLiteDataAdapter("SELECT * FROM alumnos", connection);

            //Craer datatable.
            DataTable Dt = new DataTable();

            //Llenado de datos al datatable.
            DataAdapter.Fill(Dt);

            //Agregar datos al DataGridView.
            DgvDatos.DataSource = Dt;
        }
    }
}
