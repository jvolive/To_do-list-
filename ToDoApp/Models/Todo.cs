using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [DisplayName("Nome do usuario")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Name { get; set; }
        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Description { get; set; }
        [DisplayName("Inicio da Tarefa")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime StartDate { get; set; } = DateTime.Now;
        [DisplayName("Final da Tarefa")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime EndDate { get; set; } = DateTime.Now;
    }
}