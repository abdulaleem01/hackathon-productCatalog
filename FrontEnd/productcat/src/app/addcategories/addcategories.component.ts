import { Component } from '@angular/core';
import { MyserviceService } from '../myservice.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-addcategories',
  templateUrl: './addcategories.component.html',
  styleUrls: ['./addcategories.component.css']
})
export class AddcategoriesComponent {

  categoryDetails:any;
  
  //Update
  ucategoryId:any;
  ucategoryName:any;
  udescription:any;

  //Add
  acatname:any;
  acatdesc:any;


  constructor(private service:MyserviceService,private route:Router){}

  ngOnInit(){
    this.service.GetAllCategories().subscribe(response =>{
      this.categoryDetails = response;
    })
    }

  deleteCategory(id:number){
console.log(id);
  this.service.DeleteCategoryById(id).subscribe(response =>{
  console.log(response);

  this.route.navigateByUrl('', { skipLocationChange: true }).then(() => {
    this.route.navigate([`/addcategories`]);})

})
  }

  UpdateClicked(name:any,description:any,id:any){
    this.ucategoryId = id;
    this.ucategoryName = name;
    this.udescription = description;
  }

  UpdateSubmit(){
    const cat = new CategoriesDetails();
    cat.categoryId = this.ucategoryId;
    cat.categoryName = this.ucategoryName;
    cat.description = this.udescription;
    this.service.UpdateCategory(cat).subscribe(response =>{
      this.route.navigateByUrl('', { skipLocationChange: true }).then(() => {
        this.route.navigate([`/addcategories`]);})
    })
  }

  AddCategory(){
    this.service.AddCategories(this.acatname,this.acatdesc).subscribe(response =>{
      console.log(response);
      this.route.navigateByUrl('', { skipLocationChange: true }).then(() => {
        this.route.navigate([`/addcategories`]);})
    })

  }






}


export class CategoriesDetails{
  // "categoryId": 0,
  // "categoryName": "string",
  // "description": "string"
  categoryId:any;
  categoryName:any;
  description:any;
}
