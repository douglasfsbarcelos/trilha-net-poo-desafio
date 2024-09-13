using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", Modelo: "Modelo 1", IMEI: "111111111", Memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iPhone = new Iphone(numero: "654321", Modelo: "IPhone 999", IMEI: "1212121212121", Memoria: 128);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Telegram");
