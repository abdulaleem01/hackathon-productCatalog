import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { CategoriesComponent } from './categories/categories.component';
// import { ProductsComponent } from './products/products.component';
import { SpecificproductComponent } from './specificproduct/specificproduct.component';
import { AddproductsComponent } from './addproducts/addproducts.component';
import { AddcategoriesComponent } from './addcategories/addcategories.component';


const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'categories',component:CategoriesComponent},
  {path:'product/:id',component:SpecificproductComponent},
  {path:'addproduct',component:AddproductsComponent},
  {path:'addcategories', component:AddcategoriesComponent},


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {



  
}
