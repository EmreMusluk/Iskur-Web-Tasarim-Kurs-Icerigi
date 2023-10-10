using System.ComponentModel.DataAnnotations;

namespace IleriRepository.Data
{
    public class BaseInt
    {
        [Key]
        public int Id { get; set; }
        //Hangi tarihte kayıt oluşturulmuş.
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public BaseInt()
        {
            LastUpdateDate = DateTime.Now;
        }

    }
}
