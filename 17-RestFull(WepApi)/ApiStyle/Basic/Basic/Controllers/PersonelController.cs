using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers
{
    //Route linki ifade eder.Daha önce yaptığımız projelerde route yoktu.Sebebi de default bir yolu vardı.
    //api yazan yeri genelde ya kaldırırlar ya da adını değiştirirler.
    [Route("api/[controller]")]
    [Route("[controller]/[action]")]
    [ApiController]
    public class PersonelController : ControllerBase
    {
        public List<Personel> GetPersonel()
        {
            List<Personel> personelList = new List<Personel>();
            Personel p1 = new Personel { Id = 1, Ad = "Şamil" };
            personelList.Add(p1);
            Personel p2 = new Personel { Id = 2, Ad = "Ali" };
            personelList.Add(p2);
            return personelList;
        }

        //Service bazlı proje yazmak istiyorsak mutlaka HttpGet yazmak zorundayız.Default olarak gelmiyor.
        [HttpGet]
        public List<Personel> PersonelList()
        {
            //Projeyi Wep api olarak açtığımız için Json'a kendi otomatik çevirdi.
            //Json döndürür.
            //Bunu view yoktur bunun için farklı bir proje yapmamız lazım.
            return GetPersonel();
        }

        //Find(int id) göndereceğimiz parametreyi HttpGet de [HttpGet("{id:int}")] bu şekilde tanımlamak zorundayız
        [HttpGet("{id:int}")]
        public Personel Find(int id)
        {
            var personel = GetPersonel().Where(x => x.Id == id).FirstOrDefault();
            return personel;
        }
    }
}
