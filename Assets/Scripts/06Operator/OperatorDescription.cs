using UnityEngine;

//Operator(연산자) : +, -, *, / 등의 연산을 진행하는 키워드
public class OperatorDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       /* Debug.Log(3 + 5);   //결과는 : 8
        Debug.Log(3 - 5);   //결과는 : -2
        Debug.Log(3 * 5);   //결과는 : 15
        Debug.Log(3 / 5);   //결과는 : 0*/

        //정수와 실수를 연산하면 실수가 나옴
        //정수와 정수를 연산하면 정수가 나옴
        //문자열과 정수를 더하면 문자열이 나옴

       /*
        int value = 0;
        value = 8;      //value라는 정수형 변수에 8을 저장
        value = +value; //
        Debug.Log(value);

        value = -8;
        value = +value; //
        Debug.Log(value);

        value = 8;
        value = -value; //
        Debug.Log(value); 

        value = -8;
        value = -value; //
        Debug.Log(value);
        */

        int i = 5;
        int j = 3;
        int k;

        k = i + j;
        Debug.Log(k);

        k = i - j;
        Debug.Log(k);

        k = i * j;
        Debug.Log(k);

        k = i / j;
        Debug.Log(k);

        k = i % j;
        Debug.Log(k);

    }
}

/*ctrl+shift+/ 단축키로 한번에 주석 처리 할 수 있음*/


/*


단항 연산자 : +, -
이항 연산자 : +, -, *, /, %
삼항 연산자

*/
