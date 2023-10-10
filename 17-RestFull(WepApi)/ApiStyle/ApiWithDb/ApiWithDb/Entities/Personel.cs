using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiWithDb.Entities
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City ?City { get; set; }
        //Boş geçilebilir demediğmiz zaman hata alıyoruz.
    }
    //Library & Framework herhangi bir projeyi yazmakta kolaylık için altyapı.
    //Kodu daha kolay yazmaya yarar.
    //Framework'ün belirli bir kuralları ve bu kurallar dışına çıkamıyoruz.
    //Library daha esnektir.
    //Bootstrap-Html Library
    //Dapper-SQL Library(gördük)
    //EF-SQL Framework(gördük)
    //Servesleri kullanırken arayüzü yazmak içinde Web programlamada serviceleri kullanmak için javascript şart.(gördük)
    //Javascript için Frameworkler ise Angular.js-Ianic
    //Angular-Web ortamda
    //Ianic-Mobil ortamda(Android+Apple)
    //Google için framework React.Js(Web) - ReactNative(Mobil)(Android+Apple)
    //React js yazmayı kolaşlaştıran bir kütüphanedir.
    //Angular ise frameworkdür
    //Google en son Flutter çıkardı.Entityframework-Flutter(Web+Mobil+Desktop)
    //Google-Dart-Backend

    //JavaScriptin Avantajları
    //Facebookta birisini fotoğrafını beğendiğin zaman beğeni sayısını arttırmıyor sen ve 62 kişi beğendi yazıyor
    //Diğer kişilerde 63 yapıyor.
    //Eskiden instagram çok pil yerdi her seferinde fotoğrafları yüklerdi.Şimdi profile 5 fotoğrafı getiriyor aşağı indikçe diğer fotoğrafları getiriyor.
    //Performans açısından js iyi.
}



