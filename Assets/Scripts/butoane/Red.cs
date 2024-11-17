using UnityEngine;

public class Red : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private SpriteRenderer SpriteRenderer;
    public Sprite defaultImage;
    public Sprite pressedImage;
    public KeyCode KeyToPress1; 
    public KeyCode KeyToPress2; 
    public KeyCode KeyToPress3; 
    public KeyCode KeyToPress4;
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyToPress1)||Input.GetKeyDown(KeyToPress2))
        {
            SpriteRenderer.sprite = pressedImage;
        }
        if(Input.GetKeyUp(KeyToPress1)||Input.GetKeyDown(KeyToPress2)){
            SpriteRenderer.sprite = defaultImage;
        }
    }
}
