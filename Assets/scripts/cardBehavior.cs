using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardBehavior 
{
    //the cards will all have an action described, name, value, and suit;
    private string _name;
    private string _value;
    private string _suit;
    private string _action;
    private string _description;

    public string GetName()
    {
        return _name;
    }
    public string GetValue()
    {
        return _value;
    }
    public string GetSuit()
    {
        return _suit;
    }
    public string GetDescription()
    {
        return _description;
    }
    
    public void SetName(string name)
    {
        _name= name;
    }

    public void SetValue(string value)
    {
        _value= value;
    }
    public void SetSuit(string suit)
    {
        _suit = suit;
    }
    public void SetDescription(string description)
    {
        _description= description;
    }


    public abstract void Attack();
    

}

