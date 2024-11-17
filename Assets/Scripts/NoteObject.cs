using System.Net.Sockets;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
   public bool canBePressed;

   public KeyCode keyToPress;

   public GameObject hitEffect, goodEffect, perfectEffect, missEffect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!PauseMenu.isPaused)
        {
        if(Input.GetKeyDown(keyToPress))
        {
            if(canBePressed)
            {
                gameObject.SetActive(false);

                //GameManager.instance.noteHit();
                if(Mathf.Abs(transform.position.y) > 0.25)
                {
                    Debug.Log("normal hit");
                    GameManager.instance.normalHit();
                    Instantiate(hitEffect, hitEffect.transform.position, hitEffect.transform.rotation);
                } else if(Mathf.Abs(transform.position.y) > 0.05f)
                {
                    Debug.Log("good hit");
                    GameManager.instance.goodHit();
                    Instantiate(goodEffect, goodEffect.transform.position, goodEffect.transform.rotation);
                } else {
                    Debug.Log("perfect hit");
                    GameManager.instance.perfectHit();
                    Instantiate(perfectEffect, perfectEffect.transform.position, perfectEffect.transform.rotation);
                }
                

            }
        }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        } 
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Activator"&& gameObject.activeSelf)
        {
            canBePressed = false;

            GameManager.instance.noteMissed();
            Instantiate(missEffect, missEffect.transform.position, missEffect.transform.rotation);
        } 
    }
}
