using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementObjets : MonoBehaviour
{
    public float vitesse;
    public float positionFin;
    public float positionDebut;
    public float deplacementAleatoire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float valeurAléatoireY = Random.Range(-deplacementAleatoire, deplacementAleatoire);

        if (transform.position.x < positionFin){
            transform.position =  new Vector2(positionDebut, valeurAléatoireY);
        }
        transform.Translate(vitesse,0,0);
    }
    
}
