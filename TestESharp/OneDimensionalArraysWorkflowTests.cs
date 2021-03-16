using System;
using ESharp.DataStructures.OneDimensionalArray;
using ESharp.ESharpSourceCode.OneDimensionalArraysWorkflow;
using NUnit.Framework;

namespace TestESharp
{
    public class OneDimensionalArraysWorkflowTests
    {
        private IAbstractOneDimensionalArraysWorkflow _oneDimensionalArraysWorkflow;
        private IAbstractOneDimensionalArrayObject _oneDimensionalArray;
        
        [SetUp]
        public void Setup()
        {
            _oneDimensionalArraysWorkflow = 
                OneDimensionalArraysWorkflowFactoryObject.GetOneDimensionalArraysWorkflowObject();

            _oneDimensionalArray = OneDimensionalArrayFactoryObject.GetOneDimensionalArrayObject();
        }

        [Test]
        public void Test_GetMinimumValueFromArray_()
        {
            _oneDimensionalArray.SetOneDimensionalArray(new []{1, 2, 3, 4, 5});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetMinimumValueFromArray(_oneDimensionalArray) == 1);
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{-11, -232, -43, -54, -95});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetMinimumValueFromArray(_oneDimensionalArray) == -232);
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{-3241, 122, -33, 544, 345});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetMinimumValueFromArray(_oneDimensionalArray) == -3241);
        }
        
        [Test]
        public void Test_GetMaximumValueFromArray_()
        {
            _oneDimensionalArray.SetOneDimensionalArray(new []{1, 2, 3, 4, 5});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetMaximumValueFromArray(_oneDimensionalArray) == 5);
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{-11, -232, -43, -54, -95});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetMaximumValueFromArray(_oneDimensionalArray) == -11);
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{-3241, 122, -33, 544, 345});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetMaximumValueFromArray(_oneDimensionalArray) == 544);
        }
        
        [Test]
        public void Test_GetArrayElementsSum_()
        {
            _oneDimensionalArray.SetOneDimensionalArray(new []{1, 2, 3, 4, 5});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetArrayElementsSum(_oneDimensionalArray) == 15);
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{-11, -232, -43, -54, -95});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetArrayElementsSum(_oneDimensionalArray) == -435);
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{-3241, 122, -33, 544, 345});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetArrayElementsSum(_oneDimensionalArray) == -2263);
        }
        
        [Test]
        public void Test_GetArrayElementsProduct_()
        {
            _oneDimensionalArray.SetOneDimensionalArray(new []{1, 2, 3, 4, 5});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetArrayElementsProduct(_oneDimensionalArray) == 120);
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{-11, 2, -4, -10, 12});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetArrayElementsProduct(_oneDimensionalArray) == -10560);
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{1, 122, -33, 0, 345});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetArrayElementsProduct(_oneDimensionalArray) == 0);
        }
        
        [Test]
        public void Test_GetArrayElementsDifference_()
        {
            _oneDimensionalArray.SetOneDimensionalArray(new []{1, 2, 3, 4, 5});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetArrayElementsDifference(_oneDimensionalArray) == -13);
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{-11, 2, -4, -10, 12});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetArrayElementsDifference(_oneDimensionalArray) == -11);
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{1, 122, -33, 0, 345});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetArrayElementsDifference(_oneDimensionalArray) == -433);
        }
        
        [Test]
        public void Test_GetArrayElementsDivision_()
        {
            _oneDimensionalArray.SetOneDimensionalArray(new []{1, 2, 3, 4, 5});
            Assert.IsTrue(Math.Abs(_oneDimensionalArraysWorkflow.GetArrayElementsDivision(_oneDimensionalArray) - 0.0083) < 2);
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{-11, 2, -4, -10, 12});
            Assert.IsTrue(Math.Abs(_oneDimensionalArraysWorkflow.GetArrayElementsDivision(_oneDimensionalArray) - (-1.65)) < 2);
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{345, 1, 2, 7});
            Assert.IsTrue(Math.Abs(_oneDimensionalArraysWorkflow.GetArrayElementsDivision(_oneDimensionalArray) - 24.64) < 2);
        }
        
        [Test]
        public void Test_GetArrayElementsMean_()
        {
            _oneDimensionalArray.SetOneDimensionalArray(new []{1, 2, 3, 4, 5});
            Assert.IsTrue(Math.Abs(_oneDimensionalArraysWorkflow.GetArrayElementsMean(_oneDimensionalArray) - 3) < 2);
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{-11, 2, -4, -10, 12});
            Assert.IsTrue(Math.Abs(_oneDimensionalArraysWorkflow.GetArrayElementsMean(_oneDimensionalArray) - (-2.2)) < 2);
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{345, 1, 2, 7});
            Assert.IsTrue(Math.Abs(_oneDimensionalArraysWorkflow.GetArrayElementsMean(_oneDimensionalArray) - 88.75) < 2);
        }

        [Test]
        public void Test_IsArraySymmetric_()
        {
         
            _oneDimensionalArray.SetOneDimensionalArray(new []{1, 2, 3, 2, 1});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.IsArraySymmetric(_oneDimensionalArray));
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{1, 2, 3, 2, 6});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.IsArraySymmetric(_oneDimensionalArray) == false);

            _oneDimensionalArray.SetOneDimensionalArray(new []{-101, -222, -222, -101});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.IsArraySymmetric(_oneDimensionalArray));
        }

        [Test]
        public void Test_AddValueInArray_()
        {
            _oneDimensionalArray.SetOneDimensionalArray(new []{1, 2, 3, 4, 5});
            
            Assert.AreEqual(_oneDimensionalArraysWorkflow.AddValueInArray(_oneDimensionalArray ,13).
                    GetOneDimensionalArray(),
                new []{1, 2, 3, 4, 5, 13});  
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{-5, -3, -1});
            
            Assert.AreEqual(_oneDimensionalArraysWorkflow.AddValueInArray(_oneDimensionalArray, -69).
                    GetOneDimensionalArray()
            , new []{-5, -3, -1, -69});
        }
        
        [Test]
        public void Test_IsValueInArray_()
        {
            _oneDimensionalArray.SetOneDimensionalArray(new []{1, 2, 3, 4, 5});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.IsValueInArray(_oneDimensionalArray, 5));
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{-11, 2, -4, -10, 12});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.IsValueInArray(_oneDimensionalArray, 0) == false);
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{1, 122, -33, 0, 345});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.IsValueInArray(_oneDimensionalArray, 345));
        }
        
        [Test]
        public void Test_ConvertNumberToArray_()
        {
            Assert.AreEqual(_oneDimensionalArraysWorkflow.ConvertNumberToArray(345) , new []{3, 4, 5});
            Assert.AreEqual(_oneDimensionalArraysWorkflow.ConvertNumberToArray(12345), new []{1, 2, 3, 4, 5});
            Assert.AreEqual(_oneDimensionalArraysWorkflow.ConvertNumberToArray(963), new []{9, 6, 3});
        }
        
        [Test]
        public void Test_ConvertArrayToNumber_()
        {
            Assert.IsTrue(_oneDimensionalArraysWorkflow.ConvertArrayToNumber(new []{3, 4, 5}) == 345);
            Assert.IsTrue(_oneDimensionalArraysWorkflow.ConvertArrayToNumber(new []{1, 2, 3, 4, 5}) == 12345);
            Assert.IsTrue(_oneDimensionalArraysWorkflow.ConvertArrayToNumber(new []{9, 6, 3}) == 963);
        }

        [Test]
        public void Test_BoostUpArray_()
        {
            _oneDimensionalArray.SetOneDimensionalArray(new []{0, 1, 2, 3, 4, 5});
            
            Assert.AreEqual(_oneDimensionalArraysWorkflow.BoostUpArray(_oneDimensionalArray, 2).
                    GetOneDimensionalArray(), 
                new []{0, 2, 4, 6, 8, 10});
            
            
            Assert.AreEqual(_oneDimensionalArraysWorkflow.BoostUpArray(_oneDimensionalArray, 5).
                    GetOneDimensionalArray(), 
                new []{0, 10, 20, 30, 40, 50});
            
            Assert.AreEqual(_oneDimensionalArraysWorkflow.BoostUpArray(_oneDimensionalArray, 0).
                    GetOneDimensionalArray(), 
                new []{0, 0, 0, 0, 0, 0});
        }
        
        [Test]
        public void Test_BoostDownArray_()
        {
            _oneDimensionalArray.SetOneDimensionalArray(new []{32, 1, 2, 3, 4, 5});
          
            Assert.AreEqual(_oneDimensionalArraysWorkflow.BoostDownArray(_oneDimensionalArray, 2).
                    GetOneDimensionalArray(), 
                new []{16, 0, 1, 1, 2, 2});
            
            _oneDimensionalArray.SetOneDimensionalArray(new []{32, 1, 2, 3, 4, 5});
            
            Assert.AreEqual(_oneDimensionalArraysWorkflow.BoostDownArray(_oneDimensionalArray, 5).
                 GetOneDimensionalArray(), 
             new []{6, 0, 0, 0, 0, 1});

            _oneDimensionalArray.SetOneDimensionalArray(new []{32, 1, 2, 3, 4, 5});
            
            Assert.AreEqual(_oneDimensionalArraysWorkflow.BoostDownArray(_oneDimensionalArray, 1).
                 GetOneDimensionalArray(), 
             new []{32, 1, 2, 3, 4, 5});
        }

        [Test]
        public void Test_AreArraysEqual_()
        {

            var arrayOne = OneDimensionalArrayFactoryObject.GetOneDimensionalArrayObject();
            var arrayTwo = OneDimensionalArrayFactoryObject.GetOneDimensionalArrayObject();
            
            arrayOne.SetOneDimensionalArray(new []{1, 2, 3, 4, 5});
            arrayTwo.SetOneDimensionalArray(new []{1, 2, 3, 4, 5});
            
            Assert.IsTrue(_oneDimensionalArraysWorkflow.AreArraysEqual(arrayOne, arrayTwo));
            
            arrayOne.SetOneDimensionalArray(new []{-1, 2, -3, 4, -5});
            arrayTwo.SetOneDimensionalArray(new []{-1, 2, -3, 4, -5});
            
            Assert.IsTrue(_oneDimensionalArraysWorkflow.AreArraysEqual(arrayOne, arrayTwo));
        }
        
    }
}