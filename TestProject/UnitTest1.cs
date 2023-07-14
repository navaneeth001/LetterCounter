using Xunit;
using LengthHelperLibrary;

namespace LengthHelperTests
{
    public class LengthHelperTests
    {
        [Fact]
        public void FindLength_WithEmptyString_ReturnsZero()
        {
            // Arrange
            LengthHelper lengthHelper = new LengthHelper();

            // Act
            int length = lengthHelper.FindLength("");

            // Assert
            Assert.Equal(0, length);
        }

        [Fact]
        public void FindLength_WithNonEmptyString_ReturnsLength()
        {

            // Arrange

            LengthHelper lengthHelper = new LengthHelper();

            // Act
            int length = lengthHelper.FindLength("123");

            // Assert
            Assert.Equal(3, length);
        }

        [Fact]
        public void FindLength_WithNonEmptylongString_ReturnsLength()
        {

            // Arrange
            LengthHelper lengthHelper = new LengthHelper();

            // Act
            int length = lengthHelper.FindLength("123");

            // Assert
            Assert.Equal(3, length);
        }

        [Fact]
        public void FindLength_WithNullString_ThrowsArgumentNullException()
        {
            // Arrange
            LengthHelper lengthHelper = new LengthHelper();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => lengthHelper.FindLength(null));
        }


    }
}
