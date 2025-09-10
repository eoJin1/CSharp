using Unity.VisualScripting;
using UnityEngine;

public class BreakFor : MonoBehaviour
{
    //break; 반복문(for, while) {} 을 빠져나오는 명령문
    //       반복문(for, while)을 강제 종료 시킨다
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //5번 반복하는 for문 작성 - i가 2일때 for문 종료
        for (int i = 0; i < 5; i++)
        {
            if (i == 2)
            { 
            break;
            }
            //반복 실행문 1
 
        }
        //명령문 2

        //i=0 -> i<5(참) -> 반복문 -> i:1 -> i<5(참) -> 반복문
        // -> i=2 -> i<5(참) -> 반복문 -> break; -> for문 종료 -> 명령문 2
    }

}
