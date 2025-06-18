using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace CRUD {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        string strconn = "Server=127.0.0.1;Port=3306;uid=root;Pwd=root;Database=CRUd;";

        private void btnCadastrar_Click(object sender, EventArgs e) {
            try {
                MySqlConnection conn = new MySqlConnection(strconn);


                conn.Open(); //usado para abrir a conexao com o banco de dados

                MySqlCommand cmd = new MySqlCommand("insert into Dados(nome, email, telefone, sexo) values('" + txtNome.Text + "', '" + txtEmail.Text + "', '" + txtTelefone.Text + "', '" + ComboBoxSexo.SelectedItem + "');", conn);

                cmd.ExecuteNonQuery(); // utilizado para inserir dados

                conn.Close(); //usado para fechar a conexao com o banco de dados

            }
            catch (Exception err) {
                MessageBox.Show(err.Message);
            }


        }

        private void btnRemover_Click(object sender, EventArgs e) {
            try {
                MySqlConnection conn = new MySqlConnection(strconn);


                conn.Open(); //usado para abrir a conexao com o banco de dados

                MySqlCommand cmd = new MySqlCommand("delete from Dados where id='" + txtID.Text + "';", conn);

                cmd.ExecuteNonQuery(); // utilizado para inserir dados

                conn.Close(); //usado para fechar a conexao com o banco de dados

            }
            catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e) {
            try {
                MySqlConnection conn = new MySqlConnection(strconn);


                conn.Open(); //usado para abrir a conexao com o banco de dados

                MySqlCommand cmd = new MySqlCommand("update Dados set nome = '" + txtNome.Text + "';", conn);

                cmd.ExecuteNonQuery(); // utilizado para inserir dados

                conn.Close(); //usado para fechar a conexao com o banco de dados

            }
            catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        private void btnMostraID_Click(object sender, EventArgs e) {
            try {
                MySqlConnection conn = new MySqlConnection(strconn);


                conn.Open(); //usado para abrir a conexao com o banco de dados

                MySqlCommand cmd = new MySqlCommand("select * from Dados where id= '" + txtID.Text + "';", conn);

                MySqlDataReader reader = cmd.ExecuteReader(); // utilizado para ler os dados

                while (reader.Read()) {

                    txtNome.Text = reader.GetString("nome");
                    txtEmail.Text = reader.GetString("email");
                    txtTelefone.Text = reader.GetString("telefone");
                    txtID.Text = reader.GetString("sexo");

                }
                conn.Close(); //usado para fechar a conexao com o banco de dados

            }
            catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }
    }
}
