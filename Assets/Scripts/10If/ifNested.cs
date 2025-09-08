using UnityEngine;

public class ifNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //중첩 if
        //if문 안에 다른 if문이 있는 것을 중첩이라고 함
        //4개 이상은 되도록 하지 마라 코드의 가독성이 떨어짐
        /*
        string name = "홍길동";
        int age = 20;

        //이름이 홍길동과 같으면 실행문 실행
        if (name == "홍길동")
        {

            //실행문 : 만약 나이가 20과 같으면 실행문 실행
            if (age == 20)
            {

                //실행문
                Debug.Log($"이름은 {name}, 나이는 {age}.");
        */

        //if And
        int number = 1234;

        //조건 : number가 1234와 같은가?, number가 1000 이상인가?
        //두가지 조건을 모두 만족하면(&&) "맞습니다" 출력
            if(number == 1234 && number >= 1000)    // true && true => true
        {
            Debug.Log("맞습니다");
        }
            //조건 : number가 1234와 같은가? number가 1000 이하인가?
            //두가지 조건 중 하나라도 만족하면 "하나라도 참이면 참" 출력
            if(number == 1234 || number <= 1000)    // true || false => true
        {
            Debug.Log("하나라도 참이면 참");
        }

                
            }


    
}
