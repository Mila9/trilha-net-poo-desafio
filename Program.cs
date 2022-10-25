using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone(numero :"123456", modelo:"modelo 2", imei:"22222", memoria:64);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");
Nokia nokia = new Nokia(numero:"321567", modelo:"modelo 1", imei:"111111", memoria:32);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");