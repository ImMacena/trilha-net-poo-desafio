using DesafioPOO.Models;

Smartphone iphone = new Iphone("123123", "X Plus", "354-530", 128);
Smartphone nokia = new Nokia("321321", "Modelo A", "334-789", 64);

Console.WriteLine("--- Utilizando o iPhone ---");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n--- Utilizando o Nokia ---");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");