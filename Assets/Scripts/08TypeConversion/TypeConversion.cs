using UnityEngine;

//형식 변환(TypeConversion)
public class TypeConversion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //d를 double형 변수로 선언하고 12.34를 저장
        double d = 12.34;   //64bit
        //i를 int형 변수로 선언하고 1234를 저장 
        int i = 1234;       //32bit

        //묵시적(암묵적, 암시적)형식 변환
        //double > int
        //d = (double)i;
        //하지만 double은 생략이 가능하기 때문에, 이렇게 제외하고 쓴다:
        d = i;
        Debug.Log($"암시적 형식변환: {d}");

        d = 12.34;
        i = 1234;

        //[2] 명시적 형식 변환: int < double
        //i = d; (이렇게 작은 그릇에 큰 그릇 넣기 - 당연히 안됨!)
        i = (int)d;
        Debug.Log($"명시적 형식변환: {i}");

        //[3] 수 이외의 형식간 변환
        string s = ""; //이렇게 큰따옴표 안에 글자가 없음 - 빈값(empty)으로 초기화.
        //s = d; 
        //s = (string)d; <안됨!
        //위의 암시적/명시적 형식 변환은 숫자 간에 가능, 다른 형식은 다른 방식으로 변환한다
        s = d.ToString();
        Debug.Log($"형식 변환: {s}");
    }
}
