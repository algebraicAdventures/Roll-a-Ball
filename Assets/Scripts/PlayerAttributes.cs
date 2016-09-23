using UnityEngine;
using UnityEngine.UI;

public class PlayerAttributes : MonoBehaviour
{

    public Text countText;
    public Text winText;
    private int count;

    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
            gameObject.GetComponent<AudioController>().PlayNext();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 9)
        {
            winText.text = "M U S I C";
        }
    }
}
