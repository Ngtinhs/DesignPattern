using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatterns
{
    //Hành vi Asteact
    public abstract class VehicalBehavior
    {
        public abstract void AboutMe(string vehicel);

    }

    //Kha nang bay duoc
    class FlyBehavior : VehicalBehavior
    {
        public override void AboutMe(string vehicel)
        {
            Console.WriteLine("{0} co the bay ngay bay gio", vehicel);
        }
    }

    //Kha nang boi duoc
    class FloatBehavior : VehicalBehavior
    {
        public override void AboutMe (string vehicle)
        {
        Console.WriteLine("{0} co the boi ngay bay gio", vehicle);
        }
    }


    //Chua co lam gi dac biet het
    class InitialBehabior : VehicalBehavior
    {
        public override void AboutMe(string vehicle)
        {
            Console.WriteLine("{0} moi san xuat ra, chua lam duoc gi", vehicle);
        }
    }

    //Phuong tien giao thong
    public class Vehical
    {
        VehicalBehavior behavior;
        string vehicleType;
        public Vehical(string vehicleType)
        {
            this.behavior = new InitialBehabior();
            this.vehicleType = vehicleType;
        }


        //cai dat hanh vi phuong tien
        public void SetVehicalBehavior(VehicalBehavior behavior)
        {
            this.behavior = behavior;

        }
        public void DisplayAboutMe()
        {
            behavior.AboutMe(vehicleType);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day la demo cua Strategy Pattern.");
            Console.WriteLine();
            Vehical KOto = new Vehical("Xe hoi cua K");
            //KOto.DisplayAboutMe();
            //Console.WriteLine("Toi phi truong roiii");
            //KOto.SetVehicalBehavior(new FlyBehavior());
            //KOto.DisplayAboutMe();

            KOto.DisplayAboutMe();
            Console.WriteLine("Toi song roiii");
            KOto.SetVehicalBehavior(new FloatBehavior());
            KOto.DisplayAboutMe();

        }

    }
}
