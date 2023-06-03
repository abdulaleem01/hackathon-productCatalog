import { Component } from '@angular/core';
import { MyserviceService } from '../myservice.service';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.css']
})
export class CategoriesComponent {

  categoryList:any;
  categoryIDD:number = 0;
  constructor(private service:MyserviceService){}

  ngOnInit(){
    this.service.GetAllCategories().subscribe(response =>{
      console.log(response);
      this.categoryList = response;
    })
  }


  changeNav(id:number){
    this.categoryIDD = id;
  }
}
