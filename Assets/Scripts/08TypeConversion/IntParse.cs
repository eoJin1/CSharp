using UnityEngine;

public class IntParse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //문자를 수로 변환(파즈, 파싱이라고 함)
        //숫자를 문자로 변환하는 이유: 관리하기 편해서.

        string strnumber = "1234";

        int number1 = System.Convert.ToInt32(strnumber);
        Debug.Log($"{number1} - {number1.GetType()}");

        int number2 = int.Parse(strnumber);
        Debug.Log($"{number2} - {number2.GetType()}");

        int number3 = System.Int32.Parse(strnumber);
        Debug.Log($"{number3} - {number3.GetType()}");


    }

    
}
