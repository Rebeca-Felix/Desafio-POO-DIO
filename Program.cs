using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "99747229", modelo: "Modelo 1", imei: "123456789", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Discord");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "30654923", modelo: "Modelo 2", imei: "987654321", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Candy Crush");
