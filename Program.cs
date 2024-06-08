using DesafioPOO.Models;

Console.WriteLine("-------------------------------------------------------------------------------");
Console.WriteLine("-------------------------------------------------------------------------------");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 10", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.ExibirDados();
nokia.InstalarAplicativo("Discord");

Console.WriteLine("-------------------------------------------------------------------------------");

Console.WriteLine("-------------------------------------------------------------------------------");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 15", imei: "222222222", memoria: 128);
iphone.ExibirDados();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("-------------------------------------------------------------------------------");
Console.WriteLine("-------------------------------------------------------------------------------");

Console.WriteLine("Smartphone Motorola:");
Smartphone motorola = new Motorola(numero: "4966", modelo: "Modelo 12", imei: "124816320", memoria: 128);
motorola.Ligar();
motorola.ExibirDados();
motorola.InstalarAplicativo("Onedrive");
motorola.UploadDeArquivo();

Console.WriteLine("-------------------------------------------------------------------------------");
Console.WriteLine("-------------------------------------------------------------------------------");


