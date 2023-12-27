using DesafioPOO.Models;

Console.WriteLine("Nokia");
Nokia nk1 = new Nokia(numero: "123456", modelo: "modelo 1", imei: "111111111", memoria: 64);
nk1.Ligar();
nk1.InstalarAplicativo("Whatsapp");
Console.WriteLine("----------------------------");
Console.WriteLine("Iphone");
Iphone iph1 = new Iphone(numero: "4987", modelo: "modelo 2", imei: "2222222", memoria: 128);
iph1.ReceberLigacao();
iph1.InstalarAplicativo("Telegram");