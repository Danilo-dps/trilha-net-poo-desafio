namespace DesafioPOO.Models
{
    public abstract class Smartphone //Classe abstrata 
    {
        public string Numero { get; set; } //implementado
        protected string Modelo;//implementado
        protected string IMEI;//implementado
        protected int Memoria;//implementado

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero; //implementado
            Modelo = modelo;//implementado
            IMEI = imei;//implementado
            Memoria = memoria;//implementado
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Número: {Numero}, Modelo: {Modelo}, IMEI: {IMEI}, Memória: {Memoria}");
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void UploadDeArquivo()
        {
            Console.WriteLine("Fazendo upload dos arquivos...");
        }

        public abstract void InstalarAplicativo(string nomeApp);// Método abstrato te obriga a implementar nas classes filhas
    }
}