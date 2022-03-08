using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    GameObject Character, projectile1, projectile2, projectile3, projectile4;

    [SerializeField]
    float speed, jumpspeed;

    [SerializeField]
    Text h, o;

    Rigidbody2D rb2d;

    bool inair, left, right;

    GameObject c, projectile;

    private GameObject[] getCount, getCount1;

    int count, count1, HP;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = Character.GetComponent<Rigidbody2D>();
        inair = false;
        projectile = projectile1;
        left = false;
        right = true;
        HP = 20;
        h.text = HP.ToString();
        o.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * (1 * speed);
            right = true;
            left = false;
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * (-1 * speed);
            right = false;
            left = true;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(inair == false){
            rb2d.AddForce((transform.up * jumpspeed), ForceMode2D.Impulse);
            inair = true;
            }else{

            }
        }

        if(Input.GetKey(KeyCode.Mouse0))
        {
            if(projectile == projectile3)
            {

            }else{
            getCount = GameObject.FindGameObjectsWithTag("Ammo");
            getCount1 = GameObject.FindGameObjectsWithTag("ShotgunAmmo");
            count = getCount.Length;
            count1 = getCount1.Length;
            if(count < 500 && count1 < 350){
            if(right == true && inair == false)
            {
            c = Instantiate(projectile, Character.transform.position+(transform.right*0.15f), Character.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            }else if(left == true && inair == false)
            {
                c = Instantiate(projectile, Character.transform.position+(-transform.right*0.15f), Character.transform.rotation);
                c.GetComponent<Rigidbody2D>().velocity = -transform.right * 5;
            }else if(inair == true && projectile == projectile4)
            {
                c = Instantiate(projectile, Character.transform.position+(-transform.up*0.42f), Character.transform.rotation);
                c.GetComponent<Rigidbody2D>().velocity = -transform.up * 5;
            }if(right == true && projectile != projectile4)
            {
            c = Instantiate(projectile, Character.transform.position+(transform.right*0.15f), Character.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            }else if(left == true && projectile != projectile4)
            {
                c = Instantiate(projectile, Character.transform.position+(-transform.right*0.15f), Character.transform.rotation);
                c.GetComponent<Rigidbody2D>().velocity = -transform.right * 5;
            }
            Destroy(c, 4f);
            }else
            {

            }
            }
        }

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            if(right == true)
            {
            Character.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            }else if(left == true)
            {
                Character.GetComponent<Rigidbody2D>().velocity = -transform.right * 5;
            }
        }

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(projectile == projectile3)
            {
                getCount = GameObject.FindGameObjectsWithTag("BombWeapon");
                count = getCount.Length;
                if(count < 3){
                    if(right == true && inair == false)
            {
                c = Instantiate(projectile, Character.transform.position+(transform.right*0.15f), Character.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            }else if(left == true && inair == false)
            {
                c = Instantiate(projectile, Character.transform.position+(-transform.right*0.3f), Character.transform.rotation);
                c.GetComponent<Rigidbody2D>().velocity = -transform.right * 5;
            }else if(inair == true)
            {
                c = Instantiate(projectile, Character.transform.position+(-transform.up*0.15f), Character.transform.rotation);
                c.GetComponent<Rigidbody2D>().velocity = -transform.up * 5;
            }
            Destroy(c, 7f);
            }else{

            }
            }else{ 
            }
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ShotgunAmmo")
        {

        }else{
            inair = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.gameObject.tag){
        case "Default Weapon":
        projectile = projectile1;
        break;
        case "Super Weapon":
        projectile = projectile2;
        break;
        case "Bomb":
        projectile = projectile3;
        break;
        case "Shotgun":
        projectile = projectile4;
        break;
        case "harm":
        HP -= 1;
        h.text = HP.ToString();
        if(HP >= 1){
        }else{
            o.gameObject.SetActive(true);
            h.text = "0";
        }
        break;
        }
    }
}
