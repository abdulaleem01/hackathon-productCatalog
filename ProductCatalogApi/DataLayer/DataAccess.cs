using System;
using DataLayer.DbEntities;

namespace DataLayer
{
    public class DataAccess : IRepo
    {
        private readonly RestaurantDbContext context;

        public DataAccess(RestaurantDbContext restaurantDbContext)
        {
            context = restaurantDbContext;
        }
        public Category AddCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return category;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return context.Categories.ToList();
        }

        public Category DeleteCategory(int CategoryID)
        {
            Category category = context.Categories.Where(x => x.CategoryId == CategoryID).FirstOrDefault();
            context.Categories.Remove(category);
            context.SaveChanges();
            return category;
        }

        public Category UpdateCategory(Category category)
        {
            context.Categories.Update(category);
            context.SaveChanges();

            return category;
        }


        public Product AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return product;
        }

        public Product GetProductByID(int productId)
        {
            return context.Products.Where(x => x.ProductId == productId).FirstOrDefault();
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return context.Products.ToList();
        }

        public IEnumerable<Product> GetProductByCategoryID(int CategoryId)
        {
            return context.Products.Where(x => x.CategoryTypeId == CategoryId);
        }

        public Product UpdateProduct(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();

            return product;
        }

        public Product DeleteProductById(int ProductId)
        {
            Product product = context.Products.Where(x => x.ProductId == ProductId).FirstOrDefault();
            context.Products.Remove(product);
            context.SaveChanges();

            return product;
        }

        public Specification AddSpecification(Specification specification)
        {
            context.Specifications.Add(specification);
            context.SaveChanges();
            return specification;
        }
        public IEnumerable<Specification> GetSpecificationsByProductId(int productID)
        {
            return context.Specifications.Where(x => x.ProductId == productID);
        }

        public Specification DeleteSpecificationByID(int SpecificationID)
        {
            Specification specification = context.Specifications.Where(x => x.SpecificationId == SpecificationID).FirstOrDefault();
            context.Specifications.Remove(specification);
            context.SaveChanges();

            return specification;
        }
        public Specification UpdateSpecification(Specification specification)
        {
            context.Specifications.Update(specification);
            context.SaveChanges();

            return specification;
        }
    }
}

