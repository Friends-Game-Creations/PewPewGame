
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5;
    private Vector3 direction;
    public Movement movement(Vector2 Direction){
        direction =  new Vector3 (Direction.x, 0, Direction.y);
        Execute();
        return this;
    }
    public GameObject player;
    public void Execute(){
        direction = Vector3.Normalize(direction);
        Debug.Log(((speed * ((1/360) * gameObject.transform.rotation.y)) * Time.deltaTime * speed, 0, (speed * ((1/360) * gameObject.transform.rotation.y)*Time.deltaTime * speed)));
        Debug.Log(new Vector3 (direction.x * transform.forward.x, 0, direction.z * transform.forward.z));
        Vector3 Side = new Vector3 (transform.right.x, 0, transform.right.z) * direction.x;
        Vector3 Forward = new Vector3 (transform.forward.x , 0, transform.forward.z) * direction.z;
        Vector3 maindirection = Side + Forward;
        Vector3.Normalize(maindirection);
        gameObject.GetComponent<Rigidbody>().velocity = maindirection * speed * Time.deltaTime;
    }
}
