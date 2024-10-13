

using Abstraindo_um_celular_em_C_Sharp.Models;

Smartphone telNokia = new Nokia("Nokiax13", "Nokia", "23232323323", 128);

telNokia.InstalarAplicativo("WhatsApp");
telNokia.Ligar();
telNokia.ReceberLigacao();

Console.WriteLine("\n");

Smartphone telIphone = new Iphone("Iphone14", "Iphone", "3237189332", 520);

telIphone.InstalarAplicativo("Telegram");
telIphone.Ligar();
telIphone.ReceberLigacao();