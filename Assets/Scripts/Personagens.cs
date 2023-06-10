using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Personagens:MonoBehaviour
{
    //atributos mudados na gameplay
    [SerializeField] protected int constitucion;
    [SerializeField] protected int strenght;
    [SerializeField] protected int cunning;
    [SerializeField] protected int willpower;
    [SerializeField] protected int magic;
    [SerializeField] protected int dexterity;
    //atributos de combate
    [HideInInspector]public int life;
    protected float dodgeChance;
    protected float stunChance;
    protected float pickpokectChance;
    protected float potionEfficiency;
    protected float damageMultiplier;
    private void Start()
    {
        life = constitucion * 5;
        dodgeChance = (dexterity * 0.01f);
        stunChance = 1.0f - (strenght * 0.01f);
        pickpokectChance = (cunning * 0.01f);
        potionEfficiency = (magic * 1.05f);
    }
}
