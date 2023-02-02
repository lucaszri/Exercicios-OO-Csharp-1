namespace Times
{
    internal class Program
    {
        /*Crie uma classe Time que tenha como propriedade o nome do país, 
         * nome do esporte e a pontuação dele em um torneio. 
         * Sua pontuação pode ser acrescida por um método pontua que recebe como parâmetro "W" para vitória (+3 pontos),
         * "L" para derrota (+0 pontos) e "D" para empate (+1 ponto)*/
        static void Main(string[] args)
        {
           Time time = new Time("Palmeiras" , "Futebol");

            time.Pontuar(time);
        }
    }
}