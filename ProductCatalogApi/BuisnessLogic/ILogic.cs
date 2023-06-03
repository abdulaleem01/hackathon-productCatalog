using System;
using Models;
namespace BuisnessLogic
{
    public interface ILogic
    {
        CategoryModel AddCategory(CategoryModel category);
        IEnumerable<CategoryModel> GetAllCategories();
        CategoryModel DeleteCategory(int CategoryID);
        CategoryModel UpdateCategory(CategoryModel category);

        ProductModel AddProduct(ProductModel product);
        ProductModel GetProductByID(int productId);
        IEnumerable<ProductModel> GetAllProduct();
        IEnumerable<ProductModel> GetProductByCategoryID(int CategoryId);
        ProductModel UpdateProduct(ProductModel product);
        ProductModel DeleteProductById(int ProductId);

        SpecificationModel AddSpecification(SpecificationModel specification);
        IEnumerable<SpecificationModel> GetSpecificationsByProductId(int productID);
        SpecificationModel DeleteSpecificationByID(int SpecificationID);
        SpecificationModel UpdateSpecification(SpecificationModel specification);
    }
}

