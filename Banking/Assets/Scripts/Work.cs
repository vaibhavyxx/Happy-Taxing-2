using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Work : MonoBehaviour
{
    // Start is called before the first frame update
    const int HoursWorked = 8;
    float time;
    const float payPerHour = 15.20f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            float playerTime = Player.Instance.Time;
            time += Time.deltaTime;
            if (time >= HoursWorked && playerTime <= 10)
            {
                playerTime += HoursWorked;
                time = 0;
                DailySalary();
            }
        }
    }

    void DailySalary()
    {
        Player.Instance.Money = payPerHour * 40 * 4;
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
