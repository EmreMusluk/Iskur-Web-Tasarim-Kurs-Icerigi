using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaProgram
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Unvan { get; set; }

        private string KkNo;

        public string GetKkNo()
        {
            return "*******" + KkNo.Substring(KkNo.Length - 2);
        }

        public void SetKkNo(string value)
        {
            KkNo = value;
        }

        protected string telNo;

        public string GetTelNo()
        {
            return telNo;
        }

        public void SetTelNo(string value)
        {
            telNo = value;
        }
    }
}
