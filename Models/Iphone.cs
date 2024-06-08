namespace DesafioPOO.Models
{
    //implementado
    public class Iphone : Smartphone//herança da classe
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)//herança do construtor
        {

        }
        //implementado
         public override void InstalarAplicativo(string nomeApp)//Herança do método abstract exigindo ser sobreescrito
        {
            Console.WriteLine("Instalando o aplicativo " + nomeApp + " no Iphone");
        }
    }
}