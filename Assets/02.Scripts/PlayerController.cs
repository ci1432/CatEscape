using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        /*
        if(transform.position.x >= -8)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-moveSpeed, 0, 0);
            }
        }
        if(transform.position.x <= 8)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(moveSpeed, 0, 0);
            }
        }
        */
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-moveSpeed, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(moveSpeed, 0, 0);
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8f, 8f), transform.position.y, transform.position.z);
    }
}
