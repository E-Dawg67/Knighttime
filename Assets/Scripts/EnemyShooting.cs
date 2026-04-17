using UnityEngine;
using UnityEngine.AI;

public class EnemyShooter : MonoBehaviour
{
    private Transform playerTarget;
    private NavMeshAgent agent;
    public GameObject soul;
    void Start()
    {
        GameObject playerObject = GameObject.Find("Main Camera");
        agent = this.gameObject.GetComponent<NavMeshAgent>();
        if (playerObject != null)
        {
            playerTarget = playerObject.transform;
        }
    }

    void FixedUpdate()
    {
        if (playerTarget != null)
        {
            Vector3 targetPosition = playerTarget.position;
            targetPosition.y = transform.position.y;
            agent.SetDestination(targetPosition);
            transform.LookAt(targetPosition);
            transform.Rotate(-90f, 0f, 90f);
        }
    }
    public void dropSoul()
    {
        Instantiate(soul,transform.position + new Vector3(0,2f,0),transform.rotation);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "MainCamera")
        {
            GameObject.Find("GameManager").GetComponent<UIStuffs>().loseHealth();
        }
    }
}