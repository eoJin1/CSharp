using UnityEngine;

public class TypeConversionError : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*   //[1] long 형식 변수 선언하고 가장 큰 수를 저장
           long l = long.MaxValue;
           Debug.Log($"l의 값: {l}");
           //아주 큰 수가 나온다. 하지만...
           //[2] int 형식의 변수에 i 값을 저장
           int i = (int)l;
           Debug.Log($"i의 값: {i}"); */

        /* int x = 255;
        byte y = x; 
        위 식은 불가능, -21억~21억인 int에 0~255인 byte가 들어갈 수 없다
         */

        int x = 255;
        byte y = (byte)x;

        //이렇게 형변환을 해주면 들어간다. 타입 컨버전이라고 함

    }


}
