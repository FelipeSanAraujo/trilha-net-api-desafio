namespace TrilhaApiDesafio.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public EnumStatusTarefa Status { get; set; }

        public void Atualizar(Tarefa tarefa)
        {
            Titulo = tarefa.Titulo;
            Descricao = tarefa.Descricao;
            Data = tarefa.Data;
            Status = tarefa.Status;
        }
    }
}