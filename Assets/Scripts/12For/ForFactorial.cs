using UnityEngine;

public class ForFactorial : MonoBehaviour
{
    public int n = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        //4! 값을 구하라
        int factorial = 1;

        for (int i = 1; i <= 4;  i++)
        {
            factorial = factorial * i;
        }
        Debug.Log($"4! 값은 {factorial}");
        */

        //n! 값을 구하라
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
        }
        Debug.Log($"{n}! 값은 {factorial}");
    }

}

/*
Factorial (!)
1! = 1
2! = 1*2
3! = 1*2*3
4! = 1*2*3*4
n! = 1*2*3*...*(n-1)*n
*/