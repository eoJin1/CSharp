using UnityEngine;

public class SequenceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int kor = 100;
        int eng = 90;

        int total = 0;      //총점을 저장하는 변수 선언
        double avg = 0;     //평균을 저장하는 변수 선언

        total = kor + eng;  //총점 구하기
        avg = total / 2.0;  //2가 아닌 2.0으로 나누는 이유는 정수끼리 계산하면 정수만 남고 일부가 날아가기 때문임. 실수로 해야 실수가 나옴

        Debug.Log($"총점: {total}");
        Debug.Log($"평균: {avg:F1}"); //F1 - 소수점 한자리까지만 출력. 실수를 출력할때는 포맷을 정해주는게 좋음

    }

}

/*
- 제어문 : 프로그램의 흐름(순서)를 정하는 명령문
[1]순차문 : 기본적으로 모든 명령문은 순서대로 (위에서 아래로) 실행된다
[2]조건문 : if, switch 등 
[3]반복문 : for, while...
[4]기타 : ?
*/