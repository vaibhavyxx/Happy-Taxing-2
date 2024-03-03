using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;

    private void Awake()
    { 
        // if instance exists thats not me, delete myself
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else // if no other instances
        {
            instance = this;
        }
    }

    // fields

    private bool creditCard = false;
    private bool debitCard = false;

    // properties
    public bool CreditCard
    {
        get
        {
            return creditCard;
        }
        set
        {
            creditCard = value;
        }
    }

    public bool DebitCard
    {
        get
        {
            return debitCard;
        }
        set
        {
            debitCard = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
