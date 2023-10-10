using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IleriRepository.Data
{
    public class Personel : BaseInt
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime DateofBirth { get; set; }
        public char Gender { get; set; }
        private string Phone { get; set; }
        public int DepartmentId { get; set; }
        public string GradeId { get; set; }
        public string Street { get; set; }
        public string Avenue { get; set; }
        public int No { get; set; }
        public int CountyId { get; set; }
        public string ImgUrl { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        [ForeignKey("GradeId")]
        public Grade Grade { get; set; }
        [ForeignKey("CountyId")]
        public County County { get; set; }

        //Baserepository'de Personele ait özelliklere erişemediğimiz için bu metotları burada oluşturduk.
        //BU metotları da ortak kullanabilmek için IPersonelRep'e de ekleme yaptık.
        public string FullName()
        {
            if (Gender == 'E')
                return $"Sn Bay {Name} {SurName}";
            else
                return $"Sn Bayan {Name} {SurName}";
        }
        public int GetAge()
        {
            //23 Mart 1998
            DateTime today = DateTime.Now;
            //21 Ekim 2022
            int age = today.Year - DateofBirth.Year;
            //2022-1998 = 24
            DateTime BirthDay = DateofBirth.AddYears(age);
            //                    23 Mart 1998 + 24 =
            //23 Mart 2022
            if (BirthDay > today)
            {
                age++;
            }
            return age;
        }
        public List<string> GetAdress()
        {
            List<string> adress = new List<string>();
            adress.Add(FullName());
            adress.Add(Street);
            adress.Add(Avenue);
            adress.Add(No.ToString());
            adress.Add(County.CountyName + "-" + County.City.CityName);
            return adress;
        }
    }
}
