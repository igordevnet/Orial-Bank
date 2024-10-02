namespace ConsoleApp1.Source.Entities;

    public class Client : Person
    {
        private string _Email;
        private string _Password;
        private string _Phone;
        private string _Id;

        public string Email
        {
            get => _Email;

            set
            {
                if (value.Contains("@"))
                {
                    _Email = value;
                }
                else
                {
                    throw new ArgumentException("Email inválido");
                }
            }
        }

        public string Password
        {
            get => _Password;

            set
            {
                if (value.Length >= 6)
                {
                    _Password = value;
                }
                else
                {
                    throw new ArgumentException("A senha deve ter no mínimo 6 caracteres.");
                }
            }
        }

        public string Phone
        {
            get => _Phone;

            set
            {
                if (value.Length == 11)
                {
                    _Phone = value;
                }
                else
                {
                    throw new ArgumentException("O celular deve ter 11 dígitos.");
                }
            }
        }

        public string Id { get => _Id; set => _Id = value; }
    }


}
