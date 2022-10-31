using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class EndArea : MonoBehaviour
{

    public GameObject player;
    public Material waitingMaterial;
    public Material finishedMaterial;
    public int nextLevelIndex = 1;

    void Start()
    {
        this.gameObject.GetComponent<MeshRenderer>().material = waitingMaterial;  
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == player)
        {
            this.gameObject.GetComponent<MeshRenderer>().material = finishedMaterial;
        }
        Task.Delay(3000).ContinueWith(t => NextScene());
    }

    private void NextScene()
    {
        SceneManager.LoadScene(nextLevelIndex);
    }
}
