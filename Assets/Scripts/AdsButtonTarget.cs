using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GreedyGame.Runtime;
using UnityEngine.UI;

public class AdsButtonTarget : MonoBehaviour
{
    Button AdsImage;
    public Texture assignedTexture;
    public string unitId = null;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("UnityGG Canvas renderer Start");
        Sprite sprite = this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite;
        GreedyGameAgent.Instance.registerGameObject(this.gameObject, sprite.texture, "float-4056", delegate (string unitID, Texture2D assignedTexture, bool isBranded) {
            if (assignedTexture != null)
            {
                Debug.Log("UnityGG Canvas renderer Delegate called inside custom renderer");
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = Sprite.Create(assignedTexture, sprite.rect, sprite.pivot);
                Debug.Log("UnityGG Canvas Get Componet object");
                /**
                  *TODO: Apply assigned Texture to the game object. 
                The assigned texture can be the branded texture, the default texture or a transparent texture.
                 A transparent texture is returned in case you pass the default texture as null.
                  **/
            }
            else
            {
                Debug.Log("UnityGG Canvas renderer Not Found");
            }
            if (!isBranded)
            {
                Debug.Log("UnityGG Canvas renderer branded texture not found");
                /**
                  *TODO: isBranded boolean states whether the assignedTexture returned inside the delegate is branded or not.
                 If needed you can use this boolean to disable or enable gameobjects.
                  **/
            }
        });


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDestroy()
    {
        Debug.Log("Calling unregister : ");
        GreedyGameAgent.Instance.unregisterGameObject(this.gameObject);
    }
}
