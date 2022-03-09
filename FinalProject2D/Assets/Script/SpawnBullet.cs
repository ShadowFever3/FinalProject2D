using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    [SerializeField]
    GameObject projectile2;
    void Start()
    {
        
    }

 
    void Update()
    {

        if (Satvar.projectile != projectile2)
        {
            if (Satvar.right == true) {
                if (Input.GetMouseButtonDown(0))
                {
            GameObject spawn = Instantiate(Satvar.projectile, transform.position + new Vector3(0.6f, 0), transform.rotation);
            spawn.GetComponent<Rigidbody2D>().velocity = transform.right * 10;
            Destroy(spawn, 3f);
        }
        }
        
       
          if (Satvar.left == true) {
                if (Input.GetMouseButtonDown(0))
                {
            GameObject spawn = Instantiate(Satvar.projectile, transform.position + new Vector3(-0.6f, 0), transform.rotation);
            spawn.GetComponent<Rigidbody2D>().velocity = -transform.right * 10;
            Destroy(spawn, 3f);
        }
            
        }
          
            if (Satvar.down==true)
            {
                if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.S))
                {
                    GameObject spawn = Instantiate(Satvar.projectile, transform.position + new Vector3(0, -0.6f), transform.rotation);
                    spawn.GetComponent<Rigidbody2D>().velocity = -transform.up * 10;
                    Destroy(spawn, 3f);
                }

            }


    }



        if (Satvar.projectile == projectile2){
            if (Satvar.right == true)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    GameObject spawn = Instantiate(Satvar.projectile, transform.position + new Vector3(0.6f, 0), transform.rotation);
                    spawn.GetComponent<Rigidbody2D>().velocity = transform.right * 10;
                    Destroy(spawn, 3f);
                }
            }

            if (Satvar.left == true)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    GameObject spawn = Instantiate(Satvar.projectile, transform.position + new Vector3(-0.6f, 0), transform.rotation);
                    spawn.GetComponent<Rigidbody2D>().velocity = -transform.right * 10;
                    Destroy(spawn, 3f);
                }

            }
            
            if (Satvar.down == true)
            {
                if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.S))
                {
                    GameObject spawn = Instantiate(Satvar.projectile, transform.position + new Vector3(0f, -0.6f), transform.rotation);
                    spawn.GetComponent<Rigidbody2D>().velocity = -transform.up * 10;
                    Destroy(spawn, 3f);
                }


            }
            
        }
    }
}



