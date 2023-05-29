namespace BB2
{
    public class Exercice2
    {

        //Console.Write("Escreva uma palavra: ");
        //Console.Write(Console.ReadLine());
        //Console.Write(BuscaBinariaPalavras("Thieres","Thiago"));
        static int BuscaBinariaPalavras(string palavra1, string palavra2)
        {
            palavra1 = palavra1.ToLower();
            palavra2 = palavra2.ToLower();
            int cont = (palavra1.Length > palavra2.Length) ? palavra2.Length : palavra1.Length;
            for (int i = 0; i < cont; i++)
            {
                if (BuscaBinaria(palavra1[i]) > BuscaBinaria(palavra2[i]))
                    return 1;
                else if (BuscaBinaria(palavra1[i]) < BuscaBinaria(palavra2[i]))
                    return -1;
            }
            return palavra1.Length == palavra2.Length
                ? 0
                : (palavra1.Length > palavra2.Length ? 1 : -1);

            static int BuscaBinaria(char letra, int Index = 0, int Init = 0)
            {
                List<char> letras = new List<char>() {
                    'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'
                };
                if (Index == 0)
                {
                    Index = letras.Count;
                }
                List<char> lst = letras.GetRange(Init, Index / 2);
                if (letra == letras[Init])
                {
                    return Init;
                }
                else
                {
                    return BuscaBinaria(
                    letra, Index / 2,
                    lst.Contains(letra) ? Init : Index / 2 + Init
                    );
                }
            }
        }
    }
}


