using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotator : MonoBehaviour
{
    public GameObject platform;
    public Vector3 targetRotation;
    private Vector3 currentTargetRotation;
    private Vector3 originalRotation;
    private bool isOn = false;

    // Start is called before the first frame update
    void Start()
    {
        this.originalRotation = new Vector3(
            this.platform.transform.localEulerAngles.x,
            this.platform.transform.localEulerAngles.y,
            this.platform.transform.localEulerAngles.z
        );
        this.SetToOriginal();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetVector = Vector3.Slerp(
            this.platform.transform.localEulerAngles,
            this.currentTargetRotation,
            0.5f
        );
        this.platform.transform.localEulerAngles = new Vector3(
            targetVector.x,
            targetVector.y,
            targetVector.z
        );
    }

    void SetToOriginal()
    {
        this.currentTargetRotation = new Vector3(
            this.originalRotation.x,
            this.originalRotation.y,
            this.originalRotation.z
        );
    }

    void SetToTarget()
    {
        this.currentTargetRotation = new Vector3(
            this.targetRotation.x,
            this.targetRotation.y,
            this.targetRotation.z
        );
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            this.isOn = !this.isOn;
            if (this.isOn)
            {
                this.SetToTarget();
            }
            else
            {
                this.SetToOriginal();
            }
        }
    }
}
