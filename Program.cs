using System.Text;
// исходные данные x и y
// z = x+y
//результат z

//основная программа
string path = @"Input.txt";
double x=0, y=0; // фактические значения
try
{
    x = double.Parse(Console.ReadLine());
    y = double.Parse(Console.ReadLine());
    InputData(path, x, y);
    ReadData(path);
}
catch (Exception ex)
{
    Console.WriteLine($"Исключение: {ex.Message}");
}

//метод записи в файл
 static void InputData(string p,double xx, double yy) 
{
        StreamWriter sw = new StreamWriter(p, false, Encoding.Default);
        sw.WriteLine(xx);
        sw.WriteLine(yy);
        sw.Close();
}
//перегрузка метода записи в файл
//static void InputData(string p, double zz)
//{
//    StreamWriter sw = new StreamWriter(p, false, Encoding.Default);
//    sw.WriteLine(zz);
//    sw.Close();
//}

//метод чтения из файла
static void ReadData(string p)
{
    StreamReader sr = new StreamReader(p, Encoding.Default);
    double xx = double.Parse(sr.ReadLine());
    double yy = double.Parse(sr.ReadLine());
    double zz = Solve(xx, yy);
    Console.WriteLine($"Результат z = {zz}");
    InputData(@"Rezult.txt", zz, 0);
}
    
//метод вычисления результата
static double Solve(double xx, double yy)
{
    return xx + yy;
}

