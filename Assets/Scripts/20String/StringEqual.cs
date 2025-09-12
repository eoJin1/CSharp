using UnityEngine;

//문자열 비교 : 2가지
public class StringEqual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //문자열 변수 선언 및 초기화
        string username = "RedPlus";
        string inputname = "redPlus";

        //[1] 연산자 (==) 을 사용
        if(username == inputname)
        {
            Debug.Log("[1]번 같습니다");
        }

        //[2]string.equal() 메서드 사용
        if (string.Equals(username, inputname, System.StringComparison.InvariantCultureIgnoreCase))
        {
            Debug.Log("[2]번 같습니다");
        }
    }
}
