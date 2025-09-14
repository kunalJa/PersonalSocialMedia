using UnityEngine;
using UnityEngine.EventSystems;

public class InboxScript : MonoBehaviour, IPointerClickHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject letter;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // Your code to do something when the object is clicked
        Debug.Log("Object was clicked!", gameObject);
        letter.SetActive(true);
    }
}
