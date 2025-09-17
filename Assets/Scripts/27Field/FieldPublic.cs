using UnityEngine;

namespace Field
{
    public class FieldPublic : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //category의 객체(인스턴스) 생성
            Category book = new Category();

            //필드에 값 저장(쓰기)
            book.cartegoryName = "책";

            //필드 사용(읽기)
            Debug.Log(book.cartegoryName);
        }
    }
}
