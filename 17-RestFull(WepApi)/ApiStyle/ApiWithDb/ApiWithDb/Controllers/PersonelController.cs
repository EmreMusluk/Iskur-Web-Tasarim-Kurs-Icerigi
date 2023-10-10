using ApiWithDb.Data;
using ApiWithDb.DTO;
using ApiWithDb.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiWithDb.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class PersonelController : ControllerBase
    {
        MyContext _db;
        Response _response;

        public PersonelController(MyContext db, Response response)
        {
            _db = db;
            _response = response;
        }
        [HttpGet]
        public List<PersonelDTO> PersonelList()
        {
            return _db.Set<Personel>().Select(x => new PersonelDTO
            {
                Id = x.Id,
                Name = x.Name,
                CityName = x.City.Name
            }).ToList();
        }

        [HttpGet]
        public List<Personel> GetPersonels()
        {
            return _db.Set<Personel>().ToList();
        }

        [HttpGet("{id=int}")]
        public Personel GetPersonel(int id)
        {
            return _db.Set<Personel>().Find(id);
        }

        [HttpPost]
        public Response Add(Personel personel)
        {
            try
            {
                _db.Set<Personel>().Add(personel);
                _db.SaveChanges();
                _response.Error = false;
                _response.Msg = $"{personel.Name} Başarılı şekilde eklendi";
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
        public Response Update(Personel personel)
        {
            try
            {
                _db.Set<Personel>().Update(personel);
                _db.SaveChanges();
                _response.Error = false;
                _response.Msg = $"{personel.Name} Başarılı şekilde güncellendi";
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
        public Response Delete(Personel personel)
        {
            try
            {
                _db.Set<Personel>().Remove(personel);
                _db.SaveChanges();
                _response.Error = false;
                _response.Msg = $"{personel.Name} Başarılı şekilde silindi";
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
            return Delete(GetPersonel(id));
        }
    }
}
