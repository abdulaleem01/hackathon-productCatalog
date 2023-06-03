import { Component } from '@angular/core';
import { MyserviceService } from '../myservice.service';
import { Router } from '@angular/router';
import { ProductDetailsClass } from '../specificproduct/specificproduct.component';

@Component({
  selector: 'app-addproducts',
  templateUrl: './addproducts.component.html',
  styleUrls: ['./addproducts.component.css']
})
export class AddproductsComponent {

  //categories
  catogoryDetails:any;

  //product 
productName:any;
description:any;
price:any;
date:any;
brand:any;
categoryTypeId:any;


  constructor(private service:MyserviceService, private route : Router){}


  ngOnInit(){
    this.service.GetAllCategories().subscribe(response =>{
      console.log(response);
      this.catogoryDetails = response;



    })
  }
  addProduct(){

    const prod = new ProductDetailsClass();
    prod.productName = this.productName;
    prod.description = this.description;
    prod.categoryTypeId = this.categoryTypeId;
    prod.brand = this.brand;
    prod.date = new Date().toLocaleDateString().split('T')[0];
    prod.price = this.price;

    this.service.AddProduct(prod).subscribe(response =>{
      console.log(response);
      alert("Successfully Added");
      this.route.navigateByUrl('', { skipLocationChange: true }).then(() => {
        this.route.navigate([`/addproduct`]);})
    })
  }




}
