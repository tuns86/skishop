import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from './layout/header/header.component';
import { Pagination } from './shared/models/pagination';
import { Product } from './shared/models/products';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, HeaderComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent implements OnInit{
  baseUrl = 'https://localhost:5001/api/'
  private http = inject(HttpClient)
  title = 'Skishop';
  products: Product[] = [];

  ngOnInit(): void {
    this.http.get<Pagination<Product>>(this.baseUrl + 'products').subscribe({
      next: (response: any) => { // Tạm sử dụng kiểu `any` nếu cần
        this.products = response as Product[]; // Gán và ép kiểu response
      },
      error: error => console.log(error),
      complete: () => console.log('complete')
    })
  }

}
