using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    public float Speed = 10f;
    public Vector3 Jump = new Vector3(0, 5f, 0);
    public bool IsJumping = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        //facon de bouger le joueur
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            if (!IsJumping)
            {
                rb.AddForce(Jump, ForceMode.Impulse);
                IsJumping = true;
            }
        }


        //limite de mouvement sur l'axe Y
        if (transform.position.x <= -15)
        {
            transform.position = new Vector3(-15, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        if (transform.position.x >= 3)
        {
            transform.position = new Vector3(3, gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //approbation de sauter
        if (collision.gameObject.tag == "Ground")
        {
            IsJumping = false;
        }
    }
}
