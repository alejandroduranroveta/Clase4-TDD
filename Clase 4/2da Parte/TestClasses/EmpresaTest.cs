// using Microsoft.VisualStudio.TestTools.UnitTesting;
// namespace Clase_4;
//
// [TestClass]
// public class EmpresaTest
// {
//     [TestMethod]
//     public void TestDarAumento()
//     {
//         // Arrange ->Armo el escenario de prueba
//         var empresa = new Empresa();
//         var empleado1 = new Persona("Alejandro", 1000);
//         
//         
//         empresa.Empleados.Add(empleado1);
//         
//     
//         var porcentajeAumento = 10;
//         
//         var salarioEsperadoEmpleado1 = 1100m; // 1000 + 1000 * 10 / 100
//         
//     
//         // Act ->llamada al metodo que aumenta el salario
//         
//         empresa.DarAumento(porcentajeAumento);
//     
//         // Assert -> Verificar que el salario aumento
//         
//         //Assert.AreEqual(salarioEsperadoEmpleado1, empleado1.Salario);
//         
//     }
//     
//     
// }