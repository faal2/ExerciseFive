using ExerciseFive.Vehicles;
using ExerciseFive.GarageWorld;


namespace ExerciseFive.Tests
{
    public class UnitTest1
    {

        [Fact]
        public void Is_Garage_Full()
        {
                //Arrange
                var garageTest = new Garage<Vehicle>(10);
                var hyrBilTest = new Car("001EZY", Color.Blue);

                //Act
                garageTest.AddVehicle(hyrBilTest);
                
                //Assert
                Assert.Equal(1, garageTest.Count());
        }
    }
}
