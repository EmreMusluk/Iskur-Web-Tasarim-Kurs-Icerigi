using BasicRepository.Data;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BasicRepository.Models
{
    public class PersonelModel
    {
        public PersonelModel()
        {
            Personel = new Personel();
        }
        public Personel Personel { get; set; }
        public string Head { get; set; }
        public string Text { get; set; }
        public string Cls { get; set; }
    }
}
