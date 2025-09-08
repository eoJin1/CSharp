using UnityEngine;

public class LogicalPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;
        int j = 5;
        bool r = false;

        r = (i == 3) && (j != 3);           //true && true
        Debug.Log($"r: {r}");               //참 

        r = (i != 3) || ( j == 3);          //false || false
        Debug.Log($"r: {r}");               //거짓

        r = (i >= 5);                       //false
        Debug.Log($"!r: {!r}");             //참

        Debug.Log((1 == 1) || (1 != 1));    //true || false => true
                                            //참

        Debug.Log(!(1 == 1));               //!true
                                            //거짓
    }

}
