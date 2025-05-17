
using System.Runtime.CompilerServices;

Console.WriteLine("Lütfen aşağıdaki bilgileri doldurunuz:");
Console.WriteLine("T.C. Kimlik numaranız: ");
string kmlk ;
kmlk = Console.ReadLine();
Console.WriteLine("Adı:");
string ısım ;
ısım = Console.ReadLine();
Console.WriteLine("Soyadı:");
string soy;
soy = Console.ReadLine();
Console.WriteLine("Telefon no :");
string tlfn;
tlfn = Console.ReadLine();
Console.WriteLine("yaş:");
int yas;
yas = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("İlk aldığınız ürünün fiyatı ?");
int fyt1;
fyt1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("İkinci aldığınız ürünün fiyatı ?");
int fyt2;
fyt2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine(kmlk + " TC numaralı " + ısım + " " +  soy + " isimli kişi için kayıt oluşturulmuştur." );
Console.WriteLine (tlfn + "telefon numarasına bildirim mesajı gönderilmiştir.");
Console.WriteLine((fyt1 + fyt2) + " toplam harcama karşılığında kazanılan puan ---> 50 " );
