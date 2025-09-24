using UnityEngine;

public class Max : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //변수 선언 및 초기화
        int[] numbers = { -2, -5, -4, -7, -1 };
        //최대값 저장
        int maxValue = int.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > maxValue)
            {
                maxValue = numbers[i];
            }
        }

        Debug.Log($"최대값은 {maxValue}");
    }

}

//데이터 { -2, -5, -4, -7, -1 }
//입력된 데이터 중 최대값을 구하시오.