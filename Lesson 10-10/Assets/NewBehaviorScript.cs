using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviorScript : MonoBehaviour
{
    int x_count;
    int o_count;

    // Start is called before the first frame update
    public void CheckMatches(bool XorO)
    {
        if (XorO)
        {
            x_count++;
            if (x_count == 3)
            {
                Debug.Log("X WINNER");
            }
        }
        else
        {
            o_count++;
            if (o_count == 3)
            {
                Debug.Log("O WINNER");
            }
        }


    }


}
