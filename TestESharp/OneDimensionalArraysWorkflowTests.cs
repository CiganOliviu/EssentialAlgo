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
            _oneDimensionalArray.SetOneDimensionalArray(new int []{1, 2, 3, 4, 5});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetMinimumValueFromArray(_oneDimensionalArray) == 1);
            
            _oneDimensionalArray.SetOneDimensionalArray(new int []{-11, -232, -43, -54, -95});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetMinimumValueFromArray(_oneDimensionalArray) == -232);
            
            _oneDimensionalArray.SetOneDimensionalArray(new int []{-3241, 122, -33, 544, 345});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetMinimumValueFromArray(_oneDimensionalArray) == -3241);
        }
        
        [Test]
        public void Test_GetMaximumValueFromArray_()
        {
            _oneDimensionalArray.SetOneDimensionalArray(new int []{1, 2, 3, 4, 5});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetMaximumValueFromArray(_oneDimensionalArray) == 5);
            
            _oneDimensionalArray.SetOneDimensionalArray(new int []{-11, -232, -43, -54, -95});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetMaximumValueFromArray(_oneDimensionalArray) == -11);
            
            _oneDimensionalArray.SetOneDimensionalArray(new int []{-3241, 122, -33, 544, 345});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetMaximumValueFromArray(_oneDimensionalArray) == 544);
        }
        
        [Test]
        public void Test_GetArrayElementsSum_()
        {
            _oneDimensionalArray.SetOneDimensionalArray(new int []{1, 2, 3, 4, 5});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetArrayElementsSum(_oneDimensionalArray) == 15);
            
            _oneDimensionalArray.SetOneDimensionalArray(new int []{-11, -232, -43, -54, -95});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetArrayElementsSum(_oneDimensionalArray) == -435);
            
            _oneDimensionalArray.SetOneDimensionalArray(new int []{-3241, 122, -33, 544, 345});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetArrayElementsSum(_oneDimensionalArray) == -2263);
        }
        
        [Test]
        public void Test_GetArrayElementsProduct_()
        {
            _oneDimensionalArray.SetOneDimensionalArray(new int []{1, 2, 3, 4, 5});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetArrayElementsProduct(_oneDimensionalArray) == 120);
            
            _oneDimensionalArray.SetOneDimensionalArray(new int []{-11, 2, -4, -10, 12});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetArrayElementsProduct(_oneDimensionalArray) == -10560);
            
            _oneDimensionalArray.SetOneDimensionalArray(new int []{1, 122, -33, 0, 345});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetArrayElementsProduct(_oneDimensionalArray) == 0);
        }
        
        [Test]
        public void Test_GetArrayElementsDifference_()
        {
            _oneDimensionalArray.SetOneDimensionalArray(new int []{1, 2, 3, 4, 5});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetArrayElementsDifference(_oneDimensionalArray) == -13);
            
            _oneDimensionalArray.SetOneDimensionalArray(new int []{-11, 2, -4, -10, 12});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetArrayElementsDifference(_oneDimensionalArray) == -11);
            
            _oneDimensionalArray.SetOneDimensionalArray(new int []{1, 122, -33, 0, 345});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.GetArrayElementsDifference(_oneDimensionalArray) == -433);
        }
        
        [Test]
        public void Test_GetArrayElementsDivision_()
        {
            _oneDimensionalArray.SetOneDimensionalArray(new int []{1, 2, 3, 4, 5});
            Assert.IsTrue(Math.Abs(_oneDimensionalArraysWorkflow.GetArrayElementsDivision(_oneDimensionalArray) - 0.0083) < 2);
            
            _oneDimensionalArray.SetOneDimensionalArray(new int []{-11, 2, -4, -10, 12});
            Assert.IsTrue(Math.Abs(_oneDimensionalArraysWorkflow.GetArrayElementsDivision(_oneDimensionalArray) - (-1.65)) < 2);
            
            _oneDimensionalArray.SetOneDimensionalArray(new int []{345, 1, 2, 7});
            Assert.IsTrue(Math.Abs(_oneDimensionalArraysWorkflow.GetArrayElementsDivision(_oneDimensionalArray) - 24.64) < 2);
        }
        
        [Test]
        public void Test_GetArrayElementsMean_()
        {
            _oneDimensionalArray.SetOneDimensionalArray(new int []{1, 2, 3, 4, 5});
            Assert.IsTrue(Math.Abs(_oneDimensionalArraysWorkflow.GetArrayElementsMean(_oneDimensionalArray) - 3) < 2);
            
            _oneDimensionalArray.SetOneDimensionalArray(new int []{-11, 2, -4, -10, 12});
            Assert.IsTrue(Math.Abs(_oneDimensionalArraysWorkflow.GetArrayElementsMean(_oneDimensionalArray) - (-2.2)) < 2);
            
            _oneDimensionalArray.SetOneDimensionalArray(new int []{345, 1, 2, 7});
            Assert.IsTrue(Math.Abs(_oneDimensionalArraysWorkflow.GetArrayElementsMean(_oneDimensionalArray) - 88.75) < 2);
        }
        
        [Test]
        public void Test_IsValueInArray_()
        {
            _oneDimensionalArray.SetOneDimensionalArray(new int []{1, 2, 3, 4, 5});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.IsValueInArray(_oneDimensionalArray, 5) == true);
            
            _oneDimensionalArray.SetOneDimensionalArray(new int []{-11, 2, -4, -10, 12});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.IsValueInArray(_oneDimensionalArray, 0) == false);
            
            _oneDimensionalArray.SetOneDimensionalArray(new int []{1, 122, -33, 0, 345});
            Assert.IsTrue(_oneDimensionalArraysWorkflow.IsValueInArray(_oneDimensionalArray, 345) == true);
        }
        
        [Test]
        public void Test_ConvertNumberToArray_()
        {
            Assert.AreEqual(_oneDimensionalArraysWorkflow.ConvertNumberToArray(345) , new int[]{3, 4, 5});
            Assert.AreEqual(_oneDimensionalArraysWorkflow.ConvertNumberToArray(12345), new int[]{1, 2, 3, 4, 5});
            Assert.AreEqual(_oneDimensionalArraysWorkflow.ConvertNumberToArray(963), new int[]{9, 6, 3});
        }
        
        [Test]
        public void Test_ConvertArrayToNumber_()
        {
            Assert.IsTrue(_oneDimensionalArraysWorkflow.ConvertArrayToNumber(new int[]{3, 4, 5}) == 345);
            Assert.IsTrue(_oneDimensionalArraysWorkflow.ConvertArrayToNumber(new int[]{1, 2, 3, 4, 5}) == 12345);
            Assert.IsTrue(_oneDimensionalArraysWorkflow.ConvertArrayToNumber(new int[]{9, 6, 3}) == 963);
        }
    }
}