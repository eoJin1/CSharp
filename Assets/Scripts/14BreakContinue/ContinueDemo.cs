using UnityEngine;

public class ContinueDemo : MonoBehaviour
{
    public int n = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 n(100)까지의 정수의 합
        int sum = 0;

        //조건식
        for (int i = n; i <= n; i++)
        {
            //3의 배수이면 건너뛰기
            if (i % 3 == 0)
            {
                continue;
            }
            //누적식
            sum += i; //(sum = sum + i;)
        }
        //출력
        Debug.Log($"합은 {sum}");
    }
}

/*
[Q]
1부터 100까지의 정수의 합을 구하는데 3의 배수를 제외하고 합을 구하세요






*/
