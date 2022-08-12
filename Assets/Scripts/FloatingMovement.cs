using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingMovement : MonoBehaviour
{
    private Spawner fspawner;
    public float upfloatspeed;


    // Start is called before the first frame update
    void Start()
    {
        fspawner = transform.parent.GetComponent<Spawner>();
        upfloatspeed = Random.Range(upfloatspeed * 0.9f, upfloatspeed * 1.1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.up * upfloatspeed + fspawner.Windforce) * Time.deltaTime;
    }
}
