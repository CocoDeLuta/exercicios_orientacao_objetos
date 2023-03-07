using System;

public class Cadasatro{
    public static void Main(){

        int indice = 0;
        int menuOption = 5;
        int deleteIndex = 0;
        Porduto[] produto = new Porduto[indice]; 
        

        while(menuOption!=4){

            Console.WriteLine("1 - Adicionar um produto");
            Console.WriteLine("2 - Apagar um produto");
            Console.WriteLine("3 - Consultar a lista de produtos");
            Console.WriteLine("4 - Encerrar");
            menuOption = Convert.ToInt32(Console.ReadLine());

            switch(menuOption){
                case 1:
                    //menu adicionar
                    indice++;
                    Array.Resize(ref produto, indice);
                    Console.WriteLine("Informe o nome do produto");
                    produto[indice-1].nome = Console.ReadLine();
                    Console.WriteLine("Informe o preço do produto");
                    produto[indice-1].preco = float.Parse(Console.ReadLine());
                break;
                case 2:
                    //menu apagar
                    Console.WriteLine("Selecione o produte que quer apagar");
                    for(int i=0; i<indice; i++){
                        Console.WriteLine(i+" "+produto[i].nome);
                        Console.WriteLine("");
                    }
                    deleteIndex = Convert.ToInt32(Console.ReadLine());
                    //deletar os dados do produto a ser apagado
                    for(int i=deleteIndex; i<(indice-deleteIndex); i++){
                        produto[i] = produto[i+1];
                    }
                    //deletar o ultimo indice pois ficou duplicado
                    indice--;
                    Array.Resize(ref produto, indice);

                break;
                case 3:
                    //menu consultar
                    for(int i=0; i<indice; i++){
                        Console.WriteLine(produto[i].nome);
                        Console.WriteLine(produto[i].preco);
                        Console.WriteLine("");
                    }
                break;
                case 4:
                    //encerrar
                break;
                default:
                    Console.WriteLine("Opção inváalida");
                break;
            }
        
        }
        
        for(int i=0; i<indice; i++){
            Console.WriteLine(produto[i].nome);
            Console.WriteLine(produto[i].preco);
            Console.WriteLine("");
        }
    }

    public struct Porduto{
        public string nome;
        public float preco;
    }
}