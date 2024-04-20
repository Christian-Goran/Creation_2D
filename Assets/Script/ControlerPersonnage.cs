using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlerPersonnage : MonoBehaviour
{  
    
    public float vitesseX;      //vitesse horizontale actuelle
    public float vitesseXMax;   //vitesse horizontale Maximale désirée
    public float vitesseY;      //vitesse verticale 
    public float vitesseSaut;   //vitesse de saut désirée
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // déplacement vers la gauche
        if (Input.GetKey("a"))
        {
            vitesseX = -vitesseXMax;

        }
        else if (Input.GetKey("d"))   //déplacement vers la droite
        {
            vitesseX = vitesseXMax;
        }
        else
        {
            vitesseX = GetComponent<Rigidbody2D>().velocity.x;  //mémorise vitesse actuelle en X
        }

        // sauter l'objet à l'aide la touche "w"
        if (Input.GetKeyDown("w"))
        {
            vitesseY = vitesseSaut;
        }
        else
        {
            vitesseY = GetComponent<Rigidbody2D>().velocity.y;  //vitesse actuelle verticale
        }
   
        GetComponent<Rigidbody2D>().velocity = new Vector2(vitesseX, vitesseY);

    
    }
}
    
