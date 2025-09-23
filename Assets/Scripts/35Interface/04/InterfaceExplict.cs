using UnityEngine;
namespace InterfaceNoteTest
{
    public class InterfaceExplict : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Pet 클래스 인스턴스 생성
            Pet pet = new Pet();
            ((IDog)pet).Eat();  //pet개체를 IDog형식으로 형식 변환
            ((ICat)pet).Eat();  //pet개체를 ICat형식으로 형식 변환

            //다형성
            IDog dog = new Pet();
            dog.Eat();

            ICat cat = new Pet();
            cat.Eat();
        }

    }
}
