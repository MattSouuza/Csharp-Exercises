namespace SocialBank
{
    public class User
    {
        string email;
        string senha;

        public User (string emailEntrada, string senhaEntrada)
        {
            this.email = emailEntrada;
            this.senha = senhaEntrada;

            System.Console.WriteLine("Insira seu Email: ");
            email = Console.ReadLine();
            
            bool senhaCerta = false;
            do {
                if ((senhaEntrada.Length > 6) && (senhaEntrada.Length < 16))
                {
                    senhaCerta = true;
                } else {
                    System.Console.WriteLine("Digite sua senha novamente");
                }
            } while(!senhaCerta);

            return senha;
        }
    }
}