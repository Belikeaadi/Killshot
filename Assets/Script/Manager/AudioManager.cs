using UnityEngine;

public class AudioManager : MonoBehaviour
{
    #region AUDIO SINGLETON
    private static AudioManager instance;
    public static AudioManager Instance {  get { return instance; } }
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }
    #endregion

    public AudioSource audioSource;
    public AudioClip[] clips;

    public void PlayEnemyAlert()
    {
        audioSource.clip = clips[0];
        audioSource.Play();
        audioSource.loop = true;
        Debug.Log("Enemy Alert sound play");
    }
    public void StopEnemyAlert()
    {
        audioSource.clip = clips[0];
         audioSource.Stop();
        audioSource.loop = false;
        Debug.Log("Enemy Alert sound stop");
    }
    public void PlayEnemyExplosion()
    {
        audioSource.clip = clips[1];
        audioSource.Play();
        audioSource.loop = false;
        Debug.Log("Enemy Explosion sound Play");
    }
    public void StopEnemyExplosion()
    {
        audioSource.clip = clips[1];
        audioSource.Stop();
        audioSource.loop = false;
        Debug.Log("Enemy Explosion sound stop");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("sound play");
            audioSource.clip = clips[2];
            audioSource.Play();
            audioSource.loop = true;
        }
        if (Input.GetKeyUp(KeyCode.M))
        {
            audioSource.clip = clips[2];
            audioSource.Stop();
            Debug.Log("sound Stop");
            audioSource.loop = false;
        }
    }
}
