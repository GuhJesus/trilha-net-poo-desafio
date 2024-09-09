using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia(numero: "123123", modelo: "Model N01", imei: "111222333444",memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Iphone iphone = new Iphone(numero: "321321", modelo: "Model N202", imei: "55778899",memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

