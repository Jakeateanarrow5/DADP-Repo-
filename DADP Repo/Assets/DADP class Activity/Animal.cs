using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private int numArms;
    private int numLegs;
    private string species;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Animal() 
    {
        Debug.Log("Animal Created");

    }

    // Update is called once per frame
    public Animal (string animalSpecies,int legs, int arms)
    {
       species  = animalSpecies;
        numArms -= arms;
        numLegs -= legs;
        
    }
}
