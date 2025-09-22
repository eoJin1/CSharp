using UnityEngine;
namespace InheritanceDemoTest
{
    public class Child : Parent
    {
        public void Bar()
        {
            Debug.Log("자식 클래스의 멤버 호출");
        }
    }
}