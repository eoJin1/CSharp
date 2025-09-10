using Unity.VisualScripting;
using UnityEngine;

public class BreakDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //합을 저장하는 변수
        int sum = 0; 
        //초기식
        int i = 1;
        //조건식
        while (i <= 10)
        {
            //반복 실행문
            sum = sum + i;
            //sum 체크
            if (sum >= 22)
            {
                break;
            }
            //증감식
            i++;
        }
        //출력
        Debug.Log($"sum은 {sum}");
        }
    }


/*
[Q]
1부터 10까지의 정수의 합(sum)을 구하는 프로그램 구현 
합(sum) 이 22 이상이 되면 더이상 합을 구하지 않는다
while문 이용
sum 출력
*/