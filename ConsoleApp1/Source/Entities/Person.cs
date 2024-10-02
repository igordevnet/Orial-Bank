namespace ConsoleApp1.Source.Entities;

    public class Person
    {

        private string _Name;
        private string _Profession;
        private string _Education;
        private string _Identity;
        private DateTime _BirthDate;
        private decimal _Salary;
        private decimal _Assets;

        public string Name
        {
            get => _Name;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _Name = value;
                }
                else
                {
                    throw new ArgumentException("Insira um nome válido.");
                }
            }
        }

        public string Profession
        {
            get => _Profession;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _Profession = value;
                }
                else
                {
                    throw new ArgumentException("Insira um item válido.");
                }
            }
        }

        public string Education
        {
            get => _Education;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _Education = value;
                }
                else
                {
                    throw new ArgumentException("Insira um item válido.");
                }
            }
        }

        public string Identity
        {

            get => _Identity;

            set
            {
                if (value.Length == 11 || value.Length == 14)
                {
                    _Identity = value;
                }
                else
                {
                    throw new ArgumentException("Indentidade inválida");
                }
            }
        }

        public DateTime BirthDate
        {
            get => _BirthDate;
            set
            {
                if (value <= DateTime.Now)
                {
                    _BirthDate = value;
                }
                else
                {
                    throw new ArgumentException("Invalid birth date.");
                }
            }
        }

        public decimal Salary
        {
            get => _Salary;
            set
            {
                if (value >= 0)
                {
                    _Salary = value;
                }
                else
                {
                    throw new ArgumentException("Insira um valor positivo.");
                }
            }
        }

        public decimal Assets
        {
            get => _Assets;
            set
            {
                if (value >= 0)
                {
                    _Assets = value;
                }
                else
                {
                    throw new ArgumentException("Seu patrimônio não pode ser negativo.");
                }
            }
        }

}

