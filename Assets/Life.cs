using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] float life = 100f;

    private void OnGUI()
    {
        if(GUILayout.Button("Take Damage"))
        {
            TakeDamage();
        }
    }

    public void TakeDamage()
    {
        life -= 10;
        string log = $"current life is :{life}";
        Debug.Log(log);
        if (life <= 0) Destroy(this.gameObject);
    }

}
