using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inquisitor : Personagens
{
    private int stamina;
    public void setReservaMagica()
    {
        stamina = (willpower * 4);
    }
    public void setDamageMultiplier()
    {
        damageMultiplier = (magic * 0.1f);
    }
}
