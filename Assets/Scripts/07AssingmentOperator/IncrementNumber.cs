using UnityEngine;

public class IncrementNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //정수형 변수의 값을 1씩 증가(이 수업에서는: 누적식이라고 함)
        //[1]변수 선언 및 초기화
        int num = 10;
        num = num + 1; //1씩 증가 누적식
        Debug.Log(num); //11

        //정수형 변수의 값을 1씩 감소
        int number = 10;
        number = number - 1; 
        Debug.Log(number); //9

        //축약해서 사용하기
        int x = 10;
        //x = x + 1; 를 축약
        x += 1; //1씩 증가 누적식
        Debug.Log($"x: {x}");

        int a = 3;
        int b = 5;

        b -= a; //a씩 감산 누적식
        Debug.Log($"b: {b}");

    }

}
