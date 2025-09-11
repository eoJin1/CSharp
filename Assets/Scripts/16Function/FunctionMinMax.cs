using Unity.VisualScripting;
using UnityEngine;

public class FunctionMinMax : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //3, 5를 비교해 큰 수 출력 - GetSum() 호출
        int result = GetMax(3, 5);
        Debug.Log($"3과 5중 큰 수는 {result}");

        Debug.Log($"-3과 -5중 작은 수는 {GetMin(-3, -5)} 이다");

        //-21의 절대값을 구해서 출력
        int abs = GetAbs(-21);
        Debug.Log($"-21의 절대값은 {abs}");

    }
    int GetMax(int x, int y)
    {
        if (x < y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }
    //매개변수로 입력 받은 두개의 정수 중 작은수를 반환하는 함수
    int GetMin(int x, int y)
    {
     //3항 연산자
     int minValue = (x < y) ? x : y;
        return minValue;
    }

    //매개변수로 입력받은 정수의 절대값을 반환하는 함수 구현
    // -5 -> 5, -99 -> 99, 5-> 5, 143 -> 143
    int GetAbs(int number)
    {
        return (number < 0) ? -number : number;
    }

}
/*
//3항 연산자
//조건식이 참이면 첫번째값을 반환(가져다 사용)
//조건식이 거짓이면 두번째값을 반환(가져다 사용)

(조건식) ? 첫번째값 : 두번쨰값;


*/
/*
[Q]
1. 매개 변수로 입력 받은 두개의 정수 중 큰 수를 반환하는 함수를 구현
2. 매개 변수로 입력 받은 두개의 정수 중 작은수를 반환하는 함수를 구현
3. 3, 5를 입력받아 큰수 출력
4. -3과 -5를 입력받아 작은수 출력

[output]
3과 5중 큰 수는 {반환받은 값} 출력
-3과 -5중 작은 수는 {반환받은 값} 출력
*/