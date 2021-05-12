using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearcCan : MonoBehaviour
{
    private Police chase;
    // Start is called before the first frame update
    void Start()
    {
        chase = GetComponentInParent<Police>();
    }

    // Update is called once per frame


    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "Cola Can")
        {
            chase.SearchFlag = true;
        }
    }
}
