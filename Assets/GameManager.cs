using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] UIManager ui;
    [SerializeField]
    public int timeAlotted = 15;
    private bool pauseTimer = false;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start(){
        StartCoroutine(Tick());
        ui.UpdateTimerUI(timeAlotted);
    }
    private IEnumerator Tick(){
            timeAlotted -= 1;
            ui.UpdateTimerUI(timeAlotted);
            yield return null;
    }
    void Update(){
        timer += Time.deltaTime;
        if (timer > 1 && timeAlotted >= 0)
        { 
            timer -= 1;
            if (!pauseTimer){
                StartCoroutine(Tick());
            }
        }
        if (Input.GetKeyDown("space")) {
            pauseTimer = pauseTimer ? false : true;
            Debug.Log("Help me");
             if (pauseTimer){
                StopCoroutine(Tick());
            } else {
                StartCoroutine(Tick());
            }   
        }
    }
}
