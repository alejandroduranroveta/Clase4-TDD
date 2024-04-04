// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Data.Entity;
//
// namespace Clase_4;
//
// [TestClass]
// public class DatabaseServiceTest
// {
//     private DatabaseService databaseService;
//     private DbContext dbContext;
//
//     [TestInitialize]
//     public void TestInitialize()
//     {
//         // Este método se ejecuta antes de cada prueba.
//         // Aquí puedes inicializar los objetos que se utilizarán en las pruebas.
//         dbContext = new DbContext("InMemoryDatabase"); // Base de datos en memoria para pruebas
//         databaseService = new DatabaseService(dbContext);
//     }
//
//     [TestMethod]
//     public void TestAddUser()
//     {
//         // Arrange
//         var user = new User { Username = "testuser", Password = "testpassword" };
//
//         // Act
//         databaseService.AddUser(user);
//
//         // Assert
//         var retrievedUser = databaseService.GetUser("testuser");
//         Assert.IsNotNull(retrievedUser);
//         Assert.AreEqual(user.Username, retrievedUser.Username);
//     }
//
//     [TestCleanup]
//     public void TestCleanup()
//     {
//         // Este método se ejecuta después de cada prueba.
//         // Aquí puedes limpiar o liberar los recursos que se utilizaron en las pruebas.
//         dbContext.Database.Delete(); // Elimina la base de datos en memoria
//         dbContext = null;
//         databaseService = null;
//     }
// }