using UnityEngine;
namespace InheritanceProtectedTest
{
    public class ParentClass
    {
        //부모 클래스 코드 블록 안에서는 private과 같은 기능을 한다
        //protected 상속받은 자식클래스(코드 블록 안)에서만 접근 가능

        protected void PrintMessage()
        {
            Debug.Log("부모클래스에서 (protected)정의한 내용");
        }


    }
}