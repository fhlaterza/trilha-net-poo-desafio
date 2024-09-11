namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        //IMPLEMENTADO
        protected string Modelo;
        protected string IMEI;
        protected int Memoria;
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
            //IMPLEMENTADO
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        public void Listar()
        {
            Console.WriteLine($"Dados do Smartphone: \n" +
                            $"Numero: {Numero} \n"+
                            $"Modelo: {Modelo} \n"+
                            $"Imei: {IMEI} \n"+
                            $"Memoria: {Memoria}" );
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}