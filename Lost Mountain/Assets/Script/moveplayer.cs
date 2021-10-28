using UnityEngine;

public class moveplayer : MonoBehaviour
{
    #region
    public Vector3 Jump = new Vector3(0, 5f, 0);
    public float Speed = 10f;
    public bool IsJumping = false;

    #endregion
    private playerhealth playerHealth;
    private Rigidbody rbPlayer;
    //--------------------------------------------
    private void Start()
    {
        rbPlayer = this.GetComponent<Rigidbody>();
        playerHealth = GetComponent<playerhealth>();
    }
    void Update()
    {  
        if (playerHealth.CurrentOxygen > 0)
        {
            //si le joueur est encore en vie: facon de bouger le joueur
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);

            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.left * Speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.right * Speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.Space))
            {
                if (!IsJumping)
                {
                    rbPlayer.AddForce(Jump, ForceMode.Impulse);
                    IsJumping = true;
                }
            }
        }
        //limite de mouvement sur l'axe Y
        if(transform.position.x <=-15)
        {
            transform.position = new Vector3(-15, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        
        if(transform.position.x >= 3) 
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

