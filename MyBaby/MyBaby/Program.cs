using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBaby
{
    class Program
    {
        static void Main(string[] args)
        {
            Baby myLittleGirl = new Baby();
            myLittleGirl.NickName = "Thỏ";
            myLittleGirl.Gender = "GIRL";
            myLittleGirl.Weight = 3.4;          //kg
            myLittleGirl.DOB = "12/01/2017";    //15h45 ngày 15/12 năm Bính Thân

            myLittleGirl.Say("HELLO WORLD !");
        }
    }
}
