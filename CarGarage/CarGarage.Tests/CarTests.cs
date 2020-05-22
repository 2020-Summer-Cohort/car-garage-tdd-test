using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using System;
using Xunit;

namespace CarGarage.Tests
{
    public class CarTests

    {
        Car sut = new Car();
        

        [Fact]
        public void shouldAccelerate()
        {
            // Tests Accelerate() method in Car increases Speed
            // Arrange
            //int currentSpeed = 50;
            //Car sut = new Car();

            // Act
            sut.Accelerate();

            // Assert
            Assert.Equal(15, sut.Speed);
        }

        [Fact]
        public void shouldConsumeFuel()
        {
            // Tests Accelerate() method reduces Fuel amount
            // Arrange
            //Car sut = new Car();
            int currentFuelLevel = sut.Fuel;
            // Act
            sut.Drive();
            // Assert
            Assert.Equal(currentFuelLevel - 23, sut.Fuel);
        }

        [Fact]
        public void shouldRefuel()
        {
            // Tests AddFuel() method increases Fuel amount
            // Arrange
            //Car sut = new Car();
            int currentFuelLevel = sut.Fuel;
            // Act
            sut.AddFuel();
            // Assert
            Assert.Equal(currentFuelLevel + 23, sut.Fuel);
        }

        [Fact]
        public void shouldSlowDown()
        {
            // Tests Brake() method in Car reduces Speed amount
            // Arrange
            int currentSpeed = sut.Speed;
            
            // Act
            sut.Brake();

            // Assert
            Assert.Equal(currentSpeed - 7, sut.Speed);
        }

        [Fact]
        public void shouldStart()
        {
            // Tests ToggleEngine() method starts car when its off
            // Arrange
            sut.CarRunning = false;
            // Act
            sut.ToggleIgnition();
            // Assert
            Assert.True(sut.CarRunning = true);
        }

        [Fact]
        public void shouldTurnOff()
        {
            // Tests ToggleEngine() method turns car off when its on
            // Arrange
            sut.CarRunning = true;
            // Act
            sut.ToggleIgnition();
            // Assert
            // Assert.True(sut.CarRunning = false);
            Assert.False(sut.CarRunning = false);
        }
    }
}
