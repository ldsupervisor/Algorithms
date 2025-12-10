//1
DateTime now = DateTime.Now;

Console.WriteLine($"Standardowy format: {now}");
Console.WriteLine($"Tylko data: {now.ToShortDateString()}");
Console.WriteLine($"Tylko godzina: {now.ToShortTimeString()}");
Console.WriteLine($"Pełna data i czas: {now.ToLongDateString()} {now.ToLongTimeString()}");
Console.WriteLine($"Format niestandardowy: {now:dd-MM-yyyy HH:mm:ss}");

//2
int a = 10;
int b = 5;
Console.WriteLine("Suma: " + (a + b));
Console.WriteLine("Różnica: " + (a - b));
Console.WriteLine("Iloczyn: " + (a * b));
Console.WriteLine("Iloraz: " + (a / b));

//3
Console.Write("Podaj ciąg znaków które chcesz zamienić\n");
string tekst = Console.ReadLine() ?? "Brak tekstu";
string tekstMalymi = tekst.ToLower();
string tekstWielkimi = tekst.ToUpper();

Console.WriteLine("Tekst małymi literami: " + tekstMalymi);
Console.WriteLine("Tekst wielkimi literami: " + tekstWielkimi);
Console.WriteLine("Wciśnij dowolny klawisz, aby kontynuować...");
Console.ReadLine();

//4
int liczba = 7;
string wynik = (liczba % 2 == 0) ? "parzysta" : "nieparzysta";
Console.WriteLine($"Liczba {liczba} jest {wynik}.");

//5
int liczba2 = 5;
int wynik2 = liczba2 << 1;
Console.WriteLine($"Liczba {liczba2} po przesunięciu bitowym w lewo (mnożenie przez 2) daje: {wynik2}");

//6
int liczba3 = 10;
int wynik3 = liczba3 >> 1;
Console.WriteLine($"Liczba {liczba3} po przesunięciu bitowym w prawo (dzielenie przez 2) daje: {wynik3}");

//7
var liczba4 = 42.5; // Kompilator wywnioskuje, że to double, przetestuj dla innych liczb      
Console.WriteLine($"Zmienna zadeklarowana z 'var' ma wartość: {liczba4}");

//8
Console.Write("Podaj znak: ");
string input = Console.ReadLine() ?? "Brak tekstu"; ; // Odczytaj wiersz z klawiatury
char znak = (input ?? "A")[0]; // Jeśli wejście jest puste, użyj domyślnego znaku 'A'

int asciiValue = znak; // Zamień znak na jego wartość ASCII -- doczytaj czym są kody ASCII i gdzie się je wykorzystuje
Console.WriteLine($"\nWartość ASCII dla '{znak}' to: {asciiValue}");

Console.WriteLine("Naciśnij Enter, aby kontynuować...");
Console.ReadLine();

//9
/*
 * | Liczba (dziesiętna) | System ósemkowy | System szesnastkowy | System binarny |
 * |---------------------|-----------------|---------------------|----------------|
 * | 4                   | 4               | 4                   | 100            |
 * | 256                 | 400             | 100                 | 100000000      |
 * | 64                  | 100             | 40                  | 1000000        |
*/
int liczba5 = 64;

// Konwersja do systemu ósemkowego
string liczbaOsemkowa = Convert.ToString(liczba5, 8);

// Konwersja do systemu szesnastkowego
string liczbaSzesnastkowa = Convert.ToString(liczba5, 16).ToUpper();

// Konwersja do systemu binarnego
string liczbaBinarna = Convert.ToString(liczba5, 2);

// Wyświetlanie wyników
Console.WriteLine($"Liczba {liczba5} w systemie ósemkowym: {liczbaOsemkowa}");
Console.WriteLine($"Liczba {liczba5} w systemie szesnastkowym: {liczbaSzesnastkowa}");
Console.WriteLine($"Liczba {liczba5} w systemie binarnym: {liczbaBinarna}");


//10
// Wyświetlamy liczby od 0 do 15 w systemie szesnastkowym
Console.WriteLine("0 w systemie szesnastkowym: " + 0.ToString("X"));
Console.WriteLine("1 w systemie szesnastkowym: " + 1.ToString("X"));
Console.WriteLine("2 w systemie szesnastkowym: " + 2.ToString("X"));
Console.WriteLine("3 w systemie szesnastkowym: " + 3.ToString("X"));
Console.WriteLine("4 w systemie szesnastkowym: " + 4.ToString("X"));
Console.WriteLine("5 w systemie szesnastkowym: " + 5.ToString("X"));
Console.WriteLine("6 w systemie szesnastkowym: " + 6.ToString("X"));
Console.WriteLine("7 w systemie szesnastkowym: " + 7.ToString("X"));
Console.WriteLine("8 w systemie szesnastkowym: " + 8.ToString("X"));
Console.WriteLine("9 w systemie szesnastkowym: " + 9.ToString("X"));
Console.WriteLine("10 w systemie szesnastkowym: " + 10.ToString("X"));
Console.WriteLine("11 w systemie szesnastkowym: " + 11.ToString("X"));
Console.WriteLine("12 w systemie szesnastkowym: " + 12.ToString("X"));
Console.WriteLine("13 w systemie szesnastkowym: " + 13.ToString("X"));
Console.WriteLine("14 w systemie szesnastkowym: " + 14.ToString("X"));
Console.WriteLine("15 w systemie szesnastkowym: " + 15.ToString("X"));

// Wyświetlamy liczby od 0 do 15 w systemie binarnym w notacji 4 bitowej
Console.WriteLine($"0 w systemie binarnym: {Convert.ToString(0, 2).PadLeft(4, '0')}");
Console.WriteLine($"1 w systemie binarnym: {Convert.ToString(1, 2).PadLeft(4, '0')}");
Console.WriteLine($"2 w systemie binarnym: {Convert.ToString(2, 2).PadLeft(4, '0')}");
Console.WriteLine($"3 w systemie binarnym: {Convert.ToString(3, 2).PadLeft(4, '0')}");
Console.WriteLine($"4 w systemie binarnym: {Convert.ToString(4, 2).PadLeft(4, '0')}");
Console.WriteLine($"5 w systemie binarnym: {Convert.ToString(5, 2).PadLeft(4, '0')}");
Console.WriteLine($"6 w systemie binarnym: {Convert.ToString(6, 2).PadLeft(4, '0')}");
Console.WriteLine($"7 w systemie binarnym: {Convert.ToString(7, 2).PadLeft(4, '0')}");
Console.WriteLine($"8 w systemie binarnym: {Convert.ToString(8, 2).PadLeft(4, '0')}");
Console.WriteLine($"9 w systemie binarnym: {Convert.ToString(9, 2).PadLeft(4, '0')}");
Console.WriteLine($"10 w systemie binarnym: {Convert.ToString(10, 2).PadLeft(4, '0')}");
Console.WriteLine($"11 w systemie binarnym: {Convert.ToString(11, 2).PadLeft(4, '0')}");
Console.WriteLine($"12 w systemie binarnym: {Convert.ToString(12, 2).PadLeft(4, '0')}");
Console.WriteLine($"13 w systemie binarnym: {Convert.ToString(13, 2).PadLeft(4, '0')}");
Console.WriteLine($"14 w systemie binarnym: {Convert.ToString(14, 2).PadLeft(4, '0')}");
Console.WriteLine($"15 w systemie binarnym: {Convert.ToString(15, 2).PadLeft(4, '0')}");

//11
// Zmienna typu int (może przechowywać liczby całkowite, w tym ujemne)
int intVar = 100;
Console.WriteLine($"intVar (int): {intVar}");

// Zmienna typu unsigned int (może przechowywać liczby całkowite dodatnie)
uint unsignedIntVar = 100;
Console.WriteLine($"unsignedIntVar (unsigned int): {unsignedIntVar}");

// Zmienna typu float (typ danych zmiennoprzecinkowych)
float floatVar = 100.5f;
Console.WriteLine($"floatVar (float): {floatVar}");

// Zmienna typu double (typ danych zmiennoprzecinkowych o wyższej precyzji niż float)
double doubleVar = 100.123456789;
Console.WriteLine($"doubleVar (double): {doubleVar}");

// Dzielenie z różnymi typami danych
int intDivision = intVar / 3;
Console.WriteLine($"intVar / 3 = {intDivision}");

float floatDivision = floatVar / 3.0f;
Console.WriteLine($"floatVar / 3.0f = {floatDivision}");

double doubleDivision = doubleVar / 3.0;
Console.WriteLine($"doubleVar / 3.0 = {doubleDivision}\n");

// Zakres typu float
Console.WriteLine("Typ: float");
Console.WriteLine($"Minimalna wartość: {float.MinValue}");
Console.WriteLine($"Maksymalna wartość: {float.MaxValue}");
Console.WriteLine($"Precyzja: {7} cyfr znaczących\n");

// Zakres typu double
Console.WriteLine("Typ: double");
Console.WriteLine($"Minimalna wartość: {double.MinValue}");
Console.WriteLine($"Maksymalna wartość: {double.MaxValue}");
Console.WriteLine($"Precyzja: {15} cyfr znaczących\n");

// Zakres typu decimal
Console.WriteLine("Typ: decimal");
Console.WriteLine($"Minimalna wartość: {decimal.MinValue}");
Console.WriteLine($"Maksymalna wartość: {decimal.MaxValue}");
Console.WriteLine($"Precyzja: {28} cyfr znaczących\n");

Console.ReadLine();
