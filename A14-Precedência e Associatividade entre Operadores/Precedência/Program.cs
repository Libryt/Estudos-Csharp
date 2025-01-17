//#Ordem de Precedência:

        double a = 10;
        double b = 5;
        double c = 3;
        double resultado = ++a * b + c / 2 - (a % b) + (a > b && c < b ? a : b);
        //Primeiro parênteses: a%b = 0 -> (10 > 5[true]) E[&&] (3 < 5[true]) SE ambos[&&] True, retorna 10 senão retorna 5.
        //++a*b+c/2-0+10
        //Segundo pré-incremento: ++10 = 11
        //Terceiro Aritméticos: 11*5=55+1,5
        //Ficando:11*5+3/2-0+10 = 66,5
        // A ordem de precedência é:
        // 1. Operadores de incremento (++a)
        // 2. Operadores aritméticos (*, /, %)
        // 3. Operadores aritméticos (+, -)
        // 4. Operadores relacionais (>)
        // 5. Operador lógico (! && ||)
        // 6. Operador condicional (? :)

        Console.WriteLine(resultado); // Saída: 66,5
        Console.ReadKey();