using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text puntos;
    private int monedas;
    // Start is called before the first frame update
    void Start()
    {
        monedas = 0;
    }
    private void OnTriggerEnter2D(Collider2D other){
         if(other.gameObject.tag == "moneda"){
            monedas++;
            puntos.text = "Score: " + monedas;
        }
    }


}
