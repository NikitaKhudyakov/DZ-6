bool isWork = true;
{
    while(isWork)
    {
        System.Console.WriteLine("Введите номер задания: ");
        int.TryParse(Console.ReadLine(), out int w);

switch(w)
        {
            case(1):
            {
                void Numb(int size)
                {
                int[] arr = new int [size];
                int j = 0;
                for ( int i = 0; i < size; i++)
                    {
                        System.Console.WriteLine("Введите число!");
                        arr[i] = int.Parse(Console.ReadLine());

                        if(arr[i] > 0) j++;
                    }
                    System.Console.WriteLine($" Чисел больше нуля - {j}!");
                }
                System.Console.WriteLine("Введите количество чисел!");
                Numb(int.Parse(Console.ReadLine()));
            }
            break;
            case(2):
            {
                void Coordinate(double b1, double k1, double b2, double k2)
                {
                double x = (b2-b1)/(k1-k2);
                double y = k1*x + b1;
                double y2 = k2*x + b2;
                Console.WriteLine ($"Прямые пересекаются в точках: ({x} : {y});");
                }
                System.Console.WriteLine("Введите четыре значения, для нахождения точки пересечения двух прямых: ");
                Coordinate(b1:int.Parse(Console.ReadLine()),
                k1:int.Parse(Console.ReadLine()),
                b2:int.Parse(Console.ReadLine()),
                k2:int.Parse(Console.ReadLine()));
                
            }
            break;
            case(-1): isWork = false ; break;
        }
    
    }
}
