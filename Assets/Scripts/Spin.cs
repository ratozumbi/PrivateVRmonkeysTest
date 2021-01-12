using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spinRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spinRoutine()
    {
        while (gameObject.activeInHierarchy)
        {
            //too easy ;)
            
            transform.rotation = transform.rotation * Quaternion.Euler(0, 10 * Time.deltaTime, 0);
            yield return null;
        }
    }
}
