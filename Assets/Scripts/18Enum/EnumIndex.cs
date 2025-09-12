using UnityEngine;

//[1]enum 정의, 선언
//enum의 값을 정수형, 문자열로 사용이 가능
//동물들을 구분하는 열거형
enum Animals
{
    Rabbit,
    Dragon,
    Snake
}

enum Animale
{
    Horse,      //0
    Sheep = 5, //세팅할때 값을 정할 수 있다. 원래 1이겠지만 5로 세팅.
    Monkey      //위가 5가 됐으니 6.

}
public class EnumIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //enum 사용 - enum 변수 선언하고 초기화
        Animals animal = Animals.Dragon;
        int num = (int)animal;
        string str = animal.ToString();

        Debug.Log($"Animals.Dragon: {num}, {str}");
        Debug.Log((int)Animale.Monkey);
    }

}
