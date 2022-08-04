using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    public GameObject platform;

    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("Test", 0.0f, 2.3f);
        // StartCoroutine(DoSomething());
    }

    IEnumerator DoSomething()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
            yield return new WaitForSeconds(2.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Test()
    {
        Debug.Log("This is a delayed test.");
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            platform.SetActive(false);
        }
    }
}
