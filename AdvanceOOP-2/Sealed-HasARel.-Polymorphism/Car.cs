using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_HasARel._Polymorphism
{
    public class Car
    {  public Car(int hP,string color)
        {
            HP = hP;
            Color = color;

        }
        //Has A relationship
        //Car has CarInfo
        
        CarInfo CarInfo = new CarInfo();
        public void SetCarInfo(int LicensNo,string ownername)
        {
           CarInfo.LicenseNo = LicensNo;
            CarInfo.OwnerName = ownername;

        }
        public void GetCarInfo()
        {
            Console.WriteLine($"The car has the license no {CarInfo.LicenseNo} and is owned by {CarInfo.OwnerName}");
        }
        public int HP { get; set; }
        public String Color { get; set; }

        public void showDetails()
        {
            Console.WriteLine("HP {0}, Color {1}",HP,Color);
        }
        public virtual void Repair()
        {
            Console.WriteLine("Car has repair");
        }
    }
}
