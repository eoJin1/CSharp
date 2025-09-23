using UnityEngine;
namespace InterfaceDemoTest
{
    public class Car : ICar
    {
        public void Go()
        {
            Debug.Log("상속한 인터페이스에 정의된 모든 멤버를 반드시 구현해야 한다");
        }
    }
}