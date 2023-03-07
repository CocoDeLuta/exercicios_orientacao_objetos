using System;

public class ContagemRegressiva{
    public static void Main(){
        Console.WriteLine("Digite um numero para a contagem");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num < 0){
            Console.WriteLine("O numero é negativo, o programa será encerrado");
        }else{
            while(num >= 0){
                Console.WriteLine(num);
                num--;
            }
        }
    }
}