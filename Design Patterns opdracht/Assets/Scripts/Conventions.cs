using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conventions : MonoBehaviour
{
    // There is no consensus on classes of classes or structs instead of etc.
    private struct ConventionsData
    {

    }

    // ORDER: Variables, Unity Functions, Functions
    // Pub/Prot/Private for each category

    public string thisIsAVariable = "camelCasing";

    // English!
    // Booleans always as true/false statement (is..., can...) 
    public bool isWalking;
    public bool canJump;

    private int someInt;    // WHAT DO YOU HERE THEN WITH?
    // PascalCase for Properties
    public int SomeInt 
    {
        get
        {
           return someInt;
        }
        protected set
        {
            someInt = value;
        }
    }
    
    private Text text;
    
    // Pascal Casing for functions, underscored for parameters
    public void ThisIsAFunction( Text _text)
    {
        string myText;
        text = _text;
        myText = _text.text;
    }

    // Always include private
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        // no specific ban / guideline for these, but this is recommended:
        if (isWalking)      return;
        else                isWalking = true;
        
    }
}