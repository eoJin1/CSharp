using UnityEngine;

public class AndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //논리연산자(Logical Operator)

        //[1] AndOperator
        /*
        Debug.Log( true && true );      // 둘다 참일 경우 : 참
        Debug.Log( true &&  false );
        Debug.Log( false && true );     // 둘 중 하나라도 거짓인 경우 : 거짓
        Debug.Log( false && false );    // 둘 다 거짓인 경우 : 거짓
        */

        //[2] OrOperator
        /*
         * Debug.Log(true || true);      // 둘다 참일 경우 : 참
        Debug.Log(true || false);
        Debug.Log(false || true);     // 둘 중 하나라도 참인 경우 : 참
        Debug.Log(false || false);    // 둘 다 거짓인 경우 : 거짓
        */

        //[3] NotOperator
        Debug.Log(!true);      // 참을 부정 : 거짓
        Debug.Log(!false);      //거짓을 부정 : 참

    }

}

/* 
[1] AndOperator (And 연산자) : &&
(앞, 뒤) 둘다 참일때만 참
결과 : true, false

[2] OrOperator (Or 연산자) : ||
: (앞, 뒤) 둘 중에 하나라도 참이면 참
결과 : true, false

[3] NotOperator (부정 연산자) : !
: 참이면 (참을 부정하는)거짓이 되고, 거짓이면 (거짓을 부정하는)참이 됨

*/

