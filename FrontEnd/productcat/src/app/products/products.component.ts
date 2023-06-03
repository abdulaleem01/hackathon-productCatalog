import { Component } from '@angular/core';
import { Input } from '@angular/core';
import { SimpleChanges } from '@angular/core';
import { MyserviceService } from '../myservice.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent {
@Input() CategoryId!:number;

productList:any;


constructor(private service:MyserviceService,private route:Router){}

ngOnInit(){
  console.log(this.CategoryId);
}

ngOnChanges(changes:SimpleChanges){
let change = changes['CategoryId'];
if(change.currentValue != 0){


this.service.GetProductByCategoryID(change.currentValue).subscribe(response =>{
  console.log(response);
  this.productList = response;
})
}
else{
this.service.GetAllProduct().subscribe(response =>{
  console.log(response);
  this.productList = response;
})
}

}

NavToProduct(Id:number){
  console.log(Id);
  this.route.navigate([`/product/${Id}`]);
}



}



