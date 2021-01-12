using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text text;
    [Header("分數")]
    public static int score;
    [Header("得分")]
    public int add;
    [Header("進球音效")]
    public AudioClip soundIn;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent && other.transform.parent.tag == "圈圈")
        {
            other.transform.parent.tag = "Untagged";
            AddScore();
        }
    }
    private void AddScore()
    {
        score += add;
        text.text = score.ToString();
        aud.PlayOneShot(soundIn, Random.Range(1f, 2f));
    }


}
