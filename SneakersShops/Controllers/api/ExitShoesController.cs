using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using SneakersShops.Models;

namespace SneakersShops.Controllers.api
{
    public class ExitShoesController : ApiController
    {
        ShoesDBContext ShoesShopDB = new ShoesDBContext();

        public IHttpActionResult Get()
        {
            try
            {
                return Ok(ShoesShopDB.ExitShoes.ToList());
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

        
        public async Task<IHttpActionResult> Get(int id)
        {
            try
            {
                return Ok(await ShoesShopDB.ExitShoes.FindAsync(id));
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

       
        public async Task<IHttpActionResult> Post([FromBody]ExistShoes newShoes)
        {
            try
            {
                ShoesShopDB.ExitShoes.Add(newShoes);
                await ShoesShopDB.SaveChangesAsync();
                return Ok(ShoesShopDB.ExitShoes.ToList());
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


        public async Task<IHttpActionResult> Put(int id, [FromBody] ExistShoes updatedShoes)
        {
            try
            {
                ExistShoes shoesToUpdate = await ShoesShopDB.ExitShoes.FindAsync(id);
                shoesToUpdate.AtStock = updatedShoes.AtStock;
                shoesToUpdate.HasHeels = updatedShoes.HasHeels; 
                shoesToUpdate.Gender = updatedShoes.Gender;
                shoesToUpdate.Size = updatedShoes.Size; 
                shoesToUpdate.Price = updatedShoes.Price;   
                shoesToUpdate.Company = updatedShoes.Company;   
                await ShoesShopDB.SaveChangesAsync();
                return Ok(ShoesShopDB.ExitShoes.ToList());
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

        
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                ShoesShopDB.ExitShoes.Remove(await ShoesShopDB.ExitShoes.FindAsync(id));
                await ShoesShopDB.SaveChangesAsync();
                return Ok(ShoesShopDB.ExitShoes.ToList());
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
    }
}

