using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    public Slider slider;

    private int maxStamina = 100;
  
    

    private WaitForSeconds regenTick = new WaitForSeconds(0.1f);
    private Coroutine regen;

    public static ManaBar manabar;
    private void Awake()
    {
       manabar = this;
    }
    void Start()
    {
        Satvar.mana = true;
        Satvar.currentmana = maxStamina;
        slider.maxValue = maxStamina;
        slider.value = maxStamina;
    }

  
    void Update()
    { 
        if (Satvar.manaamount == 1)
        {
            Satvar.mana = false;
                 
        }
       else if (Satvar.manaamount == 0)
        {
            Satvar.mana = true;

        }

    }

    public void UseStamina(int amount)
    {
        if ((Satvar.currentmana - amount) >= 0)
        {
            Satvar.manaamount = 0;
            Satvar.currentmana -= amount;
            slider.value=Satvar.currentmana;
            

            if (regen != null)


                StopCoroutine(regen);

            regen = StartCoroutine(RegenStamina());
            Satvar.manaamount = 0;
        }
        else 
        {
            Satvar.manaamount = 1;

        }



    }
    

    private IEnumerator RegenStamina()
    {
        yield return new WaitForSeconds(2);
        
        while(Satvar.currentmana < maxStamina)
        {
            Satvar.currentmana += maxStamina / 100;
            slider.value = Satvar.currentmana;
            yield return regenTick;
        }
        regen = null;
    }
}
