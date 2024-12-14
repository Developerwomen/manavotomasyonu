namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> toptanciMeyveListesi = new List<string> { "Elma", "Armut", "Muz" };
            List<string> toptanciSebzeListesi = new List<string> { "Patates", "Domates", "Havuç" };
            List<string> manavMeyveListesi = new List<string>();
            List<string> manavSebzeListesi = new List<string>();
            List<string> musteriListesi = new List<string>();

            Console.WriteLine("Hoşgeldiniz! Meyve için M, Sebze için S'ye basınız.");
            string secim = Console.ReadLine();

            if (secim == "M" || secim == "S")
            {
                while (true)
                {
                    if (secim == "M")
                    {
                        Console.WriteLine("Toptancı Meyve Listesi:");
                        foreach (var meyve in toptanciMeyveListesi)
                        {
                            Console.WriteLine(meyve);
                        }
                    }
                    else if (secim == "S")
                    {
                        Console.WriteLine("Toptancı Sebze Listesi:");
                        foreach (var sebze in toptanciSebzeListesi)
                        {
                            Console.WriteLine(sebze);
                        }
                    }

                    Console.Write("Almak istediğiniz meyve veya sebze: ");
                    string urun = Console.ReadLine();

                    Console.Write("Kaç kilo almak istersiniz?: ");
                    double kilo = Convert.ToDouble(Console.ReadLine());

                    if (secim == "M")
                    {
                        manavMeyveListesi.Add($"{urun} - {kilo}kg");
                    }
                    else if (secim == "S")
                    {
                        manavSebzeListesi.Add($"{urun} - {kilo}kg");
                    }

                    Console.Write("Başka bir arzunuz var mı? (Evet-E, Hayır-H): ");
                    string devamEt = Console.ReadLine().ToUpper();

                    if (devamEt == "H")
                    {
                        break; 
                    }
                    Console.WriteLine("Meyve için M, Sebze için S'ye basınız.");
                    secim = Console.ReadLine();
                }
            }
            Console.WriteLine("Müşteri Bölümüne Hoşgeldiniz.");
            Console.WriteLine("Meyve için M, Sebze için S'ye basınız.");

            string musteriSecim = Console.ReadLine();

            if (musteriSecim == "M" || musteriSecim == "S")
            {
                while (true)
                {
                    if (musteriSecim == "M")
                    {
                        Console.WriteLine("Manav Meyve Listesi:");
                        foreach (var meyve in manavMeyveListesi)
                        {
                            Console.WriteLine(meyve);
                        }
                    }
                    else if (musteriSecim == "S")
                    {
                        Console.WriteLine("Manav Sebze Listesi:");
                        foreach (var sebze in manavSebzeListesi)
                        {
                            Console.WriteLine(sebze);
                        }
                    }

                    Console.Write("Almak istediğiniz meyve veya sebze: ");
                    string musteriUrun = Console.ReadLine();

                    Console.Write("Kaç kilo almak istersiniz?: ");
                    double musteriKilo = Convert.ToDouble(Console.ReadLine());

                   
                    bool urunBulundu = false;
                    if (musteriSecim == "M")
                    {
                        foreach (var meyve in manavMeyveListesi)
                        {
                            var parts = meyve.Split('-');
                            var urunAdi = parts[0].Trim();
                            var urunKilo = Convert.ToDouble(parts[1].Replace("kg", "").Trim());

                            if (urunAdi == musteriUrun && urunKilo >= musteriKilo)
                            {
                                musteriListesi.Add($"{musteriUrun} - {musteriKilo}kg");
                                urunBulundu = true;
                                break;
                            }
                        }
                    }
                    else if (musteriSecim == "S")
                    {
                        foreach (var sebze in manavSebzeListesi)
                        {
                            var parts = sebze.Split('-');
                            var urunAdi = parts[0].Trim();
                            var urunKilo = Convert.ToDouble(parts[1].Replace("kg", "").Trim());

                            if (urunAdi == musteriUrun || urunKilo >= musteriKilo)
                            {
                                musteriListesi.Add($"{musteriUrun} - {musteriKilo}kg");
                                urunBulundu = true;
                                break;
                            }
                        }
                    }

                    if (!urunBulundu)
                    {
                        Console.WriteLine("Ürün yeterli miktarda bulunamadı.");
                    }

                    Console.Write("Başka bir arzunuz var mı? (Evet-E, Hayır-H): ");
                    string musteriDevamEt = Console.ReadLine();

                    if (musteriDevamEt == "H")
                    {
                        break;
                    }

                    Console.WriteLine("Meyve için M, Sebze için S'ye basınız.");
                    musteriSecim = Console.ReadLine();
                }
                Console.WriteLine("Müşteri Listesi:");
                foreach (var item in musteriListesi)
                {
                    Console.WriteLine(item);

                }
            }

        }
    }
}
