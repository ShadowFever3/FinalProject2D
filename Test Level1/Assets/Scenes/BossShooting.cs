using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossShooting : MonoBehaviour
{
    [SerializeField]
    GameObject Boss;

    GameObject c;

    int BossHP;

[SerializeField]
    Text t;
    // Start is called before the first frame update
    void Start()
    {
        BossHP = 7000;
        t.text = BossHP.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch(collision.gameObject.tag){
            case "Ammo":
            BossHP -= 1;
        t.text = BossHP.ToString();
        if(BossHP >= 1){
        }else{
            Destroy(Boss);
        }
            break;
            case "BombWeapon":
            BossHP -= 100;
        t.text = BossHP.ToString();
        if(BossHP >= 100){
        }else{
            Destroy(Boss);
        }
            break;
            case "ShotgunAmmo":
            BossHP -= 5;
        t.text = BossHP.ToString();
        if(BossHP >= 5){
        }else{
            Destroy(Boss);
        }
        break;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "harm")
        {

        }else{
        BossHP -= 1;
        t.text = BossHP.ToString();
        if(BossHP >= 1){
        }else{
            Destroy(Boss);
        }
        }
    }

    }
