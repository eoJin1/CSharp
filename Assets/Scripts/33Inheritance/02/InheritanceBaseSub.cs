using UnityEngine;
using InheritanceBase;
namespace Inheritance
{
    public class InheritanceBaseSub : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Sub클래스의 인스턴스 생성
            SubClass sub = new SubClass();

            //Base클래스에 (public, protected)정의된 메서드 사용가능
            sub.Do();

            //Base클래스에 (private)정의된 메서드 사용불가
            //sub.Run();

        }

    }
}