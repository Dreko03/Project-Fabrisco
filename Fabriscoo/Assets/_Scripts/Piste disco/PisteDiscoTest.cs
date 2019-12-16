using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//décortiquer se dont j'ai besoin
//établir un plan de travail logique
//utiliser la documentation
//utiliser les debugger pour savoir dans quelle direction je vais

public class PisteDiscoTest : MonoBehaviour
{   
    public MeshRenderer[] meshes;
    //public Sequence[] sequences = new Sequence[0];

    void Start()
    {       
        GetAllChildrenMeshes();
        RandomSequence();
    }
    
    //etape 1: créer un tableau répertoriant tout les meshComponent (scripts) des cubes de ma piste disco
    public void GetAllChildrenMeshes()
    {
        meshes = this.gameObject.GetComponentsInChildren<MeshRenderer>();
        //meshes[0].enabled = false;      
        //int(Random.value * (meshes.Length - 1)      
    }

    public MeshRenderer[] EmissiveMeshes;
    //etape 2: obtenir 10 éléments aléatoire du tableau meshes
    public void RandomSequence()
    {

        meshes = this.gameObject.GetComponentsInChildren<MeshRenderer>();
        
        //parcours 1 à 1 les éléments de mon tableau meshes et sélectionne 10 éléments aléatoire (int i = 10)
        for (int i = 10; i > 0; i--)
        {
            Random.Range(0, meshes.Length -1);          
            Debug.Log(Random.Range(0, meshes.Length -1));  
            
            
            //étape 3: sauvegarder les 10 éléments dans un autre tableau
        }        
    }

    
    [System.Serializable]
    public class Sequence
    {
        public MeshRenderer[] EmissiveMeshes;       


    }
    

}


