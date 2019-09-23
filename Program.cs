/* NAME :SACHIN PRATAP SINGH
 * MS-BAIS
 * ASSIGNMENT-1(ISM6225)*/

using System;

namespace Assingment1_dis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Self dividing number between a and b are:");
            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);
            Console.WriteLine();

            Console.WriteLine("---------------------------------------------- ");
            Console.WriteLine("Required series for the given positive integer no. n2 is :");
            Console.WriteLine(" ");
            int n2 = 5;
            printSeries(n2);

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------- ");
            Console.WriteLine("Required Inverted triangle for any given odd positive integer n3 is:");
            Console.WriteLine(" ");
            int n3 = 5;
            printTriangle(n3);

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------- ");
            Console.WriteLine("Required count of  given j in s is :");
            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3,3,2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);
            Console.WriteLine("---------------------------------------------- ");
            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };

            //int[] r5 = getLargestCommonSubArray(arr1, arr2); 
            //Console.WriteLine(r5);

            //  solvePuzzle();

        }
        
//This method accepts the two values as x and z to print self dividing numbers between x and z.(positive integers only)
        static int printSelfDividingNumbers(int x, int z)
        {
            try
            {
                for (int i = x; i <= z; i++)// Loop will work through the given range of inputs.
                {
                        int n = i;
// This method checks whether no is self dividing or not and returns true or false if no is self dividing or not, respectively.
                    isselfDividing(n);
                        if (isselfDividing(n))
                        {
                            Console.Write(n);
                        Console.Write(",");
                        }//end of if
                }// end of for
 // this function divides the no by  its digits and returns true if no is divided by its digits or return false. 
                    bool isselfDividing(int n)
                    {
                        int y = n;
                        while (y > 0)
                        {
                            int d = y % 10;// this operation calculates the last digit.
                            y = y / 10;
 // this condition checks the digit =0 as number can not be divided by zero and n%d!=0 means number is not divisible by its digits hence returns false.
                        if (d == 0 || (n % d) > 0)
                            {
                                return false;
                            } //end of if
                        } //end of while
                        return true;
                    } // end of isself dividing()
                  
            }//end of try
           
        catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }// end of catch
            return 0;// method should return any value.
        }//end of printSelfDividingNumbers()


        //this method will print the required series for given postive integer.
        static int printSeries(int d)
        {
            try
            {
                int i;
                int j;
                int count = 0;
                for (i = 1; i <= d; i++) // i sets the limit of series
                {
                    for (j = 1; j <= i; j++)//this loops calculates the iteration for i.
                    {
                        if (count < d)  // no of steps
                        {
                            Console.Write(i);
                            Console.Write(",");
                            count = count + 1;
                        }//end of if
                    }//end of for 

                }//end of for
            }// end of try
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }// end of catch
            return 0;
        }// end of printSeries()

        // This method prints the inverted triangle for any given odd positive integer except 1.
        static int printTriangle(int e)
        {
          try
          {
            int i;
            int j;
            int k;
            for (i = 1; i <= e; i++) // e is the no of rows 
            {
                for (k = 1; k <= i - 1; k++)// this loop prints the requied number of spaces in each row.
                {
                    Console.Write(" ");
                }// end of for loop
                for (j = (2 * e - 2 * i + 1); j >= 1; j--)//this loop prints the required no of stars.
                {
                    Console.Write("*");
                }// end of for loop
                Console.WriteLine(); // changing the row
            } // end of for loop
          }// end of try
           catch
           {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
           }// end of catch
            return 0; 
        } // end of printtriangle()

// this function compares the two array elements and returns the count of one into others.
        public static int numJewelsInStones(int[] a, int[] b)
        {
            try
            {
                int count = 0;
                foreach (int i in a) // this loop reads the elements of array a.
                {
                    foreach (int l in b) // this loop reads the elements of array b and compares and count the required elements. 
                    {
                        if (i == l)
                        {
                            count = count + 1; // count of common elements.
                        }// end of if
                    }// end of for reach
                }// end of for each
                return count;// value count is returning to the calling function
            }//end of try
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }// end of catch
            return 0; 
        }//end of numJewelsInStones
    }
}


