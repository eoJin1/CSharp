using UnityEngine;
using UnityEngine.Rendering;

//var : 암시적으로 형식화된 로컬 변수
//(함수 안에서 선언되는 변수를 로컬 변수라고 함, 그래서 var는 함수 안에서만 사용할 수 있다)
public class VarDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
         int i = 1234;               //정수
         string s = "안녕하세요";     //문자열
         char c = 'a';               //문자
         double d = 3.14;            //실수형

         //타입을 알아보기
         //Debug.Log(i.GetType());

         Debug.Log(i.GetType());
         Debug.Log(s.GetType());
         Debug.Log(c.GetType());
         Debug.Log(d.GetType());
        */

        var name = "홍길동";       //"홍길동" 값을 보고 name변수의 타입을 string으로 결정
        Debug.Log(name);
        Debug.Log(name.GetType());

        var version = 8.0;      //8.0 값을 보고 version변수의 타입을 double형으로 결정
        Debug.Log(version);
        Debug.Log(version.GetType());

        var number = 1;         //1 값을 보고 number변수의 타입을 int형으로 결정
        Debug.Log(number);
        Debug.Log(number.GetType());

    }


}
