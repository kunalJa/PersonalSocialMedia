using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Playables;

public class InboxScript : MonoBehaviour, IPointerClickHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject letter;
    private PlayableDirector director;

    void Awake()
    {
        // Get the component reference in Awake, which is guaranteed to run before OnEnable.
        director = GetComponent<PlayableDirector>();
    }

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
        director.Play();
    }

    public void middleOfAnimation()
    {
        letter.SetActive(true);
    }
}
