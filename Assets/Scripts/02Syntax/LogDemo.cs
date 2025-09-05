using UnityEngine;

public class LogDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("들여쓰기는 공백 4칸 또는 탭을 사용한다");
        Debug.Log("C# 문법");

        Debug.Log(("결과는: " + 5));

        Debug.Log("결과는: " + (5 + 10));

        Debug.Log("결과는: " + 5 + 10);

        UnityEngine. Debug.Log("C# 문법");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
