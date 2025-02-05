class Program{

    static void Main(string[] args){

        //Exercício 01

        /*System.Console.WriteLine("Insira um número: ");
        var numero1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Insira o segundo número: ");
        var numero2 = int.Parse(Console.ReadLine());

        var soma = numero1 + numero2;
        var sub = numero1 - numero2;
        var mult = numero1 * numero2;
        double div = numero1 / numero2;

        System.Console.WriteLine($"Soma: {soma}");
        System.Console.WriteLine($"Subtração: {sub}");
        System.Console.WriteLine($"Multiplicação {mult}");
        System.Console.WriteLine($"Divisão: {div}"); */

        //Exercício 02

        /*System.Console.WriteLine("Insira uma valor: ");
        float valor = float.Parse(Console.ReadLine());

        double desconto = valor - (valor * 0.1);

        System.Console.WriteLine($"O desconto é de {desconto}");*/

        //Exercício 03

        /*for(int numero3 = 0; numero3 < 21; numero3 ++ ){

            if(numero3 % 2 == 0){

                System.Console.WriteLine($"{numero3}");

            }

        }*/

        //Exercício 04

        /*System.Console.WriteLine("Insira um número: ");
        var numero4 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Insira o segundo número: ");
        var numero5 = int.Parse(Console.ReadLine());

        int soma1 = 0;

        for(int i = numero4; i <= numero5; i ++ ){

            soma1 += i;

        }

        System.Console.WriteLine($"A soma dos números no intervalo do número {numero4} e número {numero5} é {soma1}");*/

        //Exercício 05

         /*int[] vetor = new int[5];

         for(int i1 = 0; i1 < 5; i1 ++){

            System.Console.WriteLine($"Insira o {i1 + 1}° :");
            var numero6 = int.Parse(Console.ReadLine());
            vetor[i1] = numero6;
            
         }

         for (int i2 = 4; i2 >= 0; i2--){

            System.Console.WriteLine($"{vetor[i2]}");

         }*/

         //Exercício 06

         /*int[] vetor1  = new int[5];

         for(int i3 = 0; i3 < 5; i3 ++){

            System.Console.WriteLine($"Insira o {i3 + 1}° número: ");
            var numero7 = int.Parse(Console.ReadLine());
            vetor1[i3] = numero7;

         }

         for(int i4 = 0; i4 < 5; i4 ++){

            System.Console.WriteLine("Insira um número para conferir se esta no vetor: ");    
            var numero8 = int.Parse(Console.ReadLine());

            if(numero8 == vetor1[i4]){

                System.Console.WriteLine($"Este número esta na posiçaõ {i4 + 1} do vetor");
                return;
            }    

            else{

                System.Console.WriteLine($"Este número não esta na posição {i4 + 1} do vetor");
            }
         }*/

         //Exercício 07

         /*System.Console.WriteLine("Insira a 1ª nota: ");
         float numero9 = float.Parse(Console.ReadLine());
         System.Console.WriteLine("Insira a 2ª nota: ");
         float numero10 = float.Parse(Console.ReadLine());
         System.Console.WriteLine("Insira a 3ª nota: ");
         float numero11 = float.Parse(Console.ReadLine());

         var media = (numero9 + numero10 + numero11) / 3;

         System.Console.WriteLine($"A média dessas notas é {media}");*/

         //Exercício 08

        /* System.Console.WriteLine("Insira um número: ");
         var numero12 = int.Parse(Console.ReadLine());

         for(int i5 = 2; i5 < numero12; i5 ++){

            if(numero12 %  i5 == 0){

                System.Console.WriteLine($"O número {numero12} não é primo.");
                return;
            
            }
        }

        System.Console.WriteLine($"O número {numero12} é primo.");*/

        //Exercício 09

        System.Console.WriteLine("Insira a marca do carro: ");
        var marca = (Console.ReadLine());
        System.Console.WriteLine("Insira o modelo do carro: ");
        var modelo = (Console.ReadLine());
        System.Console.WriteLine("Insira o ano do carro: ");
        var ano = (Console.ReadLine);

        
}
}
