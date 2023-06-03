using System;
using DataLayer.DbEntities;
namespace DataLayer
{
    public interface IRepo
    {

        Category AddCategory(Category category);
        IEnumerable<Category> GetAllCategories();
        Category DeleteCategory(int CategoryID);
        Category UpdateCategory(Category category);

        Product AddProduct(Product product);
        Product GetProductByID(int productId);
        IEnumerable<Product> GetAllProduct();
        IEnumerable<Product> GetProductByCategoryID(int CategoryId);
        Product UpdateProduct(Product product);
        Product DeleteProductById(int ProductId);

        Specification AddSpecification(Specification specification);
        IEnumerable<Specification> GetSpecificationsByProductId(int productID);
        Specification DeleteSpecificationByID(int SpecificationID);
        Specification UpdateSpecification(Specification specification);


    }
}

