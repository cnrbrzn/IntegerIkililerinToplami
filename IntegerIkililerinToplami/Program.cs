//Algoritma
//Ekrandan girilen n tane integer ikililerin toplamını alan, eğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran, sayılar aynıysa toplamının karesini ekrana yazdıran console uygulamasını yazınız.

//Örnek Input: 2 3 1 5 2 5 3 3

//Output: 5 6 7 81

string str = Console.ReadLine();
string[] numbers = str.Split(' ');
for(int i=0;i<numbers.Length;i=i+2)
{
    int values = Convert.ToInt32(numbers[i]);
    int values2 = Convert.ToInt32(numbers[i+1]);
    if (values != values2)
    {
        Console.Write(values + values2 + " ");
    }
    else
        Console.Write((values + values2) * (values + values2) + " ");
}