using API_NutCache.Controllers;
using DATA;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;


namespace API_NutCache_Testes
{
    public class Testes_Api
    {
        private EmployeeController controller =  new EmployeeController();

        [Theory]
        [InlineData("Luiz Filipy", "05-01-1997", "M", "Filipy_luiz@Hotmail.com", "70187725403", "05-01-2022", null)]
        [InlineData("João Luiz", "05-01-1947", "M", "Luiz_jOAO@Hotmail.com", "70187725422", "09-08-2022", "Back-end")]
        [InlineData("Pedro José", "05-01-1997", "M", "pedroJose@outlook.com", "701223725403", "01-15-2021", "Front-End")]
        [Trait("Funcionalidade", "Insert")]
        public void TestInsert(string name,DateTime birthDate, string gender,string email,string CPF,DateTime startDate, string team)
        {
            // Arrange
            var employee = new Employee(name,birthDate,gender,email,CPF,startDate,team);



            // Act
            var actionResult = controller.Post(employee);
            var okResult = Assert.IsType<OkObjectResult>(actionResult.Result);
            var values = Assert.IsAssignableFrom<IEnumerable<Employee>>(okResult.Value);
            // Assert
            Assert.Equal(employee, (Employee)values);

        }


        [Fact]
        [Trait("Funcionalidade", "Update")]
        public void TestUpdate()
        {
            // Arrange
            var employee = new Employee("Luiz Filipy", Convert.ToDateTime("05-01-1997",CultureInfo.InvariantCulture), "M", "Filipy_luiz@Hotmail.com", "70187725403", Convert.ToDateTime("01-27-2022", CultureInfo.InvariantCulture), "Front-End");


            // Act
            var actionResult = controller.Put(employee.IdEmployee,employee);
            var okResult = Assert.IsType<OkObjectResult>(actionResult.Result);
            var values = Assert.IsAssignableFrom<IEnumerable<Employee>>(okResult.Value);
            // Assert
            Assert.Equal(employee, (Employee)values);

        }

        [Fact]
        [Trait("Funcionalidade", "Find")]
        public void TestFind()
        {
            // Arrange
            var IdEmployee = 1;
            var employee = new Employee("Luiz Filipy", Convert.ToDateTime("05-01-1997", CultureInfo.InvariantCulture), "M", "Filipy_luiz@Hotmail.com", "70187725403", Convert.ToDateTime("01-27-2022", CultureInfo.InvariantCulture), "Front-End");


            // Act
            var actionResult = controller.Get(IdEmployee);
            var okResult = Assert.IsType<OkObjectResult>(actionResult.Result);
            var values = Assert.IsAssignableFrom<IEnumerable<Employee>>(okResult.Value);
            // Assert
            Assert.Equal(employee, (Employee)values);

        }


        [Fact]
        [Trait("Funcionalidade", "Find")]
        public void TestListAll()
        {
            // Act
            var actionResult = controller.ListAll();
            var okResult = Assert.IsType<OkObjectResult>(actionResult.Result);
            var values = Assert.IsAssignableFrom<IEnumerable<Employee>>(okResult.Value);
            // Assert
            Assert.NotEmpty(values);

        }
    }
}
