using UnityEngine;

namespace Field
{
    public class FieldPublicPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] Car 클래스의 인스턴스 생성
            Car myCar = new Car();

            //[2] Car 클래스에 있는 public 필드 접근해서 사용(읽기, 쓰기)
            myCar.name = "홍길동";
            Debug.Log(myCar.name);

            //[3] Car 클래스에 있는 private 필드에 접근해서 사용(못함)
            //myCar.age = 20;
            //myCar.address = "Seoul";  //'보호 수준' 때문에 접근 불가

            //[4] Car 클래스에 있는 public 메서드에 접근해서 사용
            myCar.Hi();

            //[5] Car 클래스에 있는 private 메서드에 접근해서 사용(못함)
            //myCar.Bye();    //'보호 수준' 때문에 접근 불가

            //[6] Car 클래스에 있는 private 필드 age에 접근해서 사용하고 싶다
            //myCar.age = 20; (보호수준 에러)
            //Debug.Log(myCar.age);

            myCar.SetAge(20);
            int myAge = myCar.GetAge();
            Debug.Log(myAge);

        }

    }
}
