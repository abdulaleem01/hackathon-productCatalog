using System;
using Models;
using DataLayer;
namespace BuisnessLogic
{
    public class Logic : ILogic
    {
        private readonly IRepo repo;

        public Logic(IRepo _repo)
        {
            repo = _repo;
        }

        public CategoryModel AddCategory(CategoryModel category)
        {
            return Mapper.Map(repo.AddCategory(Mapper.Map(category)));
        }

        public IEnumerable<CategoryModel> GetAllCategories()
        {
            List<CategoryModel> categories = new List<CategoryModel>();
            foreach (var i in repo.GetAllCategories())
            {
                categories.Add(Mapper.Map(i));
            }
            return categories;
        }

        public CategoryModel DeleteCategory(int CategoryID)
        {
            return Mapper.Map(repo.DeleteCategory(CategoryID));
        }
        public CategoryModel UpdateCategory(CategoryModel category)
        {
            return Mapper.Map(repo.UpdateCategory(Mapper.Map(category)));
        }

        public ProductModel AddProduct(ProductModel product)
        {
            return Mapper.Map(repo.AddProduct(Mapper.Map(product)));
        }

        public ProductModel GetProductByID(int productId)
        {
            return Mapper.Map(repo.GetProductByID(productId));
        }

        public IEnumerable<ProductModel> GetAllProduct()
        {
            return Mapper.Map(repo.GetAllProduct());
        }
        public IEnumerable<ProductModel> GetProductByCategoryID(int CategoryId)
        {
            return Mapper.Map(repo.GetProductByCategoryID(CategoryId));
        }

        public ProductModel UpdateProduct(ProductModel product)
        {
            return Mapper.Map(repo.UpdateProduct(Mapper.Map(product)));
        }
        public ProductModel DeleteProductById(int ProductId)
        {
            return Mapper.Map(repo.DeleteProductById(ProductId));
        }


        public SpecificationModel AddSpecification(SpecificationModel specification)
        {
            return Mapper.Map(repo.AddSpecification(Mapper.Map(specification)));
        }
        public IEnumerable<SpecificationModel> GetSpecificationsByProductId(int productID)
        {
            return Mapper.Map(repo.GetSpecificationsByProductId(productID));
        }

        public SpecificationModel DeleteSpecificationByID(int SpecificationID)
        {
            return Mapper.Map(repo.DeleteSpecificationByID(SpecificationID));
        }

        public SpecificationModel UpdateSpecification(SpecificationModel specification1)
        {
            return Mapper.Map(repo.UpdateSpecification(Mapper.Map(specification1)));
        }
    }
}

