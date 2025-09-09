using UnityEngine;

public class WhileCountdown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 5까지 Countdown 프로그램 구형

        //[1] 초기식
        int i = 1;

        //[2] 조건식
        while (i <= 5)

        {
            //반복 실행문
            Debug.Log($"증가 Countdown: {i}");
        }

        //[3] 증감식
        i++;

        Debug.Log($"================");

        //5부터 1까지 Countdown 프로그램 구현
        //[1] 초기식
        int j = 5;

        //[2] 조건식
        while (j >= 5)

        {
            //반복 실행문
            Debug.Log($"감소 Countdown: {j}");
        }

        //[3] 증감식
        j--;
    }

}
