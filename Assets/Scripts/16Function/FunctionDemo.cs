using UnityEngine;

public class FunctionDemo : MonoBehaviour
{
    //[1] Show 메서드(함수) 선언, 정의
    //콘솔창에 Hello World 출력
    //(함수의 기능 주석을 이렇게 밑에 단다.)
    void Show()
    {
        Debug.Log("Hello World");
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] Show 함수 호출
        Show();
    }

}
/*
함수(Function), 메서드(Method)
: 반복해서 사용하도록 만들어진 하나 이상의 명령문으로 구성된 코드블록{}

- 내장함수 : 닷넷(C#)에서 제공, 유니티에서 제공하는 함수

- 사용자 함수 : 개발자가 만드는 함수
: 매개변수가 없는 함수
: 매개변수가 있는 함수
: 반환값이 있는 함수

void 함수이름()
{
    //하나 이상의 명령문
}
ㄴ매개 변수가 없는 함수

void 함수이름(매개 변수)
{
    //하나 이상의 명령문
}
ㄴ매개 변수가 있는 함수

(데이터 타입) 함수이름(매개 변수)
{
    //하나 이상의 명령문
    return (데이터 타입)변수;
}
ㄴ반환값이 있는 함수
(데이터 타입) 에 int를 썼으면 (데이터 타입)변수에도 int형의 변수를 반환해야 한다...
void 라고 썼으면 반환값이 없는 함수

//함수구성
입력 -> 처리(연산) -> 출력

*/