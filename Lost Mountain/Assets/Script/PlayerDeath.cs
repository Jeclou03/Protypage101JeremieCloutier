using System.Collections;
using UnityEngine;
public class PlayerDeath : MonoBehaviour
{
    #region Variables
    public int MaxBar = 1000;
    public int CurrentBar;
    public bool CanStart;
    public OxygenBar UiBar;
    public Player CanWalk;

    public Animator animator;
    public AudioSource audioSource;

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
        audioSource = GetComponent<AudioSource>();
        rb = this.GetComponent<Rigidbody>();
        CanWalk = this.GetComponent<Player>();
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
        // mort du joueur et destruction du gameobject
        if (canDie == true)
        {
            Time.timeScale = 0;
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // remise au max de l oxygene avec les collectibles 
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
            gameObject.GetComponent<Player>().FlakeInstance.transform.parent = null;
            CanWalk.CanWalk = false;
            audioSource.mute = true;
            animator.SetTrigger("Die");
            rb.constraints = RigidbodyConstraints.FreezePosition;
            StartCoroutine(PlayerDeleted());
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
            gameObject.GetComponent<Player>().FlakeInstance.transform.parent = null;
            CanWalk.CanWalk = false;
            audioSource.mute = true;
            animator.SetTrigger("Die");
            rb.constraints = RigidbodyConstraints.FreezePosition;
            StartCoroutine(PlayerDeleted());
        }
    }

    IEnumerator PlayerDeleted()
    {
        yield return new WaitForSeconds(5f);
        canDie = true;
        GameOverMenu.Instance.GameOver();
    }
        #endregion
}