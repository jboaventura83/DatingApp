import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-pessoa',
  templateUrl: './pessoa.component.html',
  styleUrls: ['./pessoa.component.css']
})
export class PessoaComponent implements OnInit {
  pessoas: any;
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getPessoas();
  }

  getPessoas() {
    this.http.get('http://localhost:5000/api/pessoas').subscribe(response => {
      this.pessoas = response;
    }, error => {
      console.log(error);
    });
  }

}
