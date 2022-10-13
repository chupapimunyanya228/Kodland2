using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapons : MonoBehaviour
{
    [SerializeField] GameObject pistol;
    [SerializeField] GameObject rifle;
    [SerializeField] GameObject shotgun;
    [SerializeField] GameObject firegun;  
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Changeweapon(int i)
    {
         pistol.SetActive(false);
       rifle.SetActive(false);
       shotgun.SetActive(false);
       firegun.SetActive(false);
       

    
        switch(i)
        {
            case 1:
            pistol.SetActive(true);
            break;
             case 2:
            rifle.SetActive(true);
            break;
             case 3:
            shotgun.SetActive(true);
            break;
             case 4:
            firegun.SetActive(true);
            break;
            default:
            print ("такого оружия нет");
            break;


        }


    }

    // Update is called once per frame
    void Update()
    {
     

       if (Input.GetKeyDown(KeyCode.Alpha1))
       {
       Changeweapon(1);
       }
         if (Input.GetKeyDown(KeyCode.Alpha2))
       {
        Changeweapon(2);
       }
         if (Input.GetKeyDown(KeyCode.Alpha3))
       {
        Changeweapon(3);
       }

    }
}
