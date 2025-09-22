using InheritanceDemoTest;
using UnityEngine;
namespace InheritanceProtectedTest
{

    public class InheritanceProtected : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] 부모 클래스 인스턴스 생성
            ParentClass parent = new ParentClass();
            //parent.PrintMessage();    //protected 접근제한(보호수준 때문에)
            Debug.Log(parent.ToString());

            //[2] 자식 클래스 인스턴스 생성
            ChildClass child = new ChildClass();
            //child.PrintMessage();     //protected 접근제한(보호수준 때문에)

        }

    }
}
/*
public 접근의 제한이 업다
private 해당 클래스 안에서만 접근
protected 해당 클래스 안에서만 접근, 상속받은 자식 클래스에서 접근 가능



*/