using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public float rotSpeed = 10f;
    float newRotY = 0;


    /*// Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        float newX = transform.position.x;
        float newY = transform.position.y;
        float newZ = transform.position.z;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            newZ = transform.position.z + speed * Time.deltaTime;
            newRotY = 0;
          // transform.rotation = Quaternion.Euler(0,0,0);
        }
       
        if (Input.GetKey(KeyCode.DownArrow))
        {
            newZ = transform.position.z - speed * Time.deltaTime;
            newRotY = 180;
            //transform.rotation = Quaternion.Euler(0,180,0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            newX = transform.position.x - speed * Time.deltaTime;
            newRotY = -90;
            // transform.rotation = Quaternion.Euler(0,-90,0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            newX = transform.position.x + speed * Time.deltaTime;
            newRotY = 90;
            //transform.rotation = Quaternion.Euler(0,90,0);
        }

        transform.position = new Vector3(newX, newY, newZ);
       // transform.rotation = Quaternion.Euler(0, newRotY, 0);
        transform.rotation = Quaternion.Lerp( Quaternion.Euler(0, newRotY, 0), transform.rotation,rotSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name); 
       // if(collision.gameObject.name == "Sphere")
    }
}
