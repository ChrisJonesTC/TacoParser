using System;
using Xunit;
using Xunit.Sdk;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Theory]
        [InlineData()]
        public void ShouldDoSomething()
        {
            // DONE: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // DONE: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange - This is where we prepare the code in order to call the method you need to test
            var tacoParserInstance = new TacoParser();
            
            //Act - This is where we actually call the method we want to test
            var actual = tacoParserInstance.Parse(line);
            
            //Assert - Check against a constant (check against what is expected)
            Assert.Equal(expected, actual.Location.Longitude);
        }

        //DONE: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        public void ShouldParseLatitude(string line, double expected)
        {
            // DONE: Complete - "line" represents input data we will Parse to
            //       extract the Latitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange - write the code we need in order to call the method we're testing
            var tacoParserInstance = new TacoParser();
            //Act
            var actual = tacoParserInstance.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }

    }
}
