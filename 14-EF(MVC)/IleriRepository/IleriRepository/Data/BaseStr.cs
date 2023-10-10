using System.ComponentModel.DataAnnotations;

namespace IleriRepository.Data
{
    public class BaseStr
    {
        [Key]
        public string Id { get; set; }
        //Hangi tarihte kayıt oluşturulmuş.
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public BaseStr()
        {
            LastUpdateDate = DateTime.Now;
        }
    }
}
