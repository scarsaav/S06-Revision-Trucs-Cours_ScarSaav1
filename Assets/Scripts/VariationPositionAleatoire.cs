using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariationPositionAleatoire : MonoBehaviour
{
    [SerializeField] private float _distanceMaximale;

    void Start()
    {
        // Declarer et initialiser une variable locale
        Vector3 nouvellePosition = Vector3.zero;

        // Calculer une position aleatoire a partir d'un Vector2
        // à une distance maximale
        Vector2 variation = Random.insideUnitCircle * _distanceMaximale; //UnitCircle=rayon 1 (x,y)........random.value donne valeur entre 0 et 1
        
        // Convertir les valeurs du Vector2 (x,y) au Vector3 (x,z) pcq je veux changer le deplacement de l'arbre sur le plane et pas en hauteur 
        nouvellePosition.x = variation.x;
        nouvellePosition.z = variation.y;
        
        // Appliquer la nouvelle position
        transform.position += nouvellePosition;
    }
}
