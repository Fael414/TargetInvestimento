import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cadastro-pessoas',
  templateUrl: './cadastro-pessoas.component.html',
  styleUrls: ['./cadastro-pessoas.component.scss']
})
export class CadastroPessoasComponent implements OnInit {

  public cadastros_pessoa: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.GetCadastros();
    // chamada do metodo ao iniciar a aplicação
  }

  public GetCadastros(): void{
    this.http.get('https://localhost:5001/api/Cadastro_pessoa').subscribe(
      response => this.cadastros_pessoa = response,
      error => console.log(error)
    )
    // ATENÇÃO! DEVE-SE COLOCAR O ENDEREÇO DEFINITIVO DO DB AQUI
    // O metodo lista as pessoas cadastradas no Db
  }

}
