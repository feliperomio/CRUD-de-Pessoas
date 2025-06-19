using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace CRUD
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        string strconn = "Server=localhost;Port=3306;uid=root;Pwd=senha;Database=CRUD;";





        private void btnCadastrar_Click(object sender, EventArgs e) {
            try {
                MySqlConnection conn = new MySqlConnection(strconn);


                conn.Open(); //usado para abrir a conexao com o banco de dados
                conn.Close(); //usado para fechar a conexao com o banco de dados

            }
            catch(Exception err){ 
            MessageBox.Show(err.Message);
            }


        }
    }
}
