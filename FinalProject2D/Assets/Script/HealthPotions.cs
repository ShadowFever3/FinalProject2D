using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotions : MonoBehaviour
{
    [SerializeField]
    GameObject Potion;
    [SerializeField]
    HealthBar healthbar = new HealthBar();
    PlayerHealth playerHealth = new PlayerHealth();
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player") {
            healthbar.SetHealth(playerHealth.currenthealth += 50);
            Destroy(Potion);
        }
    }
}
