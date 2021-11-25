using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject sphere;

    private Vector3 launchVector = new Vector3(0, 0, 500f);
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameObject obj = ObjectPooler.instance.GetPooledObject();

            if(obj == null) { return; }

            obj.transform.position = transform.position + new Vector3(0, 1f, 1f);
            obj.transform.rotation = transform.rotation;
            obj.SetActive(true);
            obj.GetComponent<Rigidbody>().AddForce(launchVector);
        }
    }
}
