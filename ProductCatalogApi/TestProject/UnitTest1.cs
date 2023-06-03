using ProductCatalogApi.Controllers;
using BuisnessLogic;
using Models;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using DataLayer.DbEntities;
namespace TestProject;


public class CategoryControllerTesting
{
    [Fact]
    public void GetAllCategoriesTest()
    {

        //Arrange
        int count = 4;
        var FakeCategories = A.CollectionOfDummy<CategoryModel>(count).AsEnumerable();

        var DataStore = A.Fake<ILogic>();
        A.CallTo(() => DataStore.GetAllCategories()).Returns(FakeCategories);
        var controller = new CategoryController(DataStore);


        //Act

        IActionResult actionResult1 = controller.GetAllCategories();




        //Assert
        var result = actionResult1 as Microsoft.AspNetCore.Mvc.OkObjectResult;
        var returnCategory = result.Value as IEnumerable<CategoryModel>;
        Console.WriteLine(returnCategory);
        Assert.Equal(count, returnCategory.Count());
    }

    [Fact]
    public void TestAddCategory()
    {
        //Arrange
        var FakeCategory = A.Fake<CategoryModel>();

        var DataStore = A.Fake<ILogic>();
        A.CallTo(() => DataStore.AddCategory(FakeCategory)).Returns(FakeCategory);
        var controller = new CategoryController(DataStore);

        //Act

        IActionResult actionResult = controller.AddCategory(FakeCategory);

        //Assert
        var result = actionResult as Microsoft.AspNetCore.Mvc.OkObjectResult;
        //Console.WriteLine(result.Value);

        Assert.Equal(FakeCategory, result.Value);


    }

    [Fact]
    public void MapperTestingCategories()
    {
        //Arrange

        //Categories
        var FakeProductModel = A.Dummy<Models.CategoryModel>();
        var FakeProduct = A.Dummy<Category>();

        //
        var category = new Category();
        var categoryModel = new CategoryModel();








        //Act

        var result = Mapper.Map(FakeProduct);
        var result1 = Mapper.Map(FakeProductModel);


        //Assert


        Assert.Equal(categoryModel.GetType(), result.GetType());
        Assert.Equal(category.GetType(), result1.GetType());



    }

    [Fact]
    public void MapperTestingProducts()
    {
        //Arrange

        //Categories
        var FakeProductModel = A.Dummy<Models.ProductModel>();
        var FakeProduct = A.Dummy<Product>();
        var FakeProductList = A.CollectionOfDummy<Product>(10).AsEnumerable();


        //
        var category = new Product();
        var categoryModel = new ProductModel();








        //Act

        var result = Mapper.Map(FakeProduct);
        var result1 = Mapper.Map(FakeProductModel);
        var result2 = Mapper.Map(FakeProductList);


        //Assert


        Assert.Equal(categoryModel.GetType(), result.GetType());
        Assert.Equal(category.GetType(), result1.GetType());
        Assert.Equal(10, result2.Count());



    }

    [Fact]
    public void MapperTestingSpecifications()
    {
        //Arrange

        //Categories
        var FakeSpecificationsModel = A.Dummy<Models.SpecificationModel>();
        var FakeSpecification = A.Dummy<Specification>();
        var FakeSpecificationList = A.CollectionOfDummy<Specification>(10).AsEnumerable();


        //
        var category = new Specification();
        var categoryModel = new SpecificationModel();








        //Act

        var result = Mapper.Map(FakeSpecification);
        var result1 = Mapper.Map(FakeSpecificationsModel);
        var result2 = Mapper.Map(FakeSpecificationList);



        //Assert


        Assert.Equal(categoryModel.GetType(), result.GetType());
        Assert.Equal(category.GetType(), result1.GetType());
        Assert.Equal(10, result2.Count());




    }
    [Fact]
    public void GetAllProductsTes()
    {

        //Arrange
        int count = 4;
        var FakeProduct = A.CollectionOfDummy<ProductModel>(count).AsEnumerable();

        var DataStore = A.Fake<ILogic>();
        A.CallTo(() => DataStore.GetAllProduct()).Returns(FakeProduct);
        var controller = new ProductsController(DataStore);


        //Act

        IActionResult actionResult1 = controller.GetAllProduct();




        //Assert
        var result = actionResult1 as Microsoft.AspNetCore.Mvc.OkObjectResult;
        var returnCategory = result.Value as IEnumerable<ProductModel>;
        Console.WriteLine(returnCategory);
        Assert.Equal(count, returnCategory.Count());
    }

    [Fact]
    public void GetSpecifications()
    {

        //Arrange

        var FakeProduct = A.CollectionOfDummy<SpecificationModel>(10).AsEnumerable();

        var DataStore = A.Fake<ILogic>();
        A.CallTo(() => DataStore.GetSpecificationsByProductId(1)).Returns(FakeProduct);
        var controller = new SpecificationController(DataStore);


        //Act

        IActionResult actionResult1 = controller.GetSpecificationsByProductId(1);




        //Assert
        var result = actionResult1 as Microsoft.AspNetCore.Mvc.OkObjectResult;
        var returnCategory = result.Value as IEnumerable<SpecificationModel>;
        Console.WriteLine(returnCategory);
        Assert.Equal(10, returnCategory.Count());
    }

    [Fact]
    public void AddSpecificationsTest()
    {

        //Arrange

        var FakeProduct = A.Dummy<SpecificationModel>();

        var DataStore = A.Fake<ILogic>();
        A.CallTo(() => DataStore.AddSpecification(FakeProduct)).Returns(FakeProduct);
        var controller = new SpecificationController(DataStore);


        //Act

        IActionResult actionResult1 = controller.AddSpecification(FakeProduct);




        //Assert
        var result = actionResult1 as Microsoft.AspNetCore.Mvc.OkObjectResult;
        var returnCategory = result.Value as SpecificationModel;
        Assert.Equal(FakeProduct, returnCategory);
    }


    [Fact]
    public void AddProductTest()
    {

        //Arrange

        var FakeProduct = A.Dummy<ProductModel>();

        var DataStore = A.Fake<ILogic>();
        A.CallTo(() => DataStore.AddProduct(FakeProduct)).Returns(FakeProduct);
        var controller = new ProductsController(DataStore);


        //Act

        IActionResult actionResult1 = controller.AddProduct(FakeProduct);




        //Assert
        var result = actionResult1 as Microsoft.AspNetCore.Mvc.OkObjectResult;
        var returnCategory = result.Value as ProductModel;
        Assert.Equal(FakeProduct, returnCategory);
    }

}
