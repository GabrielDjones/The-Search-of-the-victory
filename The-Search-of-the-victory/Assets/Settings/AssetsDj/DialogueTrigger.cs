using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [TextArea(2, 5)]
    public string[] lines;

    private bool hasInteracted = false;

    public void Interact()
    {
        if (hasInteracted) return;

        hasInteracted = true;
        PolicialTalk.Instance.StartDialogue(lines);
        
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("objeto"))
        {
            InventoryCode.Instance.AddInventory();
        }
    }
}
