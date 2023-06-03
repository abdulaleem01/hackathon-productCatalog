using System;
using DataLayer.DbEntities;
using Models;
namespace BuisnessLogic
{

    public class Mapper
    {
        public static CategoryModel Map(Category category)
        {
            return new CategoryModel()
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                Description = category.Description
            };
        }

        public static Category Map(CategoryModel categoryModel)
        {
            return new Category()
            {
                CategoryId = categoryModel.CategoryId,
                CategoryName = categoryModel.CategoryName,
                Description = categoryModel.Description
            };
        }

        public static ProductModel Map(Product product)
        {
            return new ProductModel()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                Description = product.Description,
                Price = product.Price,
                Date = product.Date,
                Brand = product.Brand,
                CategoryTypeId = product.CategoryTypeId
            };
        }

        public static Product Map(ProductModel product)
        {
            return new Product()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                Description = product.Description,
                Price = product.Price,
                Date = product.Date,
                Brand = product.Brand,
                CategoryTypeId = product.CategoryTypeId
            };
        }

        public static IEnumerable<ProductModel> Map(IEnumerable<Product> products)
        {
            return products.Select(Map);
        }

        public static SpecificationModel Map(Specification specification)
        {
            return new SpecificationModel()
            {
                SpecificationId = specification.SpecificationId,
                Key = specification.Key,
                Value = specification.Value,
                ProductId = specification.ProductId
            };
        }

        public static Specification Map(SpecificationModel specification)
        {
            return new Specification()
            {
                SpecificationId = specification.SpecificationId,
                Key = specification.Key,
                Value = specification.Value,
                ProductId = specification.ProductId
            };
        }

        public static IEnumerable<SpecificationModel> Map(IEnumerable<Specification> specifications)
        {
            return specifications.Select(Map);
        }

    }
}

