using UnityEngine;
namespace Indexer
{
    public class IndexerDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Car 클래스의 인스턴스 생성
            Car car = new Car(3);
            car[0] = "제네시스";
            car[1] = "그랜저";
            car[2] = "아반떼";

            //인덱서 출력
            /*
            for (int i = 0; i < 3; i++)
            {
                Debug.Log(car[i]);
            }
            */

            /*
            foreach (var c in car)
            {

            }
            */

        }

    }
}
