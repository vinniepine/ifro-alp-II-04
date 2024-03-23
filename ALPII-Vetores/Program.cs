/*  Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
 *  C.S.T. em Análise e Desenvolvimento de Sistemas
 *  Disciplina de Algoritmo e Lógica de Programação II
 *  Professor Clayton Ferraz de Andrade
 *  
 *  Acadêmico Vinicius de Oliveira Pinheiro
 *  Aula do dia 21-08-2023
 *  - Atividade n. 01 de ALP II - Vetores
 *  - Lista de Exercícios 6.4
 */
using System.IO.Pipes;

void Exercise02()

/*  2. Dadas as temperaturas que foram registradas, diariamente,
    durante uma semana, deseja-se determinar em quantos dias
    desta semana a temperatura esteve acima da média. A solução
    para este problema envolve os seguintes passos:
    
    a) Obter os valores das temperaturas;
    b) Calcular a média desses valores;
    c) Verificar quantos deles são maiores que a média.
 */
{
    double[] weekTemperature = new double[7];
    double sum = 0, average, counter = 0;
    Console.Clear();
    Console.WriteLine("\n\n\n\n");
    for (int i = 0; i < weekTemperature.Length; i++)
    {
        Console.Write($"    Qual foi a temperatura no {i + 1}º dia? ");
        weekTemperature[i] = Convert.ToDouble(Console.ReadLine());
        sum += weekTemperature[i];
    }
    Console.Clear();
    average = sum / 7;
    Console.WriteLine("\n\n\n\n    -> A média de temperatura nesta semana foi de: " + Math.Round(average, 1));
    for (int i = 0; i < weekTemperature.Length; i++)
    {
        if (weekTemperature[i] > average)
        {
            Console.WriteLine($"    -> A temperatura do {i + 1}º dia foi acima da média");
            counter++;
        }
    }
    Console.WriteLine($"    -> {counter} dias foram acima da média");
    Console.ReadLine();
}
void Exercise03()
/*  3. Crie Vetores para armazenar:
    a) As vogais do alfabeto;
    b) As alturas de um grupo de dez pessoas;
    c) Os nomes dos meses do ano.
 */
{
    string[] vowels = new string[5];
    string[] months = new string[12];
    double[] heights = new double[10];
    for (int i = 0; i < heights.Length; i++)
    {
        Console.Clear();
        Console.Write($"\n\n\n\n    Qual é altura da {i + 1}ª pessoa? ");
        heights[i] = Convert.ToDouble(Console.ReadLine());
    }
    for (int i = 0; i < vowels.Length; i++)
    {
        Console.Clear();
        Console.Write($"\n\n\n\n    Qual é a {i + 1}ª vogal do alfabeto? ");
        vowels[i] = Console.ReadLine()!;
    }
    for (int i = 0; i < months.Length; i++)
    {
        Console.Clear();
        Console.Write($"\n\n\n\n    Qual é o {i + 1}º mês do ano? ");
        months[i] = Console.ReadLine()!;
    }
    Console.Clear();
    Console.WriteLine("\n\n\n\n    As vogais do alfabeto são: ");
    for (int i = 0; i < vowels.Length; i++)
    {
        Console.WriteLine("    " + string.Join(", ", vowels) + ".");
    }
    Console.WriteLine("\n\n    A altura das 10 pessoas registradas são: ");
    for (int i = 0; i < heights.Length; i++)
    {
        if (i == 0)
        {
            Console.WriteLine("    " + heights[i] + "; ");
        }
        else if (i == 9)
        {
            Console.WriteLine("    " + heights[i] + ".");
        }
        else
        {
            Console.WriteLine("    " + heights[i] + "; ");
        }
    }
    Console.WriteLine("\n    Os 12 meses do ano são: ");
    Console.WriteLine("    " + string.Join(", ", months) + ".");
    Console.ReadLine();
}
void Exercise07()
/*  Codifique um algoritmo Histograma, que exiba um histograma
    de variação da temperatura durante a semana. Por exemplo, 
    se as temperaturas forem 19ºC, 21ºC, 25ºC, 22ºC, 20ºC, 17ºC
    e 15ºC, de domingo a sábado, respectivamente, o algoritmo
    deverá exibir:

    D: ▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊
    S: ▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊
    T: ▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊
    Q: ▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊
    Q: ▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊
    S: ▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊
    S: ▊▊▊▊▊▊▊▊▊▊▊▊▊▊▊
    
    Suponha que as temperaturas sejam todas positivas, e que 
    nenhuma seja maior que 80ºC. Dica: crie uma rotina que exiba
    uma linha, como uma quantidade de caracteres de tamanho
    proporcional à temperatura.
 */
{
    Console.Clear();
    Console.Write("\n\n\n\n    Este algoritmo apresenta um histograma de " +
        "\n    temperaturas ao longo de uma semana. ");
    Console.ReadLine();
    Console.Clear();
    int[] weekDays = new int[7];
    int[] temperatures = new int[7];
    string[] daysName = { "domingo", "segunda-feira", "terça-feira", "quarta-feira", "quinta-feira", "sexta-feira", "sábado" };
    string[] daysNameShort = { "D", "S", "T", "Q", "Q", "S", "S" };
    for (int i = 0; i < weekDays.Length; i++)
    {
        Console.Clear();
        Console.Write($"\n\n\n\n    Qual é a temperatura de {daysName[i]}? ");
        temperatures[i] = int.Parse(Console.ReadLine()!);
    }
    Console.Clear();
    Console.WriteLine("\n\n\n\n    Histograma com as temperaturas da semana:\n");
    for (int i = 0; i < daysNameShort.Length; i++)
    {
        Console.Write($"    [{daysNameShort[i]}] {temperatures[i]}° C : ");
        int barLength = temperatures[i];
        for (int j = 0; j < barLength; j++)
        {
            if (j <= 15)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("▀");
            }
            else if (j > 15 && j <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("▀");
            }
            else if (j > 30)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("▀");
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        Console.WriteLine();
    }
    Console.ReadLine();
}
void Exercise08()
/*  Faça um algoritmo que construa dois vetores A e B
    de 10 elementos e, a partir deles, crie um vetor C,
    composto pela soma dos elemntos, sendo: 
        => C[1] = A[1] + B[10];
        => C[2] = A[2] + B[9];
        => C[3] = A[3] + B[8]...
 */
{
    Console.Clear();
    int[] groupA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] groupB = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] groupC = new int[10];
    Console.WriteLine("\n\n\n\n    Este algoritmo mostra a soma dos elementos" +
        "\n    de dois vetores (um com seuus valores crescentes," +
        "\n    e o outro decrescente em um terceiro.");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("\n\n\n\n");
    for (int i = 0, j = 9; i < groupC.Length; i++, j--)
    {
        groupC[i] = groupA[i] + groupB[j];
        Console.WriteLine($"    {groupA[i]} + {groupB[j]} = {groupC[i]};");
    }
    Console.ReadLine();
}
void Exercise09()
/*  Elabore um algoritmo que crie dois vetores A e B de 10 elementos e,
    a partir deles, crie um vetor C, composto pela união dos elementos
    A e B, dispostos em ordem crescente, exibindo o resultado.
 */
{
    Console.Clear();
    Console.Write(@"



    Este algoritmo cria dois vetores A e B de 10 elementos e, a partir deles,
    cria um vetor C, composto pela união dos elementos A e B, dispostos em 
    ordem crescente, exibindo o resultado.");
    Console.ReadLine();
    double[] A = new double[10];
    double[] B = new double[10];
    double[] C = new double[20];
    for (int i = 0; i < A.Length; i++)
    {
        Console.Clear();
        Console.Write($"\n\n\n\n    Qual valor deseja atribuir a A[{i}]? ");
        A[i] = Convert.ToDouble(Console.ReadLine()!);
        Console.Clear();
        Console.Write($"\n\n\n\n    Qual valor deseja atribuir a B[{i}]? ");
        B[i] = Convert.ToDouble(Console.ReadLine());
    }
    for (int i = 0, j = 0; i < C.Length; i++, j++)
    {
        C[i] = A[j];
        i++;
        C[i] = B[j];
    }
    Array.Sort(C);
    Console.Clear();
    Console.WriteLine($"\n\n\n\n    Resultados: \n");

    Console.Write($"    A[10] = {string.Join(",", A)}\n");
    Console.Write($"    B[10] = {string.Join(",", B)}\n");
    Console.Write($"    C[20] = {string.Join(",", C)}");
    Console.ReadLine();
}
void Lista6_4()
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write(@"
   ----------------------------------------------------------------------    
   Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
   ----------------------------------------------------------------------
   
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++      +++      ++        +++++++++++++++
          +++++++++++++++        ++      ++        +++++++++++++++
          +++++++++++++++        ++      ++        +++++++++++++++
          +++++++++++++++++.....+++      ++        +++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          +++++++++++++++        ++      ++        +++++++++++++++
          +++++++++++++++        ++      ++        +++++++++++++++
          +++++++++++++++        ++      ++        +++++++++++++++
          +++++++++++++++        ++      ++        +++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          +++++++++++++++        ++      +++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
          ++++++++++++++++++++++++++++++++++++++++++++++++++++++++

          --------------------------------------------------------
          C.S.T. em Análise e Desenvolvimento de Sistemas
          Disciplina de Algoritmo e Lógica de Programação II
          -------------------------------------------------------- 
          ");
    Console.ReadLine();
    Console.Clear();
    while (true)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write(@"


 
          C.S.T. em Análise e Desenvolvimento de Sistemas
          Disciplina de Algoritmo e Lógica II
          Professor Clayton Ferraz de Andrade
          -----------------------------------------------
          Acadêmico Vinícius de Oliveira Pinheiro
          -----------------------------------------------
          Atividade 01 - Exercícios para fixação - Vetores 
    
          Exercício [02] - Média das temperaturas;
          Exercício [03] - Vogais, alturas e meses do ano;
          Exercício [07] - Histograma de temperaturas;
          Exercício [08] - Vetores (crescentes + decrescentes);
          Exercício [09] - Soma de Vetores (lista crescente);
          Saída     [-1] - Encerra a aplicação.
        

          Qual exercício gostaria de verificar? 

          ");
        int exercise = int.Parse(Console.ReadLine()!);
        switch (exercise)
        {
            case 2 or 02: Exercise02(); break;
            case 3 or 03: Exercise03(); break;
            case 7 or 07: Exercise07(); break;
            case 8 or 08: Exercise08(); break;
            case 9 or 09: Alternate09_2(); break;
            case -1: return;
            default:
                Console.Clear();
                Console.WriteLine("    Desculpa, eu não entendi. Poderia repetir?");
                break;
        }
    }
}
Lista6_4();
void Alternate08_1()
{
    int[] groupA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] groupB = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] groupC = new int[10];

    int inverted = groupB.Length - 1;

    for (int i = 0; i < inverted; i++)
    {
        groupC[i] = groupA[i] + groupB[inverted];
        inverted--;
        Console.WriteLine($"\n\n\n\n    {groupA[i]} + {groupB[inverted]} = {groupC[i]};");
    }
}
void Alternate09_1()
{
    /*  Elabore um algoritmo que crie dois vetores A e B de 10 elementos e,
    a partir deles, crie um vetor C, composto pela união dos elementos
    A e B, dispostos em ordem crescente, exibindo o resultado.
 */
    {   // forma do GPT
        Console.Clear();
        Console.Write(@"



    Este algoritmo cria dois vetores A e B de 10 elementos e, a partir deles,
    cria um vetor C, composto pela união dos elementos A e B, dispostos em 
    ordem crescente, exibindo o resultado.");
        Console.ReadLine();
        int[] A = { 11, 13, 16, 19, 20, 25, 30, 31, 32, 34 };
        int[] B = { 11, 23, 15, 16, 34, 54, 29, 31, 30, 71 };
        int[] c = new int[A.Length + B.Length];
        int cIndex = 0;

        Array.Sort(A);
        Array.Sort(B);

        int aIndex = 0;
        int bIndex = 0;

        while (aIndex < A.Length || bIndex < B.Length)
        {
            if (aIndex < A.Length && (bIndex >= B.Length || A[aIndex] < B[bIndex]))
            {
                c[cIndex++] = A[aIndex++];
            }
            else if (bIndex < B.Length && (aIndex >= A.Length || B[bIndex] < A[aIndex]))
            {
                c[cIndex++] = B[bIndex++];
            }
            else
            {
                c[cIndex++] = A[aIndex++];
                bIndex++;
            }
        }
        Console.WriteLine("Vetor C:");
        for (int i = 0; i < cIndex; i++)
        {
            Console.Write(c[i] + " ");
        }
        Console.ReadLine();

    }/*
        Array.Sort(C);
        Console.Clear();
        Console.WriteLine($"\n\n\n\n    Resultados: \n");

        Console.Write($"    A[10] = {string.Join(",", A)}\n");
        Console.Write($"    B[10] = {string.Join(",", B)}\n");
        Console.Write($"    C[20] = {string.Join(",", C)}");
        Console.ReadLine();*/
}
void Alternate09_2()
{   // forma do Bing
    int[] A = { 32, 21, 13, 15, 27, 95, 45, 32, 67, 84 };
    int[] B = { 21, 13, 29, 24, 54, 23, 67, 66, 99, 10 };
    int[] C = new int[20];

    for (int i = 0; i < A.Length; i++)
    {
        C[i] = A[i];
        C[i + 10] = B[i];
    }

    Array.Sort(C);

    // Remove duplicates from C array
    int index = 0;
    for (int i = 0; i < C.Length - 1; i++)
    {
        if (C[i] != C[i + 1])
        {
            C[index++] = C[i];
        }
    }
    C[index++] = C[C.Length - 1];

    // Resize the C array to remove extra elements
    Array.Resize(ref C, index);

    Console.WriteLine("\nVetor A: [" + string.Join(", ", A) + "]");
    Console.WriteLine("Vetor B: [" + string.Join(", ", B) + "]");
    Console.WriteLine("Vetor C: [" + string.Join(", ", C) + "]");

    Console.ReadKey();
}
void Alternate09_3()
{   // forma do Gabriel 
    var A = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    var B = new[] { 12, 14, 11, 2, 4, 13, 16, 6, 7, 15 };
    int C_size = 0;

    var provisorio = new int?[10];
    for (int i = 0; i < A.Length; i++)
    {
        provisorio[i] = A[i];
        provisorio[A.Length + 1] = B[i];
    }
    for (int i = 0; i < provisorio.Length; i++)
    {
        for (int j = 0; j < provisorio.Length; j++) ;
        {
            if (provisorio[i] is null)
            {
                continue;
            }
        }
    }
}
void Alternate09_4()
{
    int[] A = { 12, 34, 45, 67, 45 };
    int[] B = { 12, 36, 23, 49, 40 };
    int[] C = new int[(2 * A.Length)];

    for (int i = 0; i < A.Length; i++)
    {
        C[i] = A[i];
    }

    bool tem = false;
    int position = A.Length;
    for (int i = 0; i < C.Length; i++)
    {
        for (int j = 0; j < B.Length; j++)
        {
            if (B[i] == A[j])
            {
                tem = true;
                break; //  ou "j = b.Length
            }
            else
            {
                tem = false;
            }
        }
        if (tem != true)
        {
            C[position] = B[i];
            position++;
        }
    }
    for (int i = 0; i < C.Length; i++)
    {
        if (C[i] == 0)
        {
            Console.WriteLine(C[i]);
        }
    }
}