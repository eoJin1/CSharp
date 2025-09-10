using Unity.Burst.Intrinsics;
using UnityEngine;

public class ArrayTwoNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 2차원 배열 선언, 요소수(크기) 생성, 초기화
        //int[,] intArray = new int[2,3] { { 1,2,3 },{ 4,5,6 } };
        //[1-2] 2차원 배열 선언, 요소수(크기) 생략, 초기화
        //int[,] intArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } }; //대괄호 안에 대괄호를 두개 넣으면 2행, 세개 넣으면 3행... 메모리가 늘어난다
        //[1-3] 2차원 배열 선언, 초기화
        int[,] intArray = { { 1, 2, 3 }, { 4, 5, 6 } };

        Debug.Log($"배열의 길이: {intArray.Length}");

        //출력 : 행의 길이 intArray.GetLength(0)
        for ( int i = 0; i < intArray.GetLength(0); i++ )
        {
            //열의 길이 intArray.GetLength(1)
            for (int j = 0; j < intArray.GetLength(1); j++)
            {
                Debug.Log($"intArray[{i},{j}] : {intArray[i,j]}");
            }
        }
    }

}
