using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Imprime : MonoBehaviour
{
    [SerializeField] private Personagens atributos;
    [SerializeField] private TextMeshProUGUI texto;
    private void Update()
    {
        texto.text = atributos.life.ToString();
    }
}
