//Spotify test
string mensagemDeBoasVindas = "Boas Vindas ao Spotify Test";

void ExibirMensagemDeVoasVindas()
{
    Console.WriteLine("------------------------------------");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("------------------------------------");
}

//Criando Menu Para Selecionar As Opções
void ExibirOpcoesMenu()
{
    Console.WriteLine("\n1 - Registrar uma banda");
    Console.WriteLine("2 - Mostrar Bandas");
    Console.WriteLine("3 - Sair");
    
    //Input do usuário
    Console.Write("\nSelecione uma opção: ");

    //Armazenando Input do usuário
    // "!" = Faz comm que não recebe NULL
    string opcaoEscolhida = Console.ReadLine()!;

    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);


    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarUmaBanda();
            break;
        case 2: MostrarListNomeBanda();
            break;
        case 3:
            Console.WriteLine("Foi um prazer!!");
            break;
        default: Console.WriteLine("\nOpção Invalida!!");
            break;
    }

}

//Criando um list para salvar o nome das bandas
List<string> listNomeBanda = new List<string> { "AC/DC","Teste"};

//Registro de bandas
void RegistrarUmaBanda()
{
    Console.Clear();
    Console.Write("\nDigite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    Console.WriteLine($"\nA banda {nomeBanda} foi cadastrada com sucesso!!");
    listNomeBanda.Add(nomeBanda);
    Thread.Sleep(3000);
    Console.Clear();
    ExibirOpcoesMenu();
}

//Mostrar bandas da listNomeBanda
void MostrarListNomeBanda ()
{   Console.Clear();
    
    /*for (int i = 0; i < listNomeBanda.Count; i++)
    {
        Console.WriteLine($"Banda: {listNomeBanda[i]}");
    }*/
    
    foreach (string banda in listNomeBanda)
    {
        Console.WriteLine($"Nome: {banda}");
    }

    Console.WriteLine("Digite uma tecla para voltar ao menu!!");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

ExibirMensagemDeVoasVindas();
ExibirOpcoesMenu();