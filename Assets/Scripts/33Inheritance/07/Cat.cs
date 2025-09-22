using UnityEngine;
namespace InheritanceSealedTest
{
        //자식 클래스 선언
        //Sealed(봉인) 클래스 지정
        public class Cat : Animal
        {

        }

        //자식의 자식 클래스 선언
        //Cat 클래스를 부모로 지정해서 Cat 클래스에 있는 기능을 모두 가져와서 사용
        public class MyCat : Cat
        {

        }

}