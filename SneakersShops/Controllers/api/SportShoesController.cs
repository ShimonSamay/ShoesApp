using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SneakersShops.Models;

namespace SneakersShops.Controllers.api
{
    public class SportShoesController : ApiController
    {
        static string connectionString = "Data Source=SHIMONSAMAY;Initial Catalog=ShoesShopSB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Application Name=EntityFramework";
        public IHttpActionResult Get()
        {
            try
            {

                return Ok(getAllSportShoes(connectionString));
            }
            catch (SqlException sqlErr)
            {
                return BadRequest(sqlErr.Message);
            }
            catch (Exception x)
            {
                return BadRequest(x.Message);
            }
        }


        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(getShoe(connectionString, id));
            }
            catch (SqlException sqlErr)
            {
                return BadRequest(sqlErr.Message);
            }
            catch (Exception x)
            {
                return BadRequest(x.Message);
            }
        }


        public IHttpActionResult Post([FromBody] SportShoes value)
        {
            try
            {
                addShoes(connectionString, value);  
                return Ok("added");
            }
            catch(SqlException sqlErr)
            {
                return BadRequest(sqlErr.Message);
            }
            catch (Exception x)
            {
                return BadRequest(x.Message);
            }
        }


        public IHttpActionResult Put(int id, [FromBody] SportShoes value)
        {
            try
            {   
                updateShoes(connectionString, value, id);
                return Ok("edited");
            }
            catch (SqlException sqlErr)
            {
                return BadRequest(sqlErr.Message);
            }
            catch (Exception x)
            {
                return BadRequest(x.Message);
            }

        }


        public IHttpActionResult Delete(int id)
        {
            try
            {
                deleteShoes(connectionString, id);
                return Ok("deleted");
            }
            catch (SqlException sqlErr)
            {
                return BadRequest(sqlErr.Message);
            }
            catch (Exception x)
            {
                return BadRequest(x.Message);
            }

        }













        private List<SportShoes> getAllSportShoes(string connection)
        {
            List<SportShoes> snaekersList = new List<SportShoes>();
            using (SqlConnection DBconnection = new SqlConnection(connection))
            {
                DBconnection.Open();
                string query = "SELECT * FROM SportShoes";
                SqlCommand command = new SqlCommand(query, DBconnection);
                SqlDataReader DATA = command.ExecuteReader();
                if (DATA.HasRows)
                {
                    while (DATA.Read())
                    {
                      snaekersList.Add(new SportShoes(DATA.GetString(1), DATA.GetString(2), DATA.GetInt32(4), DATA.GetInt32(5)));
                        
                    }
                    DBconnection.Close();
                    return snaekersList;

                }
                   return snaekersList;
 
            }
        }

        private SportShoes getShoe(string connection, int id)
        {
            SportShoes shoes = new SportShoes();
            using (SqlConnection DBconnection = new SqlConnection(connection))
            {
                DBconnection.Open();
                string query = $@"SELECT * FROM SportShoes WHERE Id = {id}";
                SqlCommand command = new SqlCommand(query, DBconnection);
                SqlDataReader DATA = command.ExecuteReader();
                if (DATA.HasRows)
                {
                    while (DATA.Read())
                    {
                        shoes = new SportShoes(DATA.GetString(1), DATA.GetString(2), DATA.GetInt32(3), DATA.GetInt32(4));
                    }
                    DBconnection.Close();
                    return shoes;
                }
                return shoes;
            }







       
        }

        private void addShoes (string connection , SportShoes newShoes)
        {
            using (SqlConnection DBconnection = new SqlConnection(connection))
            {
                DBconnection.Open();
                string query = $@"INSERT INTO SportShoes (Company ,Model , Size , Price )
                               VALUES ('{newShoes.Company}' , '{newShoes.Model}' , {newShoes.Size} , {newShoes.Price})";
                SqlCommand command = new SqlCommand(query, DBconnection);
               command.ExecuteNonQuery();
               
            }
        }

        private void updateShoes (string connection, SportShoes updatedShoes , int id)
        {
            using(SqlConnection DBconnection = new SqlConnection(connection))
            {
                DBconnection.Open();
                string query = $@"UPDATE SportShoes
                                 SET Company = '{updatedShoes.Company}' ,
                                 Model = '{updatedShoes.Model}' ,
                                 Size = {updatedShoes.Size} ,
                                 Price = {updatedShoes.Price} 
                                 WHERE Id = {id}";
                SqlCommand command = new SqlCommand (query, DBconnection);
                command.ExecuteNonQuery ();
            }
        }

        private void deleteShoes (string connection , int id)
        {
            using(SqlConnection DBconnection = new SqlConnection(connection))
            {
                DBconnection.Open();
                string query = $@"DELETE FROM SportShoes WHERE Id = {id}";
                SqlCommand command = new SqlCommand(query, DBconnection);
                command.ExecuteNonQuery();
            }
        }
    }
}
