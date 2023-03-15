using System.Data;
using System.Linq;
using UnityEngine;

public class GemsScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool onDiamond = false;

    private GameObject terrain;
    private GameObject[] prefablist;

    void Start()
    {
        terrain = GameObject.Find("Plane");
        Debug.Log("enterscript");

        prefablist = Resources.LoadAll<GameObject>("Gems");

    }



    async void OnCollisionEnter(Collision collision)
    {



        Debug.Log(collision.articulationBody);
        if (prefablist.Where(x => x.tag == collision.gameObject.tag).FirstOrDefault())
        {

            GetComponent<DanceScript>().setdance(false);
            if (collision.gameObject.tag == "Gem-danse")
            {

                GetComponent<DanceScript>().setdance(true);
            }

            string tagtest = collision.gameObject.tag;

            Destroy(collision.gameObject);


            var gems = Instantiate(prefablist.Where(x => x.tag == tagtest).FirstOrDefault(), terrain.transform); ; gems.transform.position = new Vector3(Random.Range(terrain.transform.Find("murAvant").transform.localPosition.x - 1, terrain.transform.Find("murArriere").transform.localPosition.x + 1), terrain.transform.localPosition.y + 1, UnityEngine.Random.Range(terrain.transform.Find("murDroit").transform.localPosition.z - 1, terrain.transform.Find("murGauche").transform.localPosition.z + 1));
            Debug.Log(gems.transform.position);



        }
    }



}



