using UnityEngine;

public class Magnus_Effect : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity, spin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //kick
            Kick();
        }
        //apply magnus effect
        ApplyMagnusEffect();

    }

    void Kick()
    {
        //崦Ш团得т凰意∨
        rb.linearVelocity = velocity;

        //崦霖购团
        rb.angularVelocity = spin;
    }

    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity, rb.angularVelocity );

        rb.AddForce( magnusForce );
    }
}
