using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoLanding : MonoBehaviour
{
    private TimeManipulator manipulator = new TimeManipulator(1.0f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Domino")
        {
            this.manipulator.Trigger();
        }
    }
}
