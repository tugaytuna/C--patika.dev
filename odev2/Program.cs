
//create new array
int[] ciftrakamlar = new int[6];

//adding values
for (int i = 0, j = 0; i<=10; i++)
{
    if (i % 2 == 0)
    {
        ciftrakamlar[j] = i;
         j++;
    }
}


//read the array

for (int i = 0; i<ciftrakamlar.Length;i++)
{
    Console.WriteLine(ciftrakamlar[i]);
}



