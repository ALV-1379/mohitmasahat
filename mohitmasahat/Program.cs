namespace mohitmasahat
{
    class Program
    {
        
            static void Main(string[] args)
            {
                Console.WriteLine("gozine mad nazar ra vared konid");
                Console.WriteLine("1. mohit va masahat dayere");
                Console.WriteLine("2. mohit va masahat moraba");
                Console.WriteLine("3. mohit va masahat mosalas");
                Console.WriteLine("4. mohit va masahat zozanaghe");
                Console.WriteLine("5. mohit va masahat n zeli");
                Console.WriteLine("6. mohit va masahat beyzi");



                int x = Convert.ToInt32(Console.ReadLine());


                if (x == 1)
                {
                    Console.Write("shoa dayere ra vared konid: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    circle circle = new circle(r);
                    Console.WriteLine($"masahat babar {circle.masahat()}");
                    Console.WriteLine($"mohit bababr {circle.mohit()}");
                }
                else if (x == 2)
                {
                    Console.Write("andaze yeki az azla ra vared konid: ");
                    double s = Convert.ToDouble(Console.ReadLine());
                    square square = new square(s);
                    Console.WriteLine($"masahat moraba bababr{square.masahat()}");
                    Console.WriteLine($"mohit moraba bababr{square.mohit()}");
                }
                else if (x == 3)
                {
                    Console.Write("ertefa mosalas ra vared konid: ");
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.Write("ghede mosalas ra vared konid: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    triangle mosalas = new triangle(h, b);
                    Console.WriteLine($"masahat mosalas barabar{mosalas.masahat()}");
                    Console.WriteLine($"mohit mosalas babar{mosalas.mohit()}");
                }
                else if (x == 4)
                {
                    Console.Write("ertefa zozanaghe ra vared konid: ");
                    double ertefa = Convert.ToDouble(Console.ReadLine());
                    Console.Write("tol zel balayi ra vared konid: ");
                    double zelb = Convert.ToDouble(Console.ReadLine());
                    Console.Write("tol zel payini ra vared konid: ");
                    double zelp = Convert.ToDouble(Console.ReadLine());
                    Console.Write("zel samt rast ra vared konid: ");
                    double zelr = Convert.ToDouble(Console.ReadLine());
                    Console.Write("zel samt chap ra vared konid: ");
                    double zelc = Convert.ToDouble(Console.ReadLine());
                    zozanaghe z1 = new zozanaghe(ertefa, zelb, zelp, zelr, zelc);
                    Console.WriteLine($"masahat barabr {z1.masahat()}");
                    Console.WriteLine($"mohit barbar{z1.mohit()}");
                }

                else if (x == 5)
                {
                    Console.Write("tedad azla r avared konid: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.Write("tol zel ra vared konid: ");
                    double l = Convert.ToDouble(Console.ReadLine());
                    nzeli y = new nzeli(n, l);
                    Console.WriteLine($"masahat babar ast ba{y.masahat()}");
                    Console.WriteLine($"mohit babar ast ba {y.mohit()}");
                }

                else if (x == 6)
                {
                    Console.Write("tol ghotr bozorg ra vared konid: ");
                    double ghort1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("tol ghotr kochak ra vared konid: ");
                    double ghotr2 = Convert.ToDouble(Console.ReadLine());
                    beyzi beyzi1 = new beyzi(ghort1, ghotr2);
                    Console.WriteLine($"masahat beyzi babar ast ba {beyzi1.masahat()}");
                    Console.WriteLine($"mohiyt  eyzi barabar bast ba {beyzi1.mohit()}");
                }
                else
                {
                Console.WriteLine("adad entekhab eshtebah vared shode");
                }
                
                    

                Console.ReadKey();

            }
        
    }
}
