/*
Если описать словами, то программу я вижу следующим образом:
Пользователь нажимает клавишу, затем программа сопостовляет эту клавишу с позицией из массива, под которой 
находится частота (в Гц) и выводит звук с указанной частотой. Смена октав осуществляется путем замены массива или же
обращения программы к другому массиву, в котором обозначены другие частоты для клавиш

Может в начале попробовать сделать это без использования методов, а затем распределить код по ним?

Как сделать так, чтобы код не заканчивался после ввода одной клавиши...?z
- Запустить цикл while (true)!

Как сделать так, чтобы не вызывать беспонечно цикл if...?
*/

while (true)
{
    Console.WriteLine("Выберите октаву при помощи клавиш F4, F5 и F6");
    ConsoleKeyInfo octave = Console.ReadKey();

    if (octave.Key == ConsoleKey.F4)
    {
        Console.WriteLine("Выбрана четвертая октава!");
        int[] fourthOctave = new int[12] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
        zvook(fourthOctave);
    }
    else if (octave.Key == ConsoleKey.F5)
    {
        Console.WriteLine("Выбрана пятая октава!");
        int[] fifthOctave = new int[12] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
        zvook(fifthOctave);
    }
    else if (octave.Key == ConsoleKey.Escape)
        break;
}

static void zvook(int[] freq)
{
    while (true)
    {
        ConsoleKeyInfo klavisha = Console.ReadKey();
        if (klavisha.Key == ConsoleKey.A)
        {
            Console.Beep(freq[0], 400);
            Console.Clear();
        }
        else if (klavisha.Key == ConsoleKey.W)
        {
            Console.Beep(freq[1], 400);
            Console.Clear();
        }
        else if (klavisha.Key == ConsoleKey.S)
        {
            Console.Beep(freq[2], 400);
            Console.Clear();
        }
        else if (klavisha.Key == ConsoleKey.E)
        {
            Console.Beep(freq[3], 400);
            Console.Clear();
        }
        else if (klavisha.Key == ConsoleKey.D)
        {
            Console.Beep(freq[4], 400);
            Console.Clear();
        }
        else if (klavisha.Key == ConsoleKey.F)
        {
            Console.Beep(freq[5], 400);
            Console.Clear();
        }
        else if (klavisha.Key == ConsoleKey.T)
        {
            Console.Beep(freq[6], 400);
            Console.Clear();
        }
        else if (klavisha.Key == ConsoleKey.G)
        {
            Console.Beep(freq[7], 400);
            Console.Clear();
        }
        else if (klavisha.Key == ConsoleKey.Y)
        {
            Console.Beep(freq[8], 400);
            Console.Clear();
        }
        else if (klavisha.Key == ConsoleKey.H)
        {
            Console.Beep(freq[9], 400);
            Console.Clear();
        }
        else if (klavisha.Key == ConsoleKey.U)
        {
            Console.Beep(freq[10], 400);
            Console.Clear();
        }
        else if (klavisha.Key == ConsoleKey.J)
        {
            Console.Beep(freq[11], 400);
            Console.Clear();
        }
        else if (klavisha.Key == ConsoleKey.Escape)
            break;
    }
}