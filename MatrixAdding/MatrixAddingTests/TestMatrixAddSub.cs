using MatrixAdding;
using NUnit.Framework;

namespace MatrixAddingTests
{
    public class Tests
    {


        private static readonly object[] ArraysPlusOperator =
       {
            new object[]
            {
                new double[3, 4]
                {
                    {1, 2, 3, 4},
                    {1, 2, 3, 4},
                    {1, 2, 3, 4}
                },
                new double[3, 4]
                {
                    {4, 3, 2, 1},
                    {4, 3, 2, 1},
                    {4, 3, 2, 1},
                },
                new double[3, 4]
                {
                    {5, 5, 5, 5},
                    {5, 5, 5, 5},
                    {5, 5, 5, 5},
                }
            },
            new object[]
            {
                new double[3, 4]
                {
                    {1, 1, 1, 1},
                    {1, 1, 1, 1},
                    {1, 1, 1, 1}
                },
                new double[3, 4]
                {
                    {2, 2, 2, 2},
                    {2, 2, 2, 2},
                    {2, 2, 2, 2},
                },
                new double[3, 4]
                {
                    {3, 3, 3, 3},
                    {3, 3, 3, 3},
                    {3, 3, 3, 3},
                }
            }

        };

        private static readonly object[] ArraysSubOperator =
       {
            new object[]
            {
                new double[3, 4]
                {
                    {1, 2, 3, 4},
                    {1, 2, 3, 4},
                    {1, 2, 3, 4}
                },
                new double[3, 4]
                {
                    {4, 3, 2, 1},
                    {4, 3, 2, 1},
                    {4, 3, 2, 1},
                },
                new double[3, 4]
                {
                    {-3, -1, 1, 3},
                    {-3, -1, 1, 3},
                    {-3, -1, 1, 3},
                }
            },
            new object[]
            {
                new double[3, 4]
                {
                    {1, 1, 1, 1},
                    {1, 1, 1, 1},
                    {1, 1, 1, 1}
                },
                new double[3, 4]
                {
                    {2, 2, 2, 2},
                    {2, 2, 2, 2},
                    {2, 2, 2, 2},
                },
                new double[3, 4]
                {
                    {-1, -1, -1, -1},
                    {-1, -1, -1, -1},
                    {-1, -1, -1, -1},
                }
            }

        };
        [TestCaseSource(nameof(ArraysPlusOperator))]
        public void Matrix_Add_Works_Correctly(double[,] matrix1, double[,] matrix2, double[,] result)
        {
            double[,] actual = matrix1.Add(matrix2);
            Assert.AreEqual(result,actual);
        }

        [TestCaseSource(nameof(ArraysPlusOperator))]
        public void Matrix_AddIn1Thread_Works_Correctly(double[,] matrix1, double[,] matrix2, double[,] result)
        {
            double[,] actual = matrix1.AddMultithreading(matrix2, 1);
            Assert.AreEqual(result, actual);
        }
        [TestCaseSource(nameof(ArraysPlusOperator))]
        public void Matrix_AddIn2Thread_Works_Correctly(double[,] matrix1, double[,] matrix2, double[,] result)
        {
            double[,] actual = matrix1.AddMultithreading(matrix2, 2);
            Assert.AreEqual(result, actual);
        }
        [TestCaseSource(nameof(ArraysPlusOperator))]
        public void Matrix_AddIn3Thread_Works_Correctly(double[,] matrix1, double[,] matrix2, double[,] result)
        {
            double[,] actual = matrix1.AddMultithreading(matrix2,3);
            Assert.AreEqual(result, actual);
        }


        [TestCaseSource(nameof(ArraysSubOperator))]
        public void Matrix_Sub_Works_Correctly(double[,] matrix1, double[,] matrix2, double[,] result)
        {
            double[,] actual = matrix1.Subtract(matrix2);
            Assert.AreEqual(result, actual);
        }

        [TestCaseSource(nameof(ArraysSubOperator))]
        public void Matrix_SubIn1Thread_Works_Correctly(double[,] matrix1, double[,] matrix2, double[,] result)
        {
            double[,] actual = matrix1.SubtractMultithreading(matrix2, 1);
            Assert.AreEqual(result, actual);
        }
        [TestCaseSource(nameof(ArraysSubOperator))]
        public void Matrix_SubIn2Thread_Works_Correctly(double[,] matrix1, double[,] matrix2, double[,] result)
        {
            double[,] actual = matrix1.SubtractMultithreading(matrix2, 2);
            Assert.AreEqual(result, actual);
        }
        [TestCaseSource(nameof(ArraysSubOperator))]
        public void Matrix_SubIn3Thread_Works_Correctly(double[,] matrix1, double[,] matrix2, double[,] result)
        {
            double[,] actual = matrix1.SubtractMultithreading(matrix2, 3);
            Assert.AreEqual(result, actual);
        }
    }
}

