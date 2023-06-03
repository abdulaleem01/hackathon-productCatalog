import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { ProductDetailsClass } from './specificproduct/specificproduct.component';
import { SpecificationClass } from './specificproduct/specificproduct.component';
import { CategoriesDetails } from './addcategories/addcategories.component';


@Injectable({
  providedIn: 'root'
})
export class MyserviceService {

  constructor(private http:HttpClient) { }

  // https://localhost:7003/api/Category/getallcategories

  mainUrl:string = "https://localhost:7003/api";

  public GetAllCategories():Observable<any>{
    const url = `${this.mainUrl}/Category/getallcategories`;
    return this.http.get<any>(url);
  }




  // https://localhost:7003/api/Products/GetProductByCategoryID/1
  // https://localhost:7003/api/Products/GetProductByCategoryID/1
  public GetProductByCategoryID(productId:number):Observable<any>{
    const url = `${this.mainUrl}/Products/GetProductByCategoryID/${productId}`;
    return this.http.get<any>(url);

  }

  // https://localhost:7003/api/Products/GetAllProduct

  public GetAllProduct():Observable<any>{
    const url = `${this.mainUrl}/Products/GetAllProduct`;
    return this.http.get<any>(url);
  } 

  // https://localhost:7003/api/Products/GetProductByID/1

  public GetProductByID(id:number):Observable<any>{
    const url = `${this.mainUrl}/Products/GetProductByID/${id}`;
    return this.http.get<any>(url);
  }
  
  // https://localhost:7003/api/Specification/GetSpecificationsByProductId/1

  public GetSpecificationsByProductId(id:number):Observable<any>{
    const url = `${this.mainUrl}/Specification/GetSpecificationsByProductId/${id}`;
    return this.http.get<any>(url);
  }

  // https://localhost:7003/api/Products/DeleteProductById/2

  public DeleteProductByProductId(id:number):Observable<any>{
    const url = `${this.mainUrl}/Products/DeleteProductById/${id}`;
    return this.http.delete<any>(url);
  }
  public UpdateProduct(product:ProductDetailsClass):Observable<any>{
    const url = `${this.mainUrl}/Products/UpdateProduct`;
    return this.http.put<any>(url,product);
  }

  public AddSpecifications(spec:SpecificationClass):Observable<any>{
    const url = `${this.mainUrl}/Specification/AddSpecification`;
    return this.http.post<any>(url,spec);
  }

  // https://localhost:7003/api/Specification/DeleteSpecificationByID/44

  
  public DeleteSpecifications(specId:number):Observable<any>{
    const url = `${this.mainUrl}/Specification/DeleteSpecificationByID/${specId}`;
    return this.http.delete<any>(url);
  }


 

  public UpdateSpecfification(spec:SpecificationClass, specId:number):Observable<any>{
    const url = `${this.mainUrl}/Specification/UpdateSpecification`;
    const compSpec = {
      specificationId:specId,
      key:spec.key,
      value:spec.value,
      productId:spec.productId

    };
    return  this.http.put<any>(url,compSpec);

  }

  public AddProduct(pro:ProductDetailsClass):Observable<any>{
    const url = `${this.mainUrl}/Products/AddProduct`;
    const prod = {
        productName:pro.productName,
        description:pro.description,
        price:pro.price,
        date:pro.date,
        brand:pro.brand,
        categoryTypeId:pro.categoryTypeId
    }
    return this.http.post<any>(url,prod);

  }

  // https://localhost:7003/api/Category/DeleteCategoryById/10

  public DeleteCategoryById(id:number):Observable<any>{
    const url = `${this.mainUrl}/Category/DeleteCategoryById/${id}`;
    return this.http.delete<any>(url);
  }
  // https://localhost:7003/api/Category/UpdateCategory


  public UpdateCategory(cat:CategoriesDetails):Observable<any>{
    const url = `${this.mainUrl}/Category/UpdateCategory`;
    return this.http.put(url,cat);
  }

// https://localhost:7003/api/Category/AddCategory


  public AddCategories(categoryName:any,categoryDescription:any):Observable<any>{
    const url = `${this.mainUrl}/Category/AddCategory`;
    const cat = { categoryName:categoryName, description:categoryDescription

    }
    return this.http.post<any>(url,cat);
  }




}
