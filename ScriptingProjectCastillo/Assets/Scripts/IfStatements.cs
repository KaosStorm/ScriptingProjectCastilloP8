using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float cofffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTempurature = 40.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        cofffeeTemperature -= Time.deltaTime * 5f;
    }


void TemperatureTest ()
    {
        //If the coffee's temperature is greater than the hottest dricking temperature...
        if (cofffeeTemperature > hotLimitTemperature)
        {
            // ... do this
            print("Coffee is too hot");
        }
        // If it isn't, but the coffee tempurature is less than the coldest dricking temperature...
        else if(cofffeeTemperature < coldLimitTempurature)
        {
            //... do this.
            print("Coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("Coffee is just right.");
        }
    }
}