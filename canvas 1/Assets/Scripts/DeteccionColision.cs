using UnityEngine;

public class DeteccionColision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        
        
        Debug.Log("Colisión con: " + col.gameObject.name);

        if (col.gameObject.CompareTag("Pared"))
        {
           
            GetComponent<SpriteRenderer>().color = Color.red;
        }

        if (col.gameObject.CompareTag("Piso"))
        {
           
            GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
