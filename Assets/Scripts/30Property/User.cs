using UnityEngine;
namespace Property
{
    //고객 데이터를 관리하는 클래스
    public class User
    {
        //필드
        private int birthYear;  //생년

        //자동 속성
        public string name { get; set; } //이름

        //쓰기 전용 속성
        public int BirthYear
        {
            set 
            {
                if (value >= 1900)
                {
                    birthYear = value;
                }
                else
                {
                    birthYear = 0;
                }
            }
        }

        //읽기 전용 속성
        public int Age
        {
            get
            {
                return (System.DateTime.Now.Year - birthYear);
            }
        }

        //생성자 - 매개변수
        public User(string name)
        {
            this.name = name;
        }

    }
}