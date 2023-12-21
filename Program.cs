using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia("1199887755", "3310", "135458P158", 6000);
Smartphone iPhone = new Iphone("15324518541", "15 Pro Max", "1945722P1848", 128000);

Console.WriteLine("=============== Testing Nokia ====================");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatsapp");
Console.WriteLine("=================================================");

Console.WriteLine("");

Console.WriteLine("=============== Testing IPhone ==================");
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Instagram");
Console.WriteLine("=================================================");