using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Work : MonoBehaviour
{
    // Start is called before the first frame update
    const float HoursWorked = 8f;
    float time;
    const float payPerHour = 15.20f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            float playerTime = Player.Instance.Time;
            time += 0.5f;
            Debug.Log(time);
            if (time >= HoursWorked && playerTime <= 10)
            {
                //playerTime += HoursWorked;
                time = 0;
                Player.Instance.Time += (uint)HoursWorked;
                DailySalary();
            }
        }
    }

    void DailySalary()
    {
        Player.Instance.Money = payPerHour * 8;
    }

    void Taxed()
    {
        float playerMoney = Player.Instance.Money;
        float taxes = 0;
        if(playerMoney < 11000 )
        {
            taxes = playerMoney * 0.1f;
        }
        else if(playerMoney < 44725)
        {
            taxes = playerMoney * 0.12f;
        }
        else if(playerMoney < 95375)
        {
            taxes = playerMoney * 0.22f;
        }
        else
        {
            taxes = playerMoney * 0.24f;
        }
        Player.Instance.Money -= taxes;
        Player.Instance.Tax = taxes;
    }
}
