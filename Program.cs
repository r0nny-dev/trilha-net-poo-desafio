using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "(75) 98234-9182", modelo: "Iphone XR", imei: "99999999999", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "(75) 98234-9182", modelo: "Nokia Lumia 360", imei: "8888888888888", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.InstalarAplicativo("Facebook");