import React from 'react';
import Atividade from './Atividade';
 

export default function AtividadeLista(props){
  console.log(props.atividades);
  return(
    <div className="mt-3">     
      {props.atividades.map((ativ) => (
      <Atividade 
          key={ativ.id} 
          ativ = {ativ}
          pegarAtividade = {props.pegarAtividade}
          deletarAtividade = {props.deletarAtividade}
      />

      ))}   

</div>
  );
}