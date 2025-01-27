// using Swaggerator.Types.SchemaCreators;
// using Swaggerator.Types.Schemas;
// using Swaggerator.Types.Tests.UnitTests.TestClasses;

// namespace Swaggerator.Types.Tests;

// [TestClass]
// public class ReferenceSchemaCreatorUnitTests
// {
//     [TestMethod]
//     public void Constructor_Parameterless_InstanceNotNull()
//     {
//         var creator = new ObjectSchemaCreator();

//         Assert.IsNotNull(creator);
//     }

//     [TestMethod]
//     public void Create_AnyClass_HasSetReference()
//     {
//         const string _reference = "#/components/schemas/EmptyClass";
//         var creator = new ReferenceSchemaCreator();

//         var result = (ReferenceSchema)creator.Create(typeof(EmptyClass));

//         Assert.AreEqual(_reference, result.Ref);
//     }
// }