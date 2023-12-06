// Screen Sound
using System.Runtime.CompilerServices;

string mensagemDeBoasVindas = "Bem vindo ao Screen Sound";
//List<string> listasDasBandas = new List<string>();

Dictionary<string, List<int>>bandasRegistradas = new Dictionary<string, List<int>>();

bandasRegistradas.Add("Led Zeppelin", new List<int> { 10, 9,10});
bandasRegistradas.Add("Black Sabbath", new List<int> { 8, 10, 6});

ExibirLogo();
ExibirOpcoesDoMenu();
void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}
void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registra uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média da banda");
    Console.WriteLine("Digite 5 para sair");

    Console.Write("\nDigite uma opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarBandas();
            break;
        case 4: mediaBandas();
            break;
        case 5: Console.WriteLine("Tchau Tchau");
            break;
        default: Console.WriteLine("opção inválida");
            break;
    }

}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTitulosDaOpcao("Registro das Bandas");
    Console.Write("\nDigite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    //ExibirLogo();
    ExibirOpcoesDoMenu();

}
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTitulosDaOpcao("Exibindo todas as bandas listadas");
    //for(int i = 0; i < listasDasBandas.Count; i++)
    // {
    //   Console.WriteLine($"Banda: {listasDasBandas[i]}");
    //  }

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");   
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu inicial");
    Console.ReadKey();
    Console.Clear();

    ExibirOpcoesDoMenu();

}

void ExibirTitulosDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteristicos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristicos + "\n");
}

void AvaliarBandas()
{
    // digitar qual banda vai avaliar
    // se a banda existi no dicionario >> atribuir uma nota
    // se nao existir, voltar para o menu inicial

    Console.Clear();
    ExibirTitulosDaOpcao("Avaliar Bandas");
    Console.Write("Qual banda você deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual nota a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}.");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else 
    {
        Console.WriteLine($"\nA Banda {nomeDaBanda} não foi encontrado!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void mediaBandas()
{
    Console.Clear();
    ExibirTitulosDaOpcao("Média da Banda");
    Console.WriteLine("\nDigite o nome da banda que você deseja ver a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBandas = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA media da banda {nomeDaBanda} é: {notasDaBandas.Average()}.");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA Banda {nomeDaBanda} não foi encontrado!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }


}



