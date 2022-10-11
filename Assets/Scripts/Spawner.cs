using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> FloatingObjects;
    public float fareaofspawnStart = 10;
    public Vector3 Windforce;
    public int iTotalObjectsinWave = 10;
    private float fcounter;
    public float fSpawnDelay = 2;
    public float fMinSpawnDelay = 1;
    
    


    // Update is called once per frame
    void Update()
    {
        
       
        if (transform.childCount < iTotalObjectsinWave && fcounter <= 0)
        {
            Vector3 startpos = new Vector3(Random.Range(-fareaofspawnStart, fareaofspawnStart), 0, Random.Range(-fareaofspawnStart, fareaofspawnStart)).normalized * fareaofspawnStart;
            GameObject objecttospawn = Instantiate(FloatingObjects[Random.Range(0, FloatingObjects.Count)], startpos + transform.position, transform.rotation, transform);
            fcounter += Random.Range(fMinSpawnDelay, fSpawnDelay);
        }
        

        fcounter -= Time.deltaTime;
        Windforce += Random.insideUnitSphere;
        Windforce /= 2.0f;
    }
}
