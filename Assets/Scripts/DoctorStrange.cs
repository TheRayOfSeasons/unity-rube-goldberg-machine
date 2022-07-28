using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorStrange : MonoBehaviour
{
    private TimeManipulator manipulator = new TimeManipulator(0.5f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Domino")
        {
            this.manipulator.Trigger();
        }
    }
}
