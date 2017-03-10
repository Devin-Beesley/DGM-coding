using UnityEngine;
using System.Collections;

public class Operators : MonoBehaviour {
    public int valOne = 5;
    public int valTwo = 2;
    public int valThree = 10;

    void Start () {

    }
    void Update () {

        //Addition to add selected values
        
        Debug.Log (valOne + valTwo);
        
        //Minus function subtraction to subtract by selected values
        
        Debug.Log (valOne - valTwo);

        //multiply multiplying first value by second val as specified

        Debug.Log (valOne * valTwo);

        //Divide divide first value by second value in an argument

        Debug.Log( valOne / valTwo);

        //Modulus % returns decimal value of uneven division

        Debug.Log (valOne % valTwo);

        //++ is used for increment so pluse one or plus specified value to declared value

        Debug.Log ( valThree ++);

        //Decrement is used to subtract by one from delared int or to decrease by val of declaration placed after --

        Debug.Log ( valThree --);
    }
}