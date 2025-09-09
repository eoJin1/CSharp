using Unity.VisualScripting;
using UnityEngine;

//[Q]While문을 이용해서 1부터 100까지의 정수 중 홀수들의 합을 구하는 프로그램 구현
public class DoWhileSum : MonoBehaviour
{
    //변수 선언하고 초기화
    public int n = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int sum = 0; //합을 저장하는 변수

        //[1] 초기식
        int i = 1;

        //[2] 조건식
        do
        {
            //반복 실행문
            if (i % 2 != 0) //조건문, 필터링
            {
                sum = sum + i;
            }

            //[2] 증감식
            i++;

            //출력
            Debug.Log($"1부터 {n}까지의 정수 중 짝수의 합 : {sum}");
        }
        
        //[3] 조건식
        while (i < 3);

        }
    }

