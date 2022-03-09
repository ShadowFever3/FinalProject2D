using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public int currenthealth;
    [SerializeField]
    HealthBar healthbar = new HealthBar();
    void Start()
    {
        Satvar.hit = false;
        currenthealth = health;
        healthbar.SetMaxHealth(health);
    }

    // Update is called once per frame
    void Update()
    {
        if (Satvar.enemieDamage == 1)
        {
            if (Satvar.hit == true) {
                Satvar.enemieDamage = 0;
                TakeDamage(Satvar.damage);
            }
        }

        if (Satvar.enemieDamage == 0) {
            Satvar.hit = false;
        }

        if (currenthealth == 0) {
            SceneManager.LoadScene("GameOver");
        }

        /*
           if (Input.GetKeyDown(KeyCode.Alpha2)) {
               TakeDamage(damage);
           }
        */
    }

    public void TakeDamage(int damage) {
        if (currenthealth != 0){
        currenthealth -= damage;
        healthbar.SetHealth(currenthealth);
    }

}
}
