using UnityEngine;

public class Item : MonoBehaviour
{
    public float itemVelocity = 20f;
    private Rigidbody2D rig = null;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.AddForce(new Vector3(itemVelocity,itemVelocity,0f));
    }
    
    
    void Update()
    {
        
    }
}
