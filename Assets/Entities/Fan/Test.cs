using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject fan = GameObject.Find("Fan");
        Fan script = fan.GetComponent<Fan>();
        script.PowerOn();
        StartCoroutine(DoSomethingAfterDelay(2.0f));
    }

    IEnumerator DoSomethingAfterDelay(float delay)
    {
        // Wait for the specified delay
        Debug.Log("Waiting for " + delay + " seconds");
        yield return new WaitForSeconds(delay);

        // Do something after the delay
        Debug.Log("Doing something after " + delay + " seconds");

        GameObject fan = GameObject.Find("Fan");
        Fan script = fan.GetComponent<Fan>();
        script.PowerOff();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
