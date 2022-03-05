using UnityEngine;

public class Move : MonoBehaviour
{
    #region Variable
    public float Speed = 10f;
    public float Bounce = 20f;
    public Vector3 Jump = new Vector3(0, 5f, 0);
    public Vector3 ImBouncing = new Vector3(0, 10f, 0);
    public bool IsJumping = false;
    public bool IsBouncing = false;
    public static Move Instance;
    public Player CanWalk;
    
    private Rigidbody rb;
    #endregion
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        CanWalk = GetComponent<Player>();

        if (Instance != null)
        {
            return;
        }
        Instance = this;
    }
    void Update()
    {
        if(CanWalk.CanWalk)
        {
            //facon de bouger le joueur
            //si le joueur a eu une collision avec un obstacle,il ne peut pas avancer
            if (IsBouncing == false)
            {
                transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            }
            

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * Speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * Speed * Time.deltaTime);
            }

            // contrainte de saut
            if (Input.GetKey(KeyCode.W))
            {
                if (!IsJumping && IsBouncing == false)
                {
                    rb.AddForce(Jump, ForceMode.Impulse);
                    IsJumping = true;
                }
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
            IsBouncing = false;
        }
        //approbation de bounce
        if (collision.gameObject.tag == "Obstacles")
        {
            rb.AddForce(ImBouncing, ForceMode.Impulse);
            transform.Translate(Vector3.back * Bounce * Time.deltaTime);
            IsBouncing = true;
        }
    }
}
