using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : MonoBehaviour, IActivatable
{

    [SerializeField]
    private string nameText;

    [TextArea(15, 10)]
    [SerializeField]
    private string descriptionText;

    private MeshRenderer meshRenderer;
    private InventoryMenu inventoryMenu;
    private Collider col;

    private AudioSource audioSource;

    public string NameText
    {
        get
        { return nameText;}
    }

    public string DescriptionText//Public Description of this object
    {
        get
        { return descriptionText; }
    } 

    private void Start()
    {
        inventoryMenu = FindObjectOfType<InventoryMenu>();
        meshRenderer = GetComponent<MeshRenderer>();
        col = GetComponent<Collider>();

        audioSource = GetComponent<AudioSource>();
    }
    public void DoActivate()
    {
        inventoryMenu.PlayerInventory.Add(this);

        // Doing this rather than destroy because our Inventory menu still needs
        // to know about this object even though it has been collected and 
        // removed from the 3D world.
        // Also, if you wanted to add sound effects here,
        // and we destroy before the sfx are done, it will not sound correct.
        // Just like how coin worked in our 2D project!

        audioSource.PlayDelayed(0);
        meshRenderer.enabled = false;
        col.enabled = false;        
    }
}