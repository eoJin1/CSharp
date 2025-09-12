using UnityEngine;

//문자열 묶는 방법

public class StringDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string displayName = "";
        string firstname = "길동";
        string lastname = "홍";

        //output : "이름 : 홍 길동"
        //[1] 문자열 + (더하기) 연산자
        displayName = "이름: " + lastname + " " + firstname;
        Debug.Log(displayName);

        //[2] 문자열 보간법 사용
        displayName = $"이름: {lastname} {firstname}";
        Debug.Log(displayName);

        //[3] string.Format() 메서드 이용
        displayName = string.Format("이름: {0} {1}", lastname, firstname);
        Debug.Log(displayName);

    }
}
