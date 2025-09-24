using UnityEngine;
namespace Generic
{
    public class GenericMethod : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Hello<T> 제네릭 클래스 인스턴스 생성
            Hello<int> hi = new Hello<int>();
            Debug.Log(hi.GetMessage());
            hi.Say(1234);
        }

    }
}