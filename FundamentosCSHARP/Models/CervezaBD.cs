using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace FundamentosCSHARP.Models
{
    class CervezaBD
    {
        private string connectionString
            = "Data Source=localhost;Initial Catalog=FundamentosCSharp;" +
            "User=sa;Password=123456";
        //funcion Get() de tipo Lista , mostrar cervezas
        public List<Cerveza> Get()
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            string query = "SELECT nombre, marca, alcohol, cantidad " +
                "FROM cerveza";
            //using() es para agregar los namespace y, entre llaves{},
            //crear un "universo" donde todo lo que creas solo existirá ahí
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                //ejecutar query command.ExecuteReader(); y agregarlo a reader
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    //obtener datos de registros de las columnas de la
                    //cadena query
                    int Cantidad = reader.GetInt32(3);
                    string Nombre = reader.GetString(0);
                    //creando objeto cerveza y agregandole atributos
                    Cerveza cerveza = new Cerveza(Cantidad, Nombre);
                    cerveza.Alcohol = reader.GetInt32(2);
                    cerveza.Marca = reader.GetString(1);
                    cervezas.Add(cerveza);
                }
                reader.Close();
                connection.Close();
            }
            return cervezas;
        }
        //metodo Add() agregar cerveza
        public void Add(Cerveza cerveza)
        {
            string query 
                = "INSERT INTO cerveza(nombre, marca, alcohol, cantidad) " +
                "VALUES(@nombre, @marca, @alcohol, @cantidad)";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);

                connection.Open();

                command.ExecuteNonQuery();//ExecuteNonQuery(); para insertar

                connection.Close();
            }
        }
        //metodo Edit() editar cerveza
        public void Edit(Cerveza cerveza, int Id)
        {
            string query
                = "UPDATE cerveza SET nombre=@nombre, " +
                "marca=@marca, alcohol=@alcohol, cantidad=@cantidad " +
                "WHERE id=@id";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);
                command.Parameters.AddWithValue("@id", Id);
                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
        //metodo Delete() eliminar cerveza
        public void Delete(int Id)
        {
            string query
                = "DELETE FROM cerveza " +
                "WHERE id=@id";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);
                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

    }
}
