using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClassTest
{
    /// <summary>
    /// Summary description for TestCustomList
    /// </summary>
    [TestClass]
    public class TestCustomList
    {
       
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Add_intItem_firstIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expectedResult = 3;
            
           
            //Act
            myList.Add(3);
            
            //Assert
            Assert.AreEqual(expectedResult, myList[0]);
        }

        [TestMethod]
        public void Add_intItem_secondIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expectedResult = 5;
            
            //Act
            myList.Add(3);
            myList.Add(expectedResult);
            int actualResult = myList[1];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
            
        }

        [TestMethod]
        public void Add_intItem_thirdIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expectedResult = 9;
            //Act
            myList.Add(3);
            myList.Add(5);
            myList.Add(expectedResult);
            int actualResult = myList[2];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        //Test for Indexer
        [TestMethod]
        public void Add_CheckValueAtIndex_Equal()
        {
            //Arrange
            CustomList<int> primeNos = new CustomList<int>();
            //Act
            primeNos.Add(3);
            primeNos.Add(5);
            primeNos.Add(7);
            primeNos.Add(11);
            primeNos.Add(13);
            primeNos.Add(17);
            int expectedResult = 11;
            //Assert
            Assert.AreEqual(expectedResult, primeNos[3]);
        }
        
        //Test for Indexer/throws out of bound exception-User Strory
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Indexer_OutOfBound_ThrowException()
        {
            //Arrange
            CustomList<int> numbers = new CustomList<int>(5);


            //Act
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            int expectedResult = numbers[6];
                       
            //Assert
        }
        
        //Dont know if i would be able to do that
        [TestMethod]
        public void Add_intItem_givenIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expectedResult = 3;
            //Act
            myList.Add(1);
            myList.Add(5);
            myList.Add(7);
            myList.Add(9);
            myList.Add(11);
            myList.Add(3, 1);
            //Assert
            Assert.AreEqual(expectedResult, myList[1]);

        }


        [TestMethod]
        public void Resize_value_doesResize()
        {
            //Arrange
            CustomList<int> primeNos = new CustomList<int>();

            //Act
            primeNos.Add(3);
            primeNos.Add(5);
            primeNos.Add(7);
            primeNos.Add(9);
            primeNos.Add(11);
            primeNos.Add(13);
            
            //Assert

        }


        [TestMethod]
        //Test for Count
        public void Count_ListItems_IsRight()
        {
            //Arrange
            CustomList<int> primeNos = new CustomList<int>();
            //Act
            primeNos.Add(3);
            primeNos.Add(5);
            primeNos.Add(7);
            primeNos.Add(9);
            primeNos.Add(11);
            primeNos.Add(13);
            int expectedResult = 6;

            //Assert
            Assert.AreEqual(expectedResult, primeNos.count);

        }

        [TestMethod]
        public void Count_ListItems_IsWrong()
        {
            //Arrange
            CustomList<int> primeNos = new CustomList<int>();
            //Act
            primeNos.Add(3);
            primeNos.Add(5);
            primeNos.Add(7);
            primeNos.Add(9);
            primeNos.Add(11);
            primeNos.Add(13);
            int expectedResult = 5;
            //Assert
            Assert.AreNotEqual(expectedResult, primeNos.count);
        }

        //Test if remove method works
        [TestMethod]
        public void Remove_ListItems_firstIndex()
        {
            //Arrange
            CustomList<string> weekdays = new CustomList<string>();
            string expectedResult = "Tuesday";

            //Act
            weekdays.Add("Monday");
            weekdays.Add("Tuesday");
            weekdays.Add("Wednesday");
            weekdays.Add("Thursday");
            weekdays.Add("Friday");
            weekdays.Remove("Monday");

            //Assert
            Assert.AreEqual(expectedResult, weekdays[0]);
        }

        [TestMethod]
        public void Remove_ListItems_SecondIndex()
        {
            //Arrange
            CustomList<string> weekdays = new CustomList<string>();
            string expectedResult = "Wednesday";

            //Act
            weekdays.Add("Monday");
            weekdays.Add("Tuesday");
            weekdays.Add("Wednesday");
            weekdays.Add("Thursday");
            weekdays.Add("Friday");
            weekdays.Remove("Tuesday");

            //Assert
            Assert.AreEqual(expectedResult, weekdays[1]);
        }


        //Testing remove method for removing multiple instances
        [TestMethod]
        public void Remove_MultipleInstances_False()
        {
            //Arrange
            CustomList<int> numbers = new CustomList<int>();
            
            //Act
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(2);
            numbers.Add(5);
            numbers.Add(2);
            numbers.Add(7);
            numbers.Remove(2);
            //Assert

            Assert.AreEqual(6, numbers.count);
        }


        //Testing remove method to remove value at given index
        [TestMethod]
        public void Remove_AtGivenIndex_True()
        {
            //Arrange
            CustomList<int> primes = new CustomList<int>();

            //Act
            primes.Add(1);
            primes.Add(3);
            primes.Add(6);
            primes.Add(5);
            primes.Add(7);
            primes.Add(9);
            primes.Add(11);
            primes.Add(13);
            primes.Remove(primes[2]);
            //Assert

            Assert.AreEqual(5, primes[2]);
        }

        //Testing to check if remove method does nothing
        [TestMethod]
        public void Remove_NoMatch_NoRemove()
        {
            //Arrange
            CustomList<string> weekdays = new CustomList<string>();

            //Act
            weekdays.Add("monday");
            weekdays.Add("tuesday");
            weekdays.Add("wednesday");
            weekdays.Add("thursday");
            weekdays.Add("friday");
            weekdays.Remove("sunday");
            //Assert
            Assert.IsTrue(weekdays.count == 5);
            
        }

        [TestMethod]
        public void ToString_Conversion_True()
        {
            //Arrange
            CustomList<int> numbers = new CustomList<int>();
            CustomList<string> expectedList = new CustomList<string>();

            string newNumbers;
            //Act
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

           newNumbers = numbers.ToString();

            //Assert
            Assert.AreEqual("1 2 3 4 5 ", newNumbers);

        }

        [TestMethod]
        public void PlusOverload_Concatenation_Pass()
        {
            //Arrange
            CustomList<int> List1 = new CustomList<int>();
            CustomList<int> List2 = new CustomList<int>();

            CustomList<int> Result = new CustomList<int>();

            //Act
            List1.Add(1);
            List1.Add(3);
            List1.Add(5);

            List2.Add(7);
            List2.Add(9);
            List2.Add(11);

            Result = List1 + List2;

            //Assert
            Assert.AreEqual(11, Result[5]);

        }
        [TestMethod]
        public void PlusOverload_NullValues_AtEnd()
        {

            //Arrange
            CustomList<int> List1 = new CustomList<int>();
            CustomList<int> List2 = new CustomList<int>();

            CustomList<int> Result = new CustomList<int>();
            //Act
            List1.Add(1);
            List1.Add(3);
            List1.Add(5);
            List1.Add(7);
            List1.Add(9);

            List2.Add(11);
            List2.Add(13);
            List2.Add(17);
            List2.Add(19);
            List2.Add(23);

            Result = List1 + List2;

            //Assert
            Assert.AreEqual(11, Result[5]);

        }

        [TestMethod]
        public void PlusOverload_List2_After1()
        {
            //Arrange
            CustomList<string> weekdays1 = new CustomList<string>();
            CustomList<string> weekdays2 = new CustomList<string>();

            CustomList<string> weekdays = new CustomList<string>();

            //Act
            weekdays1.Add("Monday");
            weekdays1.Add("Tuesday");
            weekdays1.Add("Wednesday");

            weekdays2.Add("Thursday");
            weekdays2.Add("Friday");

            weekdays = weekdays1 + weekdays2;

            //Assert
            Assert.AreNotEqual("Thursday", weekdays[0]);

        }

        
        [TestMethod]
        public void PlusOverload_ResizeResultList_True()
        {

            //Arrange
            CustomList<string> weekdays1 = new CustomList<string>();
            CustomList<string> weekdays2 = new CustomList<string>();

            CustomList<string> weekdays = new CustomList<string>();


            //Act
            weekdays1.Add("Monday");
            weekdays1.Add("Tuesday");
            weekdays1.Add("Wednesday");

            weekdays2.Add("Thursday");
            weekdays2.Add("Friday");

            weekdays = weekdays1 + weekdays2;

            //Assert
            Assert.AreEqual(8, weekdays.capacity);


        }
        [TestMethod]
        public void PlusOverload_ResultCount_OnePlusTwo()
        {

            //Arrange
            CustomList<int> numbers1 = new CustomList<int>();
            CustomList<int> numbers2 = new CustomList<int>();

            CustomList<int> resultNumbers = new CustomList<int>();
            //Act

            numbers1.Add(1);
            numbers1.Add(2);
            numbers1.Add(3);
            numbers1.Add(4);
            numbers1.Add(5);

            numbers2.Add(1);
            numbers2.Add(2);
            numbers2.Add(3);
            numbers2.Add(4);
            numbers2.Add(5);

            resultNumbers = numbers1 + numbers2;

            //Assert
            Assert.AreEqual(10, resultNumbers.count);
        }


        //Test Method to check subtraction goes through
        [TestMethod]
        public void SubtractOverload_Subtraction_Pass()
        {
            //Arrange
            CustomList<int> numbers1 = new CustomList<int>();
            CustomList<int> numbers2 = new CustomList<int>();

            CustomList<int> odds = new CustomList<int>();

            //Act
            numbers1.Add(1);
            numbers1.Add(2);
            numbers1.Add(3);
            numbers1.Add(4);
            numbers1.Add(5);
            numbers1.Add(6);
            numbers1.Add(7);

            numbers2.Add(2);
            numbers2.Add(4);
            numbers2.Add(6);

            odds = numbers1 - numbers2;

            //Assert
            Assert.AreEqual(7, odds[3]);

        }

        //To check that array must desize
        [TestMethod]
        public void SubtractOverload_DesizeArray_True()
        {
            //Arrange
            CustomList<int> numbers1 = new CustomList<int>();
            CustomList<int> numbers2 = new CustomList<int>();

            CustomList<int> odds = new CustomList<int>();
            //Act
            numbers1.Add(1);
            numbers1.Add(2);
            numbers1.Add(3);
            numbers1.Add(4);
            numbers1.Add(5);
            numbers1.Add(6);
            numbers1.Add(7);

            numbers2.Add(4);
            numbers2.Add(5);
            numbers2.Add(6);
            numbers2.Add(7);

            odds = numbers1 - numbers2;

            //Assert
            Assert.AreEqual(4, odds.capacity);

        }


        //To check only one gets subtracted if multiple same values found
        [TestMethod]
        public void SubtractOverload_OnlyOne_True()
        {
            //Arrange
            CustomList<string> weekdays1 = new CustomList<string>();
            CustomList<string> weekdays2 = new CustomList<string>();

            CustomList<string> weekdays = new CustomList<string>();
            //Act
            weekdays1.Add("Monday");
            weekdays1.Add("Tuesday");
            weekdays1.Add("Tuesday");
            weekdays1.Add("Wednesday");
            weekdays1.Add("Thursday");
            weekdays1.Add("Friday");

            weekdays2.Add("Thursday");
            weekdays2.Add("Tuesday");
            weekdays2.Add("Friday");

            weekdays = weekdays1 - weekdays2;
            //Assert
            Assert.AreEqual("Tuesday", weekdays[1]);
        }

        //To check if first instance is deleted not second
        [TestMethod]
        public void SubtractOverload_OnlyFirstDelete_True()
        {
            //Arrange
            CustomList<int> numbers1 = new CustomList<int>();
            CustomList<int> numbers2 = new CustomList<int>();

            CustomList<int> numbers = new CustomList<int>();

            //Act
            numbers1.Add(10);
            numbers1.Add(20);
            numbers1.Add(50);
            numbers1.Add(30);
            numbers1.Add(40);
            numbers1.Add(50);
            numbers1.Add(60);

            numbers2.Add(87);
            numbers2.Add(56);
            numbers2.Add(50);
            numbers2.Add(58);

            numbers = numbers1 - numbers2;

            //Assert
            Assert.AreEqual(50, numbers[4]);

        }



        //Check if it can hold values again and resize again after subtraction
        [TestMethod]
        public void SubtractOverload_DoAddOnResult_shouldWork()
        {
            //Arrange
            CustomList<int> primes1 = new CustomList<int>();
            CustomList<int> primes2 = new CustomList<int>();

            CustomList<int> primes = new CustomList<int>();
            //Act

            primes1.Add(2);
            primes1.Add(3);
            primes1.Add(5);
            primes1.Add(7);
            primes1.Add(9);

            primes2.Add(9);
            primes1.Add(7);
            primes2.Add(11);
            primes2.Add(13);
            primes2.Add(17);

            primes = primes1 - primes2;
            primes.Add(7, 3);

            //Assert
            Assert.AreEqual(7, primes[3]);

        }
    }

}
