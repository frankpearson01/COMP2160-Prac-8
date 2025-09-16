using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 5f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move(){
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 moveDirection  = transform.right * moveX + transform.forward * moveZ;

        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
