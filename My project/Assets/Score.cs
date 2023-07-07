using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Score : MonoBehaviour
{

    [SerializeField] TMP_Text timeText;
      private float timeSofar = 0;
   

    void Start()
{
    InvokeRepeating("UpdateTimer", 0, 1);
}

void UpdateTimer()
{
    timeSofar++;
    timeText.text = timeSofar.ToString("0");
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
