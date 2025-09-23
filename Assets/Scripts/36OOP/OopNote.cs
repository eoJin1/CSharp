using UnityEngine;
namespace Oop
{
    //[1]추상클래스
    public abstract class Animal
    {
        //추상메서드
        public abstract string Cry();
    }

    //[2]Dog 클래스
    public class Dog : Animal
    {
        public override string Cry() => "멍멍멍";
    }
    //[3]Cat 클래스
    public class Cat : Animal
    {
        public override string Cry() => "야옹";
    }
    //[4]트레이너 클래스
    public class Trainer
    {
        //매개변수로 입력받은 동물을 울게 시킨다
        public void DoCry(Animal animal)
        {
            //animal, Dog, Cat
            Debug.Log(animal.Cry());
        }
    }


    public class OopNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1]기본 클래스 인스턴스 생성
            Dog dog = new Dog();
            Debug.Log(dog.Cry());

            Cat cat = new Cat();
            Debug.Log(cat.Cry());

            //[2]부모 클래스의 이름으로 자식클래스의 인스턴스 생성 - 업캐스팅
            Animal myDog = new Dog();
            Debug.Log(myDog.Cry());

            Animal mycat = new Cat();
            Debug.Log(mycat.Cry());

            //[3]다형성
            //animal.Cry() 메서드를 호출한다
            //입력받은 매개변수에 따라서 서로 다른 유형의 기능이 실행된다
            Trainer trainer = new Trainer();
            trainer.DoCry(dog);
        }
    }
}
/*
다형성
: 객체(개체)를 여러가지 형식으로 읽을 수 있다
: 객체(개체)를 여러가지 형태로 가지고 있다

업캐스팅 : 자식클래스의 인스턴스를 부모클래스 형식으로 읽는것
다운캐스팅 : 부모클래스의 인스턴스를 자식클래스 형식으로 읽는것





*/