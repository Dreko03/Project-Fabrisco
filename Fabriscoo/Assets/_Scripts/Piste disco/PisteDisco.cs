using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PisteDisco : MonoBehaviour
{

    public Sequence[] sequences = new Sequence[4];
    public int currentSequence = 0;   

    void Start()
    {
        foreach (Sequence sequence in sequences)
        {
            sequence.TurnOff();
        }
        sequences[currentSequence].TurnOn();
    }
    
    void Update()
    {
        
    }

    [System.Serializable]
    public class Sequence
    {
        public Light[] cells;

        public void TurnOff()
        {
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i].enabled = false;
            }
        }

        public void TurnOn()
        {
            foreach (Light light in cells)
            {
                light.enabled = true;
            }
        }
    }
}


