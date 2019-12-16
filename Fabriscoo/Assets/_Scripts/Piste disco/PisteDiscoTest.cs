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
    public MeshRenderer[] EmissiveMeshes;
    public int CubeNumbers = 0;
    int getArrayElements;
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
   
    //etape 2: obtenir 10 éléments aléatoire du tableau meshes
    public void RandomSequence()
    {
        //parcours 1 à 1 les éléments de mon tableau meshes et sélectionne 10 éléments aléatoire (int i = 10)
        for (int i = CubeNumbers; i < 0; i--)
        {
            getArrayElements = Random.Range(0, meshes.Length -1);                     
            Debug.Log(getArrayElements);
            
            

        }        
    }
    //étape 3: sauvegarder les 10 éléments dans un autre tableau
    public void GetIntToArray()
    {
        
    }

    /*
    [System.Serializable]
    public class Sequence
    {
        public MeshRenderer[] EmissiveMeshes;       


    }
    
    */
}


