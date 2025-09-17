using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Playables;


public class lookAtTable : MonoBehaviour, IPointerClickHandler
{
    public PlayableDirector director;
    public PlayableAsset forward;
    public PlayableAsset backwards;
    private bool clicked = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Object was clicked!", gameObject);
        // Your code to do something when the object is clicked
        if (!clicked)
        {
            clicked = true;
            director.Play(forward);
        }
        else
        {
            clicked = false;
            director.Play(backwards);
        }
        
    }
}
