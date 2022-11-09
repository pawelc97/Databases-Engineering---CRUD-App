using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=PAWEL-KOMPUTER;Initial Catalog=Przedsiębiorstwo;Integrated Security=True ");
        private void Dodaj_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SqlCommand command = new SqlCommand("insert into Pracownicy(Imie, Nazwisko, Id_działu, Data_zatrudnienia, Pensja) values ('" + Imie_textBox.Text+ "','" + Nazwisko_textBox.Text + "','" 
                + int.Parse(Id_działu_textBox.Text) + "',getdate(),'" + int.Parse(Pensja_textBox.Text) + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Sukces!");
            con.Close();
            BindData();
        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from Pracownicy", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void Aktualizuj_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update Pracownicy set Imie = '" + Imie_textBox.Text + "', Nazwisko = '" + Nazwisko_textBox.Text + "', Id_działu = '"
                + int.Parse(Id_działu_textBox.Text) + "', Data_zatrudnienia = getdate(), Pensja = '" + int.Parse(Pensja_textBox.Text) + "' where Id_pracownika = '"+ int.Parse(Id_pracownika_textBox.Text) +"'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukces!");
            BindData();

        }

        private void Usuń_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("delete from Pracownicy where Id_pracownika = '" + int.Parse(Id_pracownika_textBox.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukces!");
            BindData();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
