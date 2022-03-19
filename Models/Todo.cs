using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GDT.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [DisplayName("Titulo")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Title { get; set; }

        [DisplayName("Descrição")]
        public string Description { get; set; }

        [DisplayName("Concluído")]
        public bool Done { get; set; }

        [DisplayName("Criado em")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DisplayName("Última atualização")]
        public DateTime LastUpdateTime { get; set; } = DateTime.Now;

        [DisplayName("Usuário")]
        public string User { get; set; }

    }
}
