using Buscas;

int option = 0;
int[] vetor = {10,20,30,40,50,60,70,80};
Busca funcao = new Busca();

while (option != 4)
{
    Console.Write(
        "Algoritmo de Busca   \n" +
        "1 - Inserir no vetor \n" +
        "2 - Busca Binaria    \n" +
        "3 - Busca sequencial \n" +
        "4 - Sair             \n" +
        "Escolha um numero.: "
    );
    try
    {
        option = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (option)
        {
            case 1:
                vetor = funcao.inserirValor(vetor);
                break;
            case 2:
                funcao.buscaBinaria(vetor);
                break;
            case 3:
                funcao.buscaSequencial(vetor);
                break;
            case 4: break;
            default:
                Console.WriteLine("Opção desconhecida");
                break;
        }
    }
    catch(Exception ex) { Console.WriteLine("Apenas numeros são validos."); }
}




