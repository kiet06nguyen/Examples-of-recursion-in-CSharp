namespace BTBUOI13_Đệ_Quy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            while (menu == true)
            {
                Console.Clear();
                Console.WriteLine("Cau 1: Tinh tong cac so tu nhien tu 1 den n");
                Console.WriteLine("Cau 2: Tinh luy thua");
                Console.WriteLine("Cau 3: Dem chu so cua 1 so nguyen");
                Console.Write("Chon cau: ");
                string chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        cau1();
                        break;
                    case "2":
                        cau2();
                        break;
                    case "3":
                        cau3();
                        break;
                    case "4":
                        break;
                    default:
                        break;

                }
            }


        }
        static void cau1()
        {
            Console.Clear();
            Console.Write("Nhap so de tinh: ");
            int so = int.Parse(Console.ReadLine());
            Console.WriteLine("Tong la: " + tinhtong(so));
            Console.ReadKey();
        }
        static int tinhtong(int a)
        {
            if (a == 1) return a;
            return a + tinhtong(a - 1);
        }

        static void cau2()
        {
            Console.Clear();
            Console.WriteLine("Nhap so: ");
            int so = int.Parse(Console.ReadLine());
            int mu = 0;
            do
            {
                Console.WriteLine("Nhap luy thua ( nguyen duong ): ");
                mu = int.Parse(Console.ReadLine());
            }
            while (mu <= 0);
            Console.WriteLine("Luy thua la: " + luythua(so, mu));
            Console.ReadKey();
        }
        static int luythua(int a, int b) 
        {
            if (b == 1) return a;
            return a = a * luythua(a, b - 1);
        }

        static void cau3()
        {
            Console.Clear();
            Console.Write("Nhap so can dem: ");
            int so = int.Parse(Console.ReadLine());
            Console.WriteLine("Tong chu so la: " + demchuso(so));
            Console.ReadKey();
        }

        static int demchuso(int a)
        {
            if(a == 0) return a;
            return 1 + demchuso(a / 10);
        }
    }
}
