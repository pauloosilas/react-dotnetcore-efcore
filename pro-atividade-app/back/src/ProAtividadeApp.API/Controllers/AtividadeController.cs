using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using ProAtividadeApp.API.Models;

namespace ProAtividadeApp.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AtividadeController : ControllerBase
  {

    public IEnumerable<Atividade> Atividades = new List<Atividade>(){
                new Atividade(1),
                new Atividade(2),
                new Atividade(3),
            };

    [HttpGet]
    public IEnumerable<Atividade> Get()
    {
      return Atividades;
    }


    [HttpGet("{id}")]
    public Atividade Get(int id)
    {
      return Atividades.FirstOrDefault(Atividade => Atividade.Id == id);
    }

    [HttpPost]
    public IEnumerable<Atividade> Post(Atividade atividade)
    {
      return Atividades.Append<Atividade>(atividade);
    }


    [HttpPut("{id}")]
    public Atividade Put(int id, Atividade atividade)
    {
      atividade.Id = id + 1;
      return atividade;
    }


    [HttpDelete]
    public string Delete()
    {
      return "Meu primeiro Delete";
    }
  }
}
