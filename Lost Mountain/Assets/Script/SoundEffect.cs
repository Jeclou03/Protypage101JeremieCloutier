using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioClip[] playlist;
    public AudioSource audioSource;

    private int musicIndex = 0;
    private bool canWalk = true;

    void Start()
    {
        audioSource.clip = playlist[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying && canWalk == true)
        {
            playNextSong();
        }

        if (Input.GetKey(KeyCode.W))
        {
            audioSource.Stop();
            canWalk = false;
        }
    }

    void playNextSong()
    {
        musicIndex = (musicIndex + 1) % playlist.Length;
        audioSource.clip = playlist[musicIndex];
        audioSource.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //approbation de sauter
        if (collision.gameObject.tag == "Obstacles")
        {
            audioSource.Stop();
            canWalk = false;
        }

        //approbation de sauter
        if (collision.gameObject.tag == "Ground")
        {
            canWalk = true;
        }
    }
}
