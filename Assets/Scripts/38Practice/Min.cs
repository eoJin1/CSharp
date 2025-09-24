using System.Linq;
using UnityEngine;

public class Min : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //변수 선언 및 초기화
        int[] numbers = { -2, -5, -4, -7, -1 };
        //최소값 저장
        int minValue = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minValue)
            {  
                minValue = numbers[i]; 
            }
        }

        Debug.Log($"최소값은 {minValue}");

        int minimumValue = numbers.Min();
        Debug.Log($"Linq 최소값은 {minValue}");
    }

}
/*
데이터 { -2, -5, -4, -7, -1 }
입력된 데이터 중 최소값을 구하시오.

숫자 두개를 비교 - 더 작은 숫자를 남겨서 minValue에 넣고 다른 숫자랑 비교 - 이후 반복

*/