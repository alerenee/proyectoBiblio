using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Usuario
    {
        private int id;
        private string name;
        private string birthday;
        private string email;
        private string phone;
        private string carnet;

        public Usuario(int id, string name, string birthday, string email, string phone, string carnet)
        {
            this.Id = id;
            this.Name = name;
            this.Birthday = birthday;
            this.Email = email;
            this.Phone = phone;
            this.Carnet = carnet;
        }

        public Usuario()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Carnet { get => carnet; set => carnet = value; }

        public bool Login(string usuario, string contraseña)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("SELECT email, id_rol FROM users WHERE email = @usuario AND pass = @pass", con.conexion());
            cmd.Parameters.AddWithValue("usuario", usuario);
            cmd.Parameters.AddWithValue("pass", contraseña);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
