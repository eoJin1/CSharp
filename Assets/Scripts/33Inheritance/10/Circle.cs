using UnityEngine;
namespace AbstractNoteTest
{
    //shape(추상 클래스)를 상속받는 원을 관리하는 자식 클래스
    //shape 지정하는 추상메서드(GetArea())를 구현해야한다
    public class Circle : Shape
    {
        //필드
        private int size;   //반지름

        //생성자 - 매개변수를 입력받아 필드(size) 초기화

        public Circle(int _size)
        {
            this.size = _size;
        }

        //추상 메서드 구현
        public override double GetArea()
        {
            //원의 면적(반지름*반지름*3.14)
            return size * size * 3.14;
        }

    }
}