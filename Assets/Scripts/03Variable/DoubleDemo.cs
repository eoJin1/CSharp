using UnityEngine;

public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 변수 선언 및 초기화
        float f = 3.14f;
        double d = 3.14;
        decimal m = 3.14m;

        float min = float.MinValue;
        float max = float.MaxValue;

        //double형은 3.14 뒤에d를 생략해도 됨
        //그러나 float형의 f를 생략하면 오류가 발생하는데, double이 float보다 커서 안 들어가기 때문

        //[2]변수 사용
        Debug.Log(f);
        Debug.Log(d);
        Debug.Log(m);

        Debug.Log(min);
        Debug.Log(max);
        
    }
}

/*
실수형 데이터 형식 

Float   : 32비트 부동 소수점 숫자
Double  : 64비트 부동 소수점 숫자
Decimal : 128비트 부동 소수점 숫자

decimal은 아주 큰 숫자를 다루고 금융권에서 많이 씀, 개발에서는 웬만하면 볼 일 없음

*/