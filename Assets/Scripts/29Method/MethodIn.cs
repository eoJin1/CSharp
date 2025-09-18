using System;
using Unity.VisualScripting;
using UnityEngine;
namespace Method
{
    //위치를 관리하는 구조체
    public struct Point
    {
        public int x;
        public int y;
    }
    public class MethodIn : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            /*
            //정수형 변수 num 선언하고 초기화
            int num = 10;
            Debug.Log($"[1]: {num}");
            PrintNumber(num);
            Debug.Log($"[3]: {num}");
            */

            //구조체 변수 선언하고 초기화
            Point point = new Point();
            point.x = 10;
            Debug.Log($"[1]: {point.x}");

           // PrintNumber(point);

            Debug.Log($"[3]: {point.x}");
        }

        private void PrintNumber(int num)
        {
            num = 20;
            Debug.Log($"[2]: {num}");
        }

    }
}

