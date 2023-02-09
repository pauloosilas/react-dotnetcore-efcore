﻿namespace ProAtividadeApp.API.Models
{
  public class Atividade
  {
    public Atividade()
    {

    }
    public Atividade(int id)
    {
      this.Id = id;
    }
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public string Prioridade { get; set; }
  }
}
