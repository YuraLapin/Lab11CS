using Lab11Main;
using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using System.Text;

namespace Lab11Test
{
    public class PersonTests
    {
        [Fact]
        public void DefaultConstructor()
        {
            var expected = new Person("", 1, 1);
            var actual = new Person();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NameOnlyConstructor()
        {
            var expected = new Person("1", 1, 1);
            var actual = new Person("1");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConvertToString()
        {
            var example = new Person("1", 1, 1);
            string actual = example.ToString();
            string expected = "1: age - 1, height - 1";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ExplicitToTransport()
        {
            var example = new Person("1", 1, 1);
            Transport actual = (Transport)example;
            Transport expected = new Transport("1", 0);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CompareToTransport()
        {
            int expected = 1;
            Person example = new Person("1", 1, 1);
            int actual = example.CompareTo(new Transport("0", 1));
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CompareToPerson()
        {
            int expected = 1;
            Person example = new Person("1", 1, 1);
            int actual = example.CompareTo(new Person("0", 1, 1));
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Clone()
        {
            Person expected = new Person("1", 1, 1);
            Person actual = (Person)expected.Clone();
            Assert.Equal(expected, actual);
        }        
    }

    public class TransportTest
    {
        [Fact]
        public void DefaultConstructor()
        {
            Transport actual = new Transport();
            Transport expected = new Transport("", 1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConvertToString()
        {
            string actual = (new Transport("1", 1)).ToString();
            string expected = "1: power - 1";
            Assert.Equal(expected, actual);
        }        

        [Fact]
        public void CastToPerson()
        {
            Person expected = new Person("1", 0, 0);
            Person actual = (Person)(new Transport("1", 1));
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CompareToPerson()
        {
            int expected = 1;
            int actual = (new Transport("1", 0)).CompareTo(new Person("0", 1, 1));
            Assert.Equal(expected, actual);
        }
    }

    public class TrainTest
    {
        [Fact]
        public void DefaultConstruct()
        {
            Train actual = new Train();
            Train expected = new Train("", 0, 0);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConvertToString()
        {
            string actual = (new Train("1", 1, 1)).ToString();
            string expected = "1: power - 1, cars - 1";
            Assert.Equal(expected, actual);
        }        
    }

    public class ExpressTest
    {
        [Fact]
        public void DefaultConstruct()
        {
            Express actual = new Express();
            List<string> stations = new List<string>();
            Express expected = new Express("", 0, 0, stations);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConvertToStringEmptyStations()
        {
            string actual = (new Express()).ToString();
            string expected = ": power - 0, cars - 0, list of stations to skip: [ - ]";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConvertToString()
        {
            var example = new Express();
            example.stationsToSkip.Add("s1");
            example.stationsToSkip.Add("s2");
            string actual = example.ToString();
            string expected = ": power - 0, cars - 0, list of stations to skip: [ s1, s2, ]";
            Assert.Equal(expected, actual);
        }
    }

    public class AutomobileTests
    {
        [Fact]
        public void DefaultConstructor()
        {
            Automobile expected = new Automobile("", 0, 0);
            Automobile actual = new Automobile();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConvertToString()
        {
            string actual = (new Automobile()).ToString();
            string expected = ": power - 0, wheels - 0";
            Assert.Equal(expected, actual);
        }        
    }    
}