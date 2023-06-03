import { Component } from '@angular/core';
import { MyserviceService } from '../myservice.service';
import { Router,Params, Route, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-specificproduct',
  templateUrl: './specificproduct.component.html',
  styleUrls: ['./specificproduct.component.css']
})
export class SpecificproductComponent {

  constructor(private service:MyserviceService,private route:ActivatedRoute,private rou:Router){}

  productDetails:any;
  specificationDetails:any;
  AllCategories:any;

//product prameters
productId:any;
productName:any;
description:any;
price:any;
date:any;
brand:any;
categoryTypeId:any;

//for specs
key:any;
value:any;

//for spec update
kup:any;
valup:any;
specID:any;


  // {
  //   "productName": "Chair",
  //   "description": "string kdkdkd",
  //   "price": 500,
  //   "date": "10/5/2001",
  //   "brand": "plastics",
  //   "categoryTypeId": 3
  // }


  ngOnInit(){
    this.route.params.subscribe( params => {      
      console.log(params)
      // params['id']

      this.service.GetProductByID(params['id']).subscribe(response =>{
        console.log(response);
        this.productDetails = response;
        this.productId = response.productId;
        this.productName = response.productName;
        this.description = response.description;
        this.price = response.price;
        this.date = response.date;
        this.categoryTypeId = response.categoryTypeId;
        this.brand = response.brand;
      })

      this.service.GetSpecificationsByProductId(params['id']).subscribe(response =>{
        this.specificationDetails = response;
      })
      
    }

       );

       this.service.GetAllCategories().subscribe(response =>{
        this.AllCategories = response;
       })
  }

  deleteProduct(){
    this.service.DeleteProductByProductId(this.productDetails.productId).subscribe(
      response =>{
        console.log(response);
        alert("Deleted SuccessFully");
        this.rou.navigate(['/categories']);
      }
    )
  }

  UpdateProduct(){
    const prod = new ProductDetailsClass();
    prod.productId = this.productId;
    prod.productName = this.productName;
    prod.description = this.description;
    prod.categoryTypeId = this.categoryTypeId;
    prod.brand = this.brand;
    prod.date = this.date;
    prod.price = this.price;

    this.service.UpdateProduct(prod).subscribe(response =>{
      console.log(response);
      alert("Updated")
      this.rou.navigateByUrl('', { skipLocationChange: true }).then(() => {
        this.rou.navigate([`/product/${this.productId}`]);})

    })
  }

  AddSpecifications(k:any,val:any){
    const spec = new SpecificationClass();
    spec.key = k;
    spec.value = val;
    spec.productId = this.productId;
    this.service.AddSpecifications(spec).subscribe(response =>{
      console.log(response);
      this.rou.navigateByUrl('', { skipLocationChange: true }).then(() => {
        this.rou.navigate([`/product/${this.productId}`]);})
    })


  }

  DeleteSpecs(specid:number){
    console.log(specid);
    this.service.DeleteSpecifications(specid).subscribe(response =>
      {
      console.log(response);
      this.rou.navigateByUrl('', { skipLocationChange: true }).then(() => {
        this.rou.navigate([`/product/${this.productId}`]);})
    })

  }

  specUpdateButtonClick(k:any,v:any,specidd:any){
    this.kup = k;
    this.valup = v;
    this.specID = specidd;

  }

  specUpdate(){
    const spec = new SpecificationClass();
    spec.productId = this.productId;
    spec.key = this.kup;
    spec.value = this.valup;
  
  this.service.UpdateSpecfification(spec,this.specID).subscribe(response =>{
    console.log(response);
    this.rou.navigateByUrl('', { skipLocationChange: true }).then(() => {
      this.rou.navigate([`/product/${this.productId}`]);})
  })
  }

  

  

 


}

export class ProductDetailsClass{
productId:any;
productName:any;
description:any;
price:any;
date:any;
brand:any;
categoryTypeId:any;
}

export class SpecificationClass{
  // "key": "string",
  // "value": "string",
  // "productId": 0

  key:any;
  value:any;
  productId:any;
}