using DesafioPOO.Models;

Console.WriteLine("Testando Nokia");
Smartphone nokia = new Nokia(numero: "8888888", modelo: "modelo 1", imei: "123456789", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nTestando Iphone");
Smartphone iphone = new Iphone(numero: "12566685", modelo: "modelo 2", imei: "123456798", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");