using System;
class HelloWorld {
  static void Main() {
    int escolha;
    
    Console.WriteLine("INSTAGRAM");
    Console.WriteLine("Jude Duarte \n17 anos \nRainha de Elfhame \nInteresse em lâminas e política");
    Console.WriteLine("\nO que você deseja visualizar no perfil ");
    Console.WriteLine("1- PUBLICAÇÕES ");
    Console.WriteLine("2- ESTATÍSTICAS DO PERFIL");
    escolha = Convert.ToInt32(Console.ReadLine());
    
    switch(escolha){
        case 1:
            Console.WriteLine(" Que tipo de pessoa eu poderia me tornar \n caso parasse de me preocupar com a morte, \n com a dor, com tudo? \n Caso eu parasse de tentar me encaixar nesse mundinho?\n Em vez de ficar com medo,\n eu poderia ser a fonte do temor.\n -Jude Duarte");
            Console.WriteLine(" \n Se você me machucasse eu não choraria. \n Eu machucaria você também. \n -Jude Duarte ");
            break;
            
        case 2:
            Console.WriteLine("ESTATÍSTICAS DO PERFIL");
            int seguidores = 2018;
            Console.WriteLine($"SEGUIDORES: {seguidores}");
            float visu;
            visu = seguidores / 3;
            Console.WriteLine($"NÚMERO MÉDIO DE VISUALIZAÇÕES: {visu}");
            Console.WriteLine($"ENTROU EM: 02 de janeiro de 2018 ");
            break;
    }
    
  }
}