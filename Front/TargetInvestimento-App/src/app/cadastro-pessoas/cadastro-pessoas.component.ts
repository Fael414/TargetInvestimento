import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cadastro-pessoas',
  templateUrl: './cadastro-pessoas.component.html',
  styleUrls: ['./cadastro-pessoas.component.scss']
})
export class CadastroPessoasComponent implements OnInit {

  public cadastros_pessoa: any = [];
  public cadastrosFiltrados: any = [];

  private _filtroLista: string = '';

  public get filtroLista(){
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.cadastrosFiltrados = this.filtroLista ? this.filtrarCadastros(this.filtroLista) : this.cadastros_pessoa;
    // para a devida funcionalidade do filtro de busca
  }

  filtrarCadastros(filtrarPor: string): any {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.cadastros_pessoa.filter(
      (cadastros_pessoa: any) => cadastros_pessoa.nomeCompleto.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
      cadastros_pessoa.cpf.toLocaleLowerCase().indexOf(filtrarPor) !== -1||
      cadastros_pessoa.cep.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    )
  }

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
