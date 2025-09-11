using UnityEngine;

//[1]구조체 정의, 선언
//고객 데이터를 관리하는 구조체
struct UserCard
{
    public string Name;
    public int age;
    public string address;
}
public class StructureNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]구조체(UserCard) 형식의 변수 선언
        UserCard myCard;

        //[3]구조체에 속해 있는 데이터들의 초기화
        myCard.Name = "홍길동";
        myCard.age = 20;
        myCard.address = "서울시 강동구";

        //[4]구조체 사용
        Debug.Log($"이름: {myCard.Name}, 나이: {myCard.age}, 주소: {myCard.address}");

    }

}
