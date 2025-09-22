using UnityEngine;
namespace AbstractNoteTest
{
    //shape(추상 클래스)를 상속받는 사각형을 관리하는 자식 클래스
    //shape 지정하는 추상메서드(GetArea())를 구현해야한다
    public class Square : Shape
    {
        //필드
        private int size;   //가로 세로 길이

        //생성자 - 매개변수를 입력받아 필드 초기화
        public Square(int _size)
        {
            this.size = _size;
        }

        //추상메서드 구현
        public override double GetArea()
        {
            return size * size;
        }
    }
}