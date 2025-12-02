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


        [Fact]
        public void Is_Vehicle_Removed()
        {
            //Arrange
            var garageTest = new Garage<Vehicle>(10);
            var hyrBilTest = new Car("001EZY", Color.Blue);
            garageTest.AddVehicle(hyrBilTest); //because the array is private, this is the only way. Even though you are relying on another method. 

            //Act
            garageTest.RemoveVehicle(hyrBilTest);

            //Assert
            Assert.Equal(0, garageTest.Count());
        }
    }
}
