using UnityEngine;

//string == System.String
public class StringClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string s1 = "Hello";
        System.String s2 = "안녕하세요";

        Debug.Log($"{s1}, {s2}");

        //s1과 s2의 문자열 길이는?
        Debug.Log($"s1의 길이: {s1.Length}, s2의 길이: {s2.Length}");
    }
}
