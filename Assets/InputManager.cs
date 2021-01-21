using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public TMP_InputField input1;
    public TextMeshProUGUI resultText;

    // exercise 1
    public void NumbersEverywhere()
    {

        // TODO: print out "10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0" (for loop)

        string solution = "";

        for(int i = 10; i >= 0; i--)
        {
            if(i == 0)
            {
                solution = solution + i;
            }
            else
            {
                solution = solution + i + ", ";
            }
        }
        PrintAnswer(solution);
    }

    // exercise 2
    public void EvenNumbers()
    {
        int min = int.Parse(input1.text);

        // TODO: print out even numbers from range min, min + 10

        string solution = "" + min;

        for(int i = min; i <= min + 10; i++)
        {
            if(i % 2 == 0)
            {
                solution += ", " + i;
            }
        }
        PrintAnswer(solution);
    }

    // exercise 3
    public void SumOfNumbers()
    {
        int n = int.Parse(input1.text);

        // TODO: print out the sum of integers from 0 to n
        // n = 3 -> result = 6 = 1 + 2 + 3

        int sum = 0;

        for(int i = 0; i <= n; i++) // 0, 1, 2, 3, ... n
        {
            sum += i;   // 0, 1, 3, 6, 10, ...
        }

        PrintAnswer(sum.ToString());
    }

    // exercise 4
    public void SumOfDigits()
    {
        int n = int.Parse(input1.text);

        // TODO: print out the sum of digits of the number
        // n = 145 -> result = 10

        int sum = 0;

        // 145 -> sum: 5, n : 14 -> sum: 9, n: 1 -> sum: 10, n : 0 -> end

        //while(n > 0)
        //{
            //sum += n % 10; // 145 % 10 = 5, 14 % 10 = 4
            //n /= 10;    // 145, 14, 1, 0
        //}

        for(int i = n; i > 0; i /= 10)
        {
            sum += i % 10;
        }

        PrintAnswer(sum.ToString());
    }

    // exercise 5
    public void CheckTheStars()
    {
        int n = int.Parse(input1.text);

        // TODO: print out the following pattern:
        // *
        // **
        // ***
        // ****
        // {number of rows = n, in this case n=4}
        //
        // i=0 *
        // i=1 **
        // i=2 ***
        // i=3 ****


        string solution = "";

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j <= i; j++)
            {
                solution += "*";
            }
            solution += "\n";
        }

        PrintAnswer(solution);
    }

    // exercise 6
    public void Fibonacci()
    {
        int n = int.Parse(input1.text);

        // Fibonacci numbers: 0, 1, 1, 2, 3, 5, 8, 13, 21, ...

        // TODO: print out the first n Fibonacci's numbers
        // n = 6 -> result = "0, 1, 1, 2, 3, 5")

        int a = 0;
        int b = 1;

        string result = "0, 1";

        int temp;

        for(int i = 2; i < n; i++)
        {
            temp = a + b;
            result += ", " + temp;
            a = b; // 0 -> 1, 1 -> 1, 1 -> 2, ...
            b = temp;
        }

        PrintAnswer(result);
    }

    // exercise 7
    public void Palindrome()
    {
        string word = input1.text;

        // word[0] - prvy znak

        // TODO: check, whether the word is a palindrome
        // abba -> is a palindrome, abcd -> is not a palindrome
    }

    // exercise 8
    public void FromDecimalToBinary()
    {
        int dec = int.Parse(input1.text);

        // TODO change the number dec from decimal to binary number
        // 6 -> "110"

    }

    // exercise 9
    public void NumbersAgain()
    {
        int n = int.Parse(input1.text);

        // TODO: print out the following pattern:
        // 12345
        //  123
        //   1
        // { n is number of rows, in this case n=3 }
    }

    // exercise 10
    public void EuclideanAlgorithm()
    {
        int a = int.Parse(input1.text);
        int b = Random.Range(1, a*2);   // randomly choose the second number

        // TODO: implement the Euclidean algorithm and find the greatest common divisor of a and b
    }

    // bonus exercise (work with lists needed)
    public void SieveOfEratosthenes()
    {
        int n = int.Parse(input1.text);

        // create a list of lenght n with true values
        List<bool> boolValues = Enumerable.Repeat(true, n).ToList();

        // get an element from list: boolValues[i]
        // set value: boolValues[i] = false;

        // TODO: implement sieve of Eratosthenes
    }

    public void IWantMoreExercises()
    {
        // TODO: ask for more exercises, if you are done with everything
    }

    // a helper method to show the result in the console and in resultText
    public void PrintAnswer(string solution)
    {
        Debug.Log(solution);
        resultText.text = solution;
    }
}
