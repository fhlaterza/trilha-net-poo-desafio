using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "111234", modelo:"nokia 1", imei: "0000000000", memoria:32);
nokia.Listar();
Console.WriteLine("\n");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("\n Tecle algo para continuar...");
Console.ReadLine();
Console.WriteLine("\n");

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone(numero: "151234", modelo:"Iphone 2", imei: "999999", memoria:64);
iphone.Listar();
Console.WriteLine("\n");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
