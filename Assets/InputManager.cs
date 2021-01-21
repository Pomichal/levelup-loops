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

    }

    // exercise 2
    public void EvenNumbers()
    {
        int min = int.Parse(input1.text);

        // TODO: print out even numbers from range min, min + 10
    }

    // exercise 3
    public void SumOfNumbers()
    {
        int n = int.Parse(input1.text);

        // TODO: print out the sum of integers from 0 to n
        // n = 3 -> result = 6

    }

    // exercise 4
    public void SumOfDigits()
    {
        int n = int.Parse(input1.text);

        // TODO: print out the sum of digits of the number
        // n = 145 -> result = 10

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
    }

    // exercise 6
    public void Fibonacci()
    {
        int n = int.Parse(input1.text);

        // TODO: print out the first n Fibonacci's numbers
        // n = 6 -> result = "0, 1, 1, 2, 3, 5)

    }

    // exercise 7
    public void Palindrome()
    {
        string word = input1.text;

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
