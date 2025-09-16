using UnityEngine;
using UnityEngine.EventSystems;

public class ClickToAnimate : MonoBehaviour, IPointerClickHandler
{
    private Animator animator;

    // The name of the trigger parameter in the Animator Controller.
    // Making it public allows you to change it in the Inspector without editing the code.
    public string triggerName = "click";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        // Your code to do something when the object is clicked
        Debug.Log("Letter was clicked!", gameObject);
        if (animator != null)
        {
            // Send the trigger signal to the Animator Controller.
            animator.SetTrigger(triggerName);
        }
    }
}
