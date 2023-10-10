using ApiWithDb.Data;
using ApiWithDb.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiWithDb.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        MyContext _db;
        Response _response;
        public CityController(MyContext db, Response response)
        {
            _db = db;
            _response = response;
        }

        [HttpGet]
        public List<City> GetCities()
        {
            return _db.Set<City>().ToList();
        }

        [HttpGet("{id:int}")]
        public City GetCity(int id)
        {
            return _db.Set<City>().Find(id);
        }

        //Post dersek Database veri eklemek için kullanılır.
        [HttpPost]
        public Response Add(City city)
        {
            try
            {
                _db.Set<City>().Add(city);
                _db.SaveChanges();
                _response.Error = false;
                _response.Msg = $"{city.Name} Başarılı şekilde eklendi";
            }
            catch (Exception ex)
            {
                _response.Error = true;
                _response.Msg = ex.Message;
            }
            return _response;
        }

        //HttpPost yazsakta olur ama Geleneksek olarak put kullanırız.
        [HttpPut]
        public Response Update(City city)
        {
            try
            {
                _db.Set<City>().Update(city);
                _db.SaveChanges();
                _response.Error = false;
                _response.Msg = $"{city.Name} Başarılı şekilde güncellendi";
            }
            catch (Exception ex)
            {
                _response.Error = true;
                _response.Msg = ex.Message;
            }
            return _response;
        }

        //HttpPost yazsakta olur ama Geleneksek olarak delete kullanırız.
        [HttpDelete]
        public Response Delete(City city)
        {
            try
            {
                _db.Set<City>().Remove(city);
                _db.SaveChanges();
                _response.Error = false;
                _response.Msg = $"{city.Name} Başarılı şekilde silindi";
            }
            catch (Exception ex)
            {
                _response.Error = true;
                _response.Msg = ex.Message;
            }
            return _response;
        }

        [HttpDelete("{id=int}")]
        public Response DeleteById(int id)
        {
            return Delete(GetCity(id));
        }
    }
}
