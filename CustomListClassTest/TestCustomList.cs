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
            int expectedResult = 11;
            //Act
            primeNos.Add(3);
            primeNos.Add(5);
            primeNos.Add(7);
            primeNos.Add(11);
            primeNos.Add(13);
            primeNos.Add(17);
           
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
            int expectedResult;
            //Act
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            //Assert
            expectedResult = numbers[6];
        }
        
        //Test for Add item at a specific index
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
            CustomList<int> primeNos = new CustomList<int>() { 3, 5, 7};
            int expectedValue = 8;

            //Act
            primeNos.Add(9);
            primeNos.Add(11);

            //Assert
            Assert.AreEqual(expectedValue, primeNos.capacity);

        }


        [TestMethod]
        //Test for Count
        public void Count_ListItems_IsRight()
        {
            //Arrange
            CustomList<int> primeNos = new CustomList<int>() { 3,5,7,9,11,13};
            int expectedResult = 6;

            //Act
            int actualResult = primeNos.count;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Count_ListItems_IsWrong()
        {
            //Arrange
            CustomList<int> primeNos = new CustomList<int>() { 3,5,7,9,11,13};
            int expectedResult = 6;
            int actualResult = primeNos.count;
            //Act
            primeNos.Add(17);
            actualResult = primeNos.count;
            
            //Assert
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        //Test if remove method works and removes first instance not second
        [TestMethod]
        public void Remove_ListItems_firstIndex()
        {
            //Arrange
            CustomList<string> weekdays = new CustomList<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Monday"};
            string expectedResult = "Tuesday";
            string actualResult;

            //Act
            weekdays.Remove("Monday");
            actualResult = weekdays[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        //Test to check if remove doesn't only remove first value
        [TestMethod]
        public void Remove_ListItems_SecondIndex()
        {
            //Arrange
            CustomList<string> weekdays = new CustomList<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string expectedResult = "Wednesday";
            string actualResult;
            //Act

            weekdays.Remove("Tuesday");
            actualResult = weekdays[1];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        //Testing remove method for removing multiple instances
        [TestMethod]
        public void Remove_MultipleInstances_False()
        {
            //Arrange
            CustomList<int> numbers = new CustomList<int>() { 1, 2, 3, 2, 5, 2, 7 };
            int expectedCount = 6;
            int actualCount;
            
            //Act
            numbers.Remove(2);
            actualCount = numbers.count;
            //Assert

            Assert.AreEqual(expectedCount, actualCount);
        }


        //Testing remove method to remove value at given index
        [TestMethod]
        public void Remove_AtGivenIndex_True()
        {
            //Arrange
            CustomList<int> primes = new CustomList<int>() { 1, 3, 6, 5, 7, 11, 13 };
            int expectedResult = 5;
            int actualResult;

            //Act
            primes.Remove(primes[2]);
            actualResult = primes[2];
            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        //Testing to check if remove method does nothing
        [TestMethod]
        public void Remove_NoMatch_NoRemove()
        {
            //Arrange
            CustomList<string> weekdays = new CustomList<string>() { "monday", "tuesday", "wednesday", "thursday", "friday" };
            int actualCount;
            //Act
            weekdays.Remove("sunday");
            actualCount = weekdays.count;
            //Assert
            Assert.IsTrue(actualCount == 5);
            
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
            CustomList<int> List1 = new CustomList<int>() { 1, 3, 5};
            CustomList<int> List2 = new CustomList<int>() { 7, 9, 11};

            CustomList<int> Result = new CustomList<int>();
            int expectedResult = 11;
            int actualResult;

            //Act
            Result = List1 + List2;
            actualResult = Result[5];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void PlusOverload_NullValues_AtEnd()
        {

            //Arrange
            CustomList<int> List1 = new CustomList<int>() { 1, 3, 5, 7, 9 };
            CustomList<int> List2 = new CustomList<int>() { 11, 13, 17, 19, 23 };

            CustomList<int> Result = new CustomList<int>();
            int expectedResult = 11;
            int actualResult;
            //Act

            Result = List1 + List2;
            actualResult = Result[5];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void PlusOverload_List2_After1()
        {
            //Arrange
            CustomList<string> weekdays1 = new CustomList<string>() { "Monday", "Tuesday", "Wednesday" };
            CustomList<string> weekdays2 = new CustomList<string>() { "Thursday", "Friday" };

            CustomList<string> weekdays = new CustomList<string>();
            string expectedResult = "Thursday";
            string actualResult;

            //Act
            weekdays = weekdays1 + weekdays2;
            actualResult = weekdays[0];

            //Assert
            Assert.AreNotEqual(expectedResult, actualResult);

        }

        
        [TestMethod]
        public void PlusOverload_ResizeResultList_True()
        {

            //Arrange
            CustomList<string> weekdays1 = new CustomList<string>() { "Monday", "Tuesday", "Wednesday" };
            CustomList<string> weekdays2 = new CustomList<string>() { "Thursday", "Friday" };

            CustomList<string> weekdays = new CustomList<string>();
            int expectedResult = 8;
            int actualResult;
            
            //Act
            weekdays = weekdays1 + weekdays2;
            actualResult = weekdays.capacity;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }
        [TestMethod]
        public void PlusOverload_ResultCount_OnePlusTwo()
        {

            //Arrange
            CustomList<int> numbers1 = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> numbers2 = new CustomList<int>() { 6, 7, 8, 9, 10 };

            CustomList<int> resultNumbers = new CustomList<int>();
            int expectedResult = 10;
            int actualResult;
            //Act

            resultNumbers = numbers1 + numbers2;
            actualResult = resultNumbers.count;

            //Assert
            Assert.AreEqual(expectedResult, resultNumbers.count);
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

        [TestMethod]
        public void Zipper_Zipped_Yes()
        {
            //Arrange
            CustomList<int> numbers1 = new CustomList<int>() { 1, 3 };
            CustomList<int> numbers2 = new CustomList<int>() { 2, 4, 6, 8, 10 };

            CustomList<int> primes = new CustomList<int>();
            int expectedValue = 10;
            //Act
            
            primes = numbers1.Zip(numbers2);
            //Assert
            Assert.AreEqual(expectedValue, primes[6]);
        }

        [TestMethod]
        public void Zipper_List2After1_Yes()
        {
            //Arrange
            CustomList<string> weekdays1 = new CustomList<string>() { "Monday", "Wednesday", "Friday", "Sunday" };
            CustomList<string> weekdays2 = new CustomList<string>() { "Tuesday", "Thursday", "Saturday"};

            CustomList<string> weekdays = new CustomList<string>();
            string expectedValue = "Monday";
            //Act
           
            weekdays = weekdays1.Zip(weekdays2);
            

            //Assert
            Assert.AreEqual(expectedValue, weekdays[0]);
        }

        [TestMethod]
        public void Zipper_ZippedCount_Right()
        {
            //Arrange
            CustomList<string> weekdays1 = new CustomList<string>() { "Monday", "Wednesday", "Friday", "Sunday" };
            CustomList<string> weekdays2 = new CustomList<string>() { "Tuesday", "Thursday", "Saturday" };

            CustomList<string> weekdays = new CustomList<string>();

            //Act
           
            weekdays = weekdays1.Zip(weekdays2);

            //Assert
            Assert.AreEqual(7, weekdays.count);
        }

        [TestMethod]
        public void Zipper_ResizedArray_True()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 6, 8 };


            CustomList<int> resultList = new CustomList<int>();
            //Act
            resultList = list1.Zip(list2);

            //Assert
            Assert.AreEqual(8, resultList.capacity);

        }
        [TestMethod]
        public void Zipper_GivenNulls_Zip()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int>() { 0 };

            CustomList<int> resultList = new CustomList<int>();
            //Act
            
            resultList = list1.Zip(list2);

            //Assert
            Assert.AreEqual(5, resultList[3]);

        }
        [TestMethod]
        public void Iterator_Iteration_Done()
        {
            //Arrange
            CustomList<int> numbers = new CustomList<int>() { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            CustomList<int> expectedList = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            CustomList<int> actualList = new CustomList<int>();
            //Act
            foreach(int all in numbers)
            {
                actualList.Add(all);
            }
            //Assert
            for (int i = 0; i < expectedList.count; i++)
            {
                Assert.AreEqual(expectedList[i], actualList[i]);
            }

        }
        [TestMethod]
        public void Iterator_IterationWithLogic_Pass()
        {
            //Arrange
            CustomList<int> numbers = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            CustomList<int> oddsList = new CustomList<int>() { 1,3,5,7,9,11,13,15};
            CustomList<int> expectedList = new CustomList<int>();
            //Act
            foreach (int odds in numbers)
            {
                if(odds % 2 != 0)
                {
                    expectedList.Add(odds);
                }
            }
            //Assert
            for(int i = 0; i < oddsList.count; i++)
            {
                Assert.AreEqual(expectedList[i], oddsList[i]);
            }

        }
        [TestMethod]
        public void Iterator_IterationStopsAtEnd_True()
        {
            //Arrange
            CustomList<string> actualList = new CustomList<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            CustomList<string> expectedList = new CustomList<string>();
            int expectedValue = 5;
            //Act
            foreach (string day in actualList)
            {
                expectedList.Add(day);
            }
            //Assert
            Assert.AreEqual(expectedValue, expectedList.count);
            
        }

    }
}
