using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class JayScript : MonoBehaviour
{
    #region PublicVar
    public int MaxBar = 1000;
    public int CurrentBar;
    public bool CanStart;
    public oxygenbar UiBar;
    public Player CanWalk;
    #endregion
    #region PrivateVar
    private bool canTake = true;
    private bool canDie = false;
    
    private Rigidbody rb;
    
    #endregion

    #region messages

    private void Awake()
    {
        CanStart = GetComponent<Move>();
    }
    void Start()
    {
        //Bar max en commancant le jeu
        CurrentBar = MaxBar;
        UiBar.SetMaxHealth(MaxBar);
        rb = this.GetComponent<Rigidbody>();
        CanWalk = this.GetComponent<Player>();
        //GameOver = this.GetComponent<Player>();
    }

    private void Update()
    {
        // Perde du fuel par seconde
        if (canTake == true)
        {
            TakeDamage(1);
            canTake = false;
            StartCoroutine(WaitToTake());
        }

        if (canDie == true)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // remise au max avec les collectibles 
        if (collision.gameObject.tag == "Collectible")
        {
            UiBar.SetMaxHealth(MaxBar);
            CurrentBar = MaxBar;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        // mort du joueur si collision avec la deathzone
        if (collider.gameObject.tag == "DeathZone")
        {
            StartCoroutine(Death());
        }
    }

    #endregion

    #region methodes

    IEnumerator WaitToTake()
    {
        yield return new WaitForSeconds(0.02f);
        canTake = true;
    }

    void TakeDamage(int damage)
    {
        CurrentBar -= damage;
        UiBar.SetHealth(CurrentBar);
        //suffocation du joueur
        if(CurrentBar <= 0)
        {
            rb.constraints = RigidbodyConstraints.None;
            transform.Translate(Vector3.forward * -10f * Time.deltaTime);
            gameObject.GetComponent<Player>().FlakeInstance.transform.parent = null;
            CanWalk.CanWalk = false;
            StartCoroutine(Death());
            
        }
    }

    IEnumerator Death()
    {
        yield return new WaitForSeconds(5f);
        canDie = true;
        GameOverMenu.Instance.GameOver();
    }
        #endregion
}