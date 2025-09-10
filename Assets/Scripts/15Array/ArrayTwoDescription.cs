using UnityEngine;

public class ArrayTwoDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 2차원 배열 선언, 첫번째 요소수만 생성
        int[][] intArray = new int[2][];

        //[2] 두번째 요소수를 각각 따로 생성, 초기화
        intArray[0] = new int[3] { 1, 2, 3 };
        intArray[1] = new int[2] { 4, 5 };

        //배열의 길이
        Debug.Log($"배열의 길이: {intArray.Length}");

        //[3] 배열의 요소를 출력 : intArray.Length, intArray[i].Length
        for ( int i = 0; i < intArray.Length; i++ )
        {
            //Debug.Log($"intArray[{i}] : {intArray[i].Length}");
            for (int j = 0; j < intArray.Length; j++)
            {
                Debug.Log($"intArray[{i}{j}] : {intArray[i][j]}");
            }
            Debug.Log("=====================");
        }

    }

}
