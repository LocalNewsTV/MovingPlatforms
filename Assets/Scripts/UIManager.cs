using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TimeField;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void UpdateTimerUI(int time)
    {
        if (time >= 0){
            TimeField.text = "Time Remaining: " + time;
        } else if (time < 0)
        {
            TimeField.text = "Time Remaining: 0  |  Game Over";
        }      
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
