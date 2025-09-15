using UnityEngine;

public class ExceptionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string inputnumber = "3.14";
        int number = 0;

        try
        {
            number = System.Convert.ToInt32(inputnumber);
            Debug.Log($"입력한 값은: {number}");
        }
        catch (System. Exception ex)
        {
            Debug.Log(ex.Message);
        }
        /*catch (System. FormatException fe)
        {
            
            Debug.Log(fe.Message);
            Debug.Log($"{inputnumber}는 정수여야 합니다");
        } 
        */
    }

}
