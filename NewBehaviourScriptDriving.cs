using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private GameObject Car;
    // Start is called before the first frame update
    void Start()
    {
        Car = GetComponent<Vehicle>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * 10 * Time.deltaTime, Space.World);
    }
}
