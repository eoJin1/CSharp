using UnityEngine;

public class integerDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {        
        int min = int.MinValue; //int가 저장할 수 있는 최솟값
        int max = int.MaxValue; //int가 저장할 수 있는 최댓값

        Debug.Log("int 최소값: " + min);
        Debug.Log("int 최대값: " + max);

    }


}

/*
정수형(Integer) 데이터 형식

SignedInteger ( +, -) 부호가 있는 정수형 데이터 형식
sbyte : 8 Bit - -128~127
short : 16 Bit - -32768~32767
int : 32 Bit - -21억 ~ 21억
long : 64 Bit

웬만한건 int, 실수형은 Float
기획상 큰 수는 long

1 Byte : 8비트

UnSignedInteger 부호가 없는 정수형 데이터 형식(-를 사용하지 않고 양의 정수만 저장)
byte : 8 Bit - 0~255
ushort : 16 Bit - 0~65535
uint : 32 Bit - 0~42억
ulong : 64 Bit  


그릇(변수)의 크기를 비트 단위로 나눠서 얼마나 담을 수 있는지 결정
 
 */