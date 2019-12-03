using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PisteDisco : MonoBehaviour
{    
    public Sequence[] sequences = new Sequence[2];
    public int currentSequence = 0;   

    void Start()
    {
        foreach (Sequence sequence in sequences)
        {
            sequence.TurnOffSequences();
        }
        StartCoroutine(SwitchSequences(1.5f));
    }

    IEnumerator SwitchSequences(float delay)
    {
        yield return new WaitForSeconds(delay);       
        sequences[currentSequence].TurnOn();
        yield return new WaitForSeconds(delay);
        currentSequence = 1;
        sequences[currentSequence].TurnOn();
        yield return new WaitForSeconds(delay);
        currentSequence = 2;
        sequences[currentSequence].TurnOn();
    }

    void Update()
    {
        
    }

    [System.Serializable]
    public class Sequence
    {
        public MeshRenderer[] cells;
        public Material[] materials;

        public void TurnOffSequences()
        {
            for (int i = 0; i < cells.Length; i++)
            {                             
                cells[i].material = materials[0];              
            }
        }

        public void TurnOn()
        {
            foreach (MeshRenderer light in cells)
            {
                for (int x = 0; x < materials.Length; x++)
                {                   
                    light.material = materials[x];
                }               
            }
        }       
    }
}


