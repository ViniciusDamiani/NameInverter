
//Inicia a aplicação
InverterName_Load();

static void InverterName_Load()
{
    //Recebe todos os nomes 
    string sFirstName = "";
    string sSecondName = "";
    string sThirdName = "";
    string sFourthName = "";
    string sFifthName = "";
     
    string sAuxFirstName  = "";
    string sAuxSecondName = "";
    string sAuxThirdName  = "";
    string sAuxFourth     = "";
    string sAuxFifth      = "";


    //Recebe o nome impresso na tela
    string sRecieveName = "";

    Console.WriteLine("<--- Bem vindo(a) ao inversor de nomes ---> \nA regra é simples, informe um nome e ele será trocado! \nPreciona ENTER para iniciar");
    //Após o usuário precionar ENTER, inicia a aplicação
    Console.ReadKey();

    //Captura os nomes
    for (int i = 1; i <= 5; i++)
    {
        Console.Write("Informe o nome de Número " + i + ": ");
        sRecieveName = Console.ReadLine();

        switch (i)
        {
            case 1:
                sFirstName = sRecieveName;
                break;

            case 2:
                sSecondName = sRecieveName;
                sAuxSecondName = sFirstName;
                break;

            case 3:
                sThirdName = sRecieveName;
                sAuxThirdName = sSecondName;
                break;

            case 4:
                sFourthName = sRecieveName;
                sAuxFourth = sThirdName;
                break;

            case 5:

                sFifthName = sRecieveName;
                sAuxFifth = sFourthName;
                sAuxFirstName = sFifthName;
                break;
        }
    }
    Console.WriteLine("\nPrecione ENTER para ver o resultado...");
    Console.ReadKey();

    Console.WriteLine("A sequência correta digitada foi\n");
    Console.WriteLine("O 1º nome que você digitou foi: " + sFirstName + "\n" +
                      "O 2º nome que você digitou foi: " + sSecondName + "\n" +
                      "O 3º nome que você digitou foi: " + sThirdName + "\n" +
                      "O 4º nome que você digitou foi: " + sFourthName + "\n" +
                      "O 5º nome que você digitou foi: " + sFifthName);


    Console.WriteLine("\nPrecione ENTER para ver a sequência trocada...\n");
    Console.ReadKey();

    Console.WriteLine("A sequência trocada digitada foi");
    Console.WriteLine("O 1º nome que você digitou foi: " + sAuxFirstName + "\n" +
                      "O 2º nome que você digitou foi: " + sAuxSecondName + "\n" +
                      "O 3º nome que você digitou foi: " + sAuxThirdName + "\n" +
                      "O 4º nome que você digitou foi: " + sAuxFourth + "\n" +
                      "O 5º nome que você digitou foi: " + sAuxFifth) ;

    //Sai da aplicação
    Console.ReadKey();
}


