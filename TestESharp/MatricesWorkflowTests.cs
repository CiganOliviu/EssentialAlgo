using ESharp.ESharpSourceCode.MatricesWorkflow;
using NUnit.Framework;

namespace TestESharp
{
    public class MatricesWorkflowTests
    {
        private IAbstractMatricesWorkflow _matricesWorkflow;

        [SetUp]
        public void Setup()
        {
            _matricesWorkflow = MatricesWorkflowFactoryObject.GetMatricesWorkflowObject();
        }

        [Test]
        public void Test__()
        {
            Assert.Pass();
        }
    }
}