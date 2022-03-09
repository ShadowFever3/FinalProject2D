using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    GameObject projectile1;
    [SerializeField]
    GameObject projectile2;
     [SerializeField]
    GameObject projectile3;

    public void Start()
    {
         
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag) {
            case "Weapon1":
                Satvar.projectile = projectile1;
                break;
            case "Weapon2":
                Satvar.projectile = projectile2;
                break;
            case "Weapon3":
                Satvar.projectile = projectile3;
                break;
            default:
          
                break;
        }
    }
}
