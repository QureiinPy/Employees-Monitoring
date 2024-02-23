using System.ComponentModel.DataAnnotations;

namespace web.app.Model
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Вам нужно ввести имя сотрудника")]
        [StringLength( 30, ErrorMessage = "Имя слишком длинное")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Вам нужно ввести фамилию сотрудника")]
        [StringLength(30, ErrorMessage = "Имя слишком длинное")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Вам нужно указать должность сотрудника")]
        public string Position { get; set; }
        public Employee(string name, string surname, string position)
        {
            Name = name;
            Surname = surname;
            Position = position;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} ({Position})";
        }
    }
}
