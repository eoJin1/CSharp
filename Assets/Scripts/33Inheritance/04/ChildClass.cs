using UnityEngine;
namespace InheritanceProtectedTest
{
    public class ChildClass : ParentClass   // :(콜론) 기호로 부모클래스 지정
    {
        //protected 상속 받은 자식 클래스(코드 블록 안)에서만 접근 가능
        protected void PrintMessage2()
        {
            //자식 클래스 코드 블록 안에서 부모의 멤버에 접근 방법 : base 키워드 사용
            base.PrintMessage();
        }
    }
}
