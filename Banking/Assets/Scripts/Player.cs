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
    private bool employed = false;
    private float money = 0;
    private float debt = 0;
    // current world time
    private int time = 8;

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

    public bool Employed
    {
        get
        {
            return employed;
        }
        set
        {
            employed = value;
        }
    }

    public float Money
    {
        get
        {
            return money;
        }
        set
        {
            money = value;
        }
    }

    public float Debt
    {
        get
        {
            return debt;
        }
        set
        {
            debt = value; 
        }
    }

    public int Time
    {
        get
        {
            return time;
        }
        set
        {
            time = value;
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
