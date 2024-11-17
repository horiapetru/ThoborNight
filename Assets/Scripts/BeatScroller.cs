using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public float BeatTempo;

    public bool HasStarted;
    public KeyCode KeyCode;
    void Start()
    {
        BeatTempo = BeatTempo /60f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!HasStarted)
        {
          /*  if(Input.GetKeyDown(KeyCode))
            {
                HasStarted = true;
            }*/
        }else
        {
            transform.position -= new Vector3(0f, BeatTempo * Time.deltaTime, 0f);
        }
    }
}
