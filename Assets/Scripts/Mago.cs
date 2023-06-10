using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mago : Personagens
{
    private int magicReserve;
    public void setReservaMagica()
    {
        magicReserve = (willpower * 3);
    }
    public void setDamageMultiplier()
    {
        damageMultiplier = (magic * 0.1f);  
    }
}
