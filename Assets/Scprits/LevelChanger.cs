using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

    public string next_level;

	void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(next_level);
    }
}
