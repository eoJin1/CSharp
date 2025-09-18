using UnityEngine;

namespace Method
{
    //[2] 참조 전달 방법
    public class ParameterRef : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int number = 10;
            Debug.Log($"[1]: {number}");

            PrintNumber( ref number );

            Debug.Log($"[3]: {number}");
        }

        //정수형 변수 num을 ref 매개변수로 입력 받아 출력하는 메서드
        void PrintNumber(ref int number)
        {
            number = 20;
            Debug.Log($"[2]: {number}");
        }    
    }
}