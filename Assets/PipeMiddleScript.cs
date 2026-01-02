using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic=GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        if (logic == null)
        {
            Debug.LogError("Logic script not found! Make sure you have a GameObject tagged 'Logic' with LogicScript attached.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger hit by: " + collision.gameObject.name + " on layer: " + LayerMask.LayerToName(collision.gameObject.layer));
        if (collision.gameObject.layer == LayerMask.NameToLayer("Bird"))
        {
            if (logic != null)
            {
                logic.addScore();
            }
        }
    }
}
