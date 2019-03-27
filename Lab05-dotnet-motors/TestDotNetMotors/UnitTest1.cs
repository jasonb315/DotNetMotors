using System;
using Xunit;
using Lab05_dotnet_motors.Classes;

namespace TestDotNetMotors
{
    public class UnitTest1
    {

        // base price
        
        [Fact]
        public void BasePriceClownCar()
        {
            ClownCar vehicle = new ClownCar();
            vehicle.BasePrice = 5000;
            Assert.Equal(5000, vehicle.BasePrice);
        }

        [Fact]
        public void BasePriceMcQueen()
        {
            McQueen vehicle = new McQueen();
            vehicle.BasePrice = 5000000;
            Assert.Equal(5000000, vehicle.BasePrice);
        }

        [Fact]
        public void BasePriceMackAnthem()
        {
            MackAnthem vehicle = new MackAnthem();
            vehicle.BasePrice = 5000;
            Assert.Equal(5000, vehicle.BasePrice);
        }

        [Fact]
        public void BasePriceSubaruBahah()
        {
            SubaruBahah vehicle = new SubaruBahah();
            vehicle.BasePrice = 5000;
            Assert.Equal(5000, vehicle.BasePrice);
        }

        [Fact]
        public void BasePriceSubaruBrat()
        {
            SubaruBrat vehicle = new SubaruBrat();
            vehicle.BasePrice = 5000;
            Assert.Equal(5000, vehicle.BasePrice);
        }

        //Seats
        
        [Fact]
        public void SeatsClownCar()
        {
            ClownCar vehicle = new ClownCar();
            vehicle.Seats = 5000;
            Assert.Equal(5000, vehicle.Seats);
        }

        [Fact]
        public void SeatsMcQueen()
        {
            McQueen vehicle = new McQueen();
            vehicle.Seats = 2;
            Assert.Equal(2, vehicle.Seats);
        }

        [Fact]
        public void SeatsMackAnthemr()
        {
            ClownCar vehicle = new ClownCar();
            vehicle.Seats = 2;
            Assert.Equal(2, vehicle.Seats);
        }

        [Fact]
        public void SeatsSubaruBahah()
        {
            SubaruBahah vehicle = new SubaruBahah();
            vehicle.Seats = 4;
            Assert.Equal(4, vehicle.Seats);
        }

        [Fact]
        public void SeatsSubaruBrat()
        {
            SubaruBrat vehicle = new SubaruBrat();
            vehicle.Seats = 4;
            Assert.Equal(4, vehicle.Seats);
        }

        //Wheels

        [Fact]
        public void WheelsClownCar()
        {
            ClownCar vehicle = new ClownCar();
            vehicle.Wheels = 4;
            Assert.Equal(4, vehicle.Wheels);
        }

        [Fact]
        public void WheelsMcQueen()
        {
            McQueen vehicle = new McQueen();
            vehicle.Wheels = 4;
            Assert.Equal(4, vehicle.Wheels);
        }

        [Fact]
        public void WheelsMackAnthem()
        {
            MackAnthem vehicle = new MackAnthem();
            vehicle.Wheels = 4;
            Assert.Equal(4, vehicle.Wheels);
        }

        [Fact]
        public void WheelsSubaruBahah()
        {
            SubaruBahah vehicle = new SubaruBahah();
            vehicle.Wheels = 4;
            Assert.Equal(4, vehicle.Wheels);
        }

        [Fact]
        public void WheelsSubaruBrat()
        {
            SubaruBrat vehicle = new SubaruBrat();
            vehicle.Wheels = 4;
            Assert.Equal(4, vehicle.Wheels);
        }

        // Start

        [Fact]
        public void StartClownCar()
        {
            ClownCar vehicle = new ClownCar();
            string s = vehicle.Start();
            Assert.Equal("whir-vroom", s);
        }

        [Fact]
        public void StartMcQueen()
        {
            McQueen vehicle = new McQueen();
            string s = vehicle.Start();
            Assert.Equal("whir-vroom", s);
        }

        [Fact]
        public void StartMackAnthem()
        {
            MackAnthem vehicle = new MackAnthem();
            string s = vehicle.Start();
            Assert.Equal("whir-vroom", s);
        }

        [Fact]
        public void StartSubaruBahah()
        {
            SubaruBahah vehicle = new SubaruBahah();
            string s = vehicle.Start();
            Assert.Equal("whir-vroom", s);
        }

        [Fact]
        public void StartSubaruBrat()
        {
            SubaruBrat vehicle = new SubaruBrat();
            string s = vehicle.Start();
            Assert.Equal("whir-vroom", s);
        }

        // SlowDown

        [Fact]
        public void SlowDownClownCar()
        {
            ClownCar vehicle = new ClownCar();
            string s = vehicle.SlowDown();
            Assert.Equal("scree", s);
        }

        [Fact]
        public void SlowDownMcQueen()
        {
            McQueen vehicle = new McQueen();
            string s = vehicle.SlowDown();
            Assert.Equal("scree", s);
        }

        [Fact]
        public void SlowDownMackAnthem()
        {
            MackAnthem vehicle = new MackAnthem();
            string s = vehicle.SlowDown();
            Assert.Equal("scree", s);
        }

        [Fact]
        public void SlowDownSubaruBahah()
        {
            SubaruBahah vehicle = new SubaruBahah();
            string s = vehicle.SlowDown();
            Assert.Equal("scree", s);
        }

        [Fact]
        public void SlowDownSubaruBrat()
        {
            SubaruBrat vehicle = new SubaruBrat();
            string s = vehicle.SlowDown();
            Assert.Equal("scree", s);
        }


        // CarHonk

        [Fact]
        public void CarHonkClownCar()
        {
            ClownCar vehicle = new ClownCar();
            string s = vehicle.Honk();
            Assert.Equal("beep beep", s);
        }

        [Fact]
        public void CarHonkMcQueen()
        {
            McQueen vehicle = new McQueen();
            string s = vehicle.Honk();
            Assert.Equal("beep beep", s);
        }

        //Car SpeedUp

        [Fact]
        public void CarSpeedUpClownCar()
        {
            ClownCar vehicle = new ClownCar();
            string s = vehicle.SpeedUp();
            Assert.Equal("brrrrr brrrrrr", s);
        }

        [Fact]
        public void CarSpeedUpMcQueen()
        {
            ClownCar vehicle = new ClownCar();
            string s = vehicle.SpeedUp();
            Assert.Equal("brrrrr brrrrrr", s);
        }

        //RaceCar Turbo

        [Fact]
        public void TurboRaceCar()
        {
            McQueen vehicle = new McQueen();
            string s = vehicle.Turbo();
            Assert.Equal("FROOSH", s);
        }

        [Fact]
        public void AudioBookCommuter()
        {
            ClownCar vehicle = new ClownCar();
            string s = vehicle.AudioBook();
            Assert.Equal("this is audible", s);
        }

        // Truck Honk

        [Fact]
        public void HonkTruckMackAnthem()
        {
            MackAnthem vehicle = new MackAnthem();
            string s = vehicle.Honk();
            Assert.Equal("hoooooooooonk", s);
        }

        [Fact]
        public void HonkTruckSubaruBahah()
        {
            SubaruBahah vehicle = new SubaruBahah();
            string s = vehicle.Honk();
            Assert.Equal("hoooooooooonk", s);
        }

        [Fact]
        public void HonkTruckSubaruBrat()
        {
            SubaruBrat vehicle = new SubaruBrat();
            string s = vehicle.Honk();
            Assert.Equal("hoooooooooonk", s);
        }

        [Fact]
        public void TowSemiTruck()
        {
            MackAnthem vehicle = new MackAnthem();
            string s = vehicle.Tow();
            Assert.Equal("Git er done!", s);
        }

        //

        [Fact]
        public void BackFireSubaruBrat()
        {
            SubaruBrat vehicle = new SubaruBrat();
            string s = vehicle.BackFire();
            Assert.Equal("BANG", s);
        }

        [Fact]
        public void RadioMackAnthem()
        {
            MackAnthem vehicle = new MackAnthem();
            string s = vehicle.Radio();
            Assert.Equal("bzzz", s);
        }

        [Fact]
        public void UnpackClownCar()
        {
            ClownCar vehicle = new ClownCar();
            string s = vehicle.Unpack();
            Assert.Equal("100 clowns get out", s);
        }

        //ClownCar
        //McQueen
        //MackAnthem
        //SubaruBahah
        //SubaruBrat
    }
}
