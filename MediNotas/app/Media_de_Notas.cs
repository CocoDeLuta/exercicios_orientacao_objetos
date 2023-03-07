using System;

public class MediaDeNotas{
    public static void Main(){
        
        double nota1, nota2, nota3;
        
        Console.WriteLine("Digite a 1 nota");
        nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a 3 nota");
        nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a 2 nota");
        nota3 = Convert.ToDouble(Console.ReadLine());
        
        if((nota1+nota2+nota3) / 3 >= 7){
            Console.WriteLine("voce passou");
        }else{
            Console.WriteLine("voce nao passou");
        }
        
        }
        
}


