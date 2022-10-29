int kontrol, enbuyuksayi, index;

int[] sayidizisi = {2515,21,21541,2,54,8200,217,82,251,92,11212,99};

index = 0;
enbuyuksayi = sayidizisi[0]; // ilk indisi büyük mü diye sormak için ilk eleman olarak alıyoruz


for (int i=0; i<sayidizisi.Length; i++)
{
    kontrol = sayidizisi[i];
    if (kontrol>enbuyuksayi)
    {
        enbuyuksayi = sayidizisi[i];
        index= i;
    }
    Console.WriteLine("[{0}]", sayidizisi[i]);
}
Console.WriteLine($"Dizinin En büyük Elemanı [{index}] indexinde yer alan '{enbuyuksayi}'değeridir");


