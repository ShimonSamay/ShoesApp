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
    public class KidsShoesController : ApiController
    {
        static string stringConnection = "Data Source=SHIMONSAMAY;Initial Catalog=ShoesShopSB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Application Name=EntityFramework";
        KidsDBContextDataContext ShoesShopDB = new KidsDBContextDataContext(stringConnection);

        public IHttpActionResult Get()
        {
            try
            {
                return Ok(ShoesShopDB.KidsShoes.ToList());
            }
            catch (SqlException sqlErr)
            {
                return BadRequest(sqlErr.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(ShoesShopDB.KidsShoes.First(shoes => shoes.Id == id));
            }
            catch (SqlException sqlErr)
            {
                return BadRequest(sqlErr.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        
        public IHttpActionResult Post([FromBody]KidsShoe value)
        {
            try
            {
                ShoesShopDB.KidsShoes.InsertOnSubmit(value);
                ShoesShopDB.SubmitChanges();
                return Ok(ShoesShopDB.KidsShoes.ToList());
            }
            catch (SqlException sqlErr)
            {
                return BadRequest(sqlErr.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        
        public IHttpActionResult Put(int id, [FromBody] KidsShoe value)
        {
            try
            {
                KidsShoe shoeToUpdate = ShoesShopDB.KidsShoes.First(shoe => shoe.Id == id);  
                shoeToUpdate.Company = value.Company;
                shoeToUpdate.Material = value.Material;
                shoeToUpdate.Size = value.Size; 
                shoeToUpdate.Price = value.Price;   
                shoeToUpdate.AtStock = value.AtStock;
                ShoesShopDB.SubmitChanges();
                return Ok(ShoesShopDB.KidsShoes.ToList());
            }
            catch (SqlException sqlErr)
            {
                return BadRequest(sqlErr.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                ShoesShopDB.KidsShoes.DeleteOnSubmit(ShoesShopDB.KidsShoes.First(shoe => shoe.Id == id));
                ShoesShopDB.SubmitChanges();
                return Ok(ShoesShopDB.KidsShoes.ToList());
            }
            catch (SqlException sqlErr)
            {
                return BadRequest(sqlErr.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


    }
}
