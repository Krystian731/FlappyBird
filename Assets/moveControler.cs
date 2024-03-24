using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class moveControler : MonoBehaviour
{
    public float speed = -2;
    public float XSpawnPosition;
    public float XDespawnPosition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);

        if (transform.position.x < XDespawnPosition)
        {
            transform.position = new Vector3(XSpawnPosition, transform.position.y, transform.position.z);      }
         }

   
}
