using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Activator : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI multi;
    public bool create = false;
    public bool active = false;
    public GameObject instNote = null;
    private GameObject note = null;
    public KeyCode k = KeyCode.A;
    private void Start()
    {
        if (create)
        {
            Instantiate(instNote, this.transform.position, Quaternion.identity);
        }
    }
    private void Update()
    {
        if (create)
        {
            if (Input.GetKeyDown(k))
            {
                Instantiate(instNote, this.transform.position, Quaternion.identity);
            }
        }
        else
        {
            if (active && Input.GetKeyDown(k))
            {
                Destroy(note);
                multi.text = note.GetComponent<Note>().m.ToString();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (create == false)
        {
            active = true;
            note = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        active = false;
    }
}
