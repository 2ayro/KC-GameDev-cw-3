using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3 : MonoBehaviour
{
   
   // hero info
   string HeroName = "Bastion";
   int HeroPower = 12;
   

   // villian info
   string VillianName = "bouble";
   int VillianPower = 200;
   
   float PlayerSpeed = 0;

   
    // Start is called before the first frame update
    void Start()
    {
        if (VillianPower > HeroPower)
        {
            print("Villian is stronger, is he?");
        }
        else if (HeroPower > VillianPower)
        {
            print("Hero is stronger");
        }
        else 
        {
            print("They are equal, are they?");
        }
        
        SetSpeed(2.5f);
        CompareSpeed(0,2.5f);



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetSpeed(float Speed)
    {
        print(PlayerSpeed);
        PlayerSpeed = Speed;
        print(PlayerSpeed);
    }
    void CompareSpeed(float speed,float SetSpeed)
    {
        if (PlayerSpeed > SetSpeed)
        {
            print(PlayerSpeed);
        }
        else if (SetSpeed > PlayerSpeed)
        {
            print(SetSpeed);
        }
        else
        {
            print(PlayerSpeed);
            print(SetSpeed);
        }


    }
}