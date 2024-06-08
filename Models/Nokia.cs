namespace DesafioPOO.Models
{
    //implementado
    public class Nokia : Smartphone//Herança da classe
    {   
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)//Herança do construtor
        {

        }
        //implementado
        public override void InstalarAplicativo(string nomeApp)//Herança do método abstract exigindo ser sobreescrito
        {
            Console.WriteLine("Instalando o aplicativo " + nomeApp + " no Nokia");
        }
    }
}