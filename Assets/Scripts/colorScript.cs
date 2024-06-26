using UnityEngine;
using UnityEngine.UI;

public class colorScript : MonoBehaviour
{
    [SerializeField]
    public GameObject raspylitel;
    public GameObject raspylitel_right;
    public GameObject rychagzaslonki;
    public GameObject door;
    public GameObject rychagmasla;
    public GameObject kolba;
    public GameObject manometr;

    public Material materialred;
    public Material materiallightmetal;
    public Material mainmetal;
    public Material gold;
    public Material defaultglass;
    public Material metaldarkgrey;
    public Material blackmetal;
    public Material shkala;

   
    #region Колба
    public void ChangeKolbaColor()
    {
        var renderer = kolba.GetComponentsInChildren<Renderer>(true);
        foreach (var rend in renderer)
        {
            Debug.Log(rend.gameObject.name);
            if (rend.gameObject.name == "Cylinder028" || rend.gameObject.name == "Cylinder024" || rend.gameObject.name == "Cylinder026" ||  rend.gameObject.name == "Cylinder025"  || rend.gameObject.name == "Cylinder027" || rend.gameObject.name == "Line005")
            {
                rend.material.color = Color.yellow;
            }

        }

    }

    public void ChangeKolbaMaterial()
    {
        var renderer = kolba.GetComponentsInChildren<Renderer>(true);
        foreach (var rend in renderer)
        {
            Debug.Log(rend.gameObject.name);
            if (rend.gameObject.name == "Cylinder028")
            {
                rend.material = defaultglass;
            }
            if (rend.gameObject.name == "Cylinder024" || rend.gameObject.name == "Cylinder025")
            {
                rend.material = mainmetal;
            }
            if (rend.gameObject.name == "Cylinder026" || rend.gameObject.name == "Cylinder027")
            {
                rend.material = materiallightmetal;
            }
            if (rend.gameObject.name == "Line005")
            {
                rend.material = gold;
            }
        }

    }
    #endregion

    #region Распылитель
    public void ChangeRaspylitelColor()
    {
        var renderer = raspylitel.GetComponentsInChildren<Renderer>(true);
        foreach (var rend in renderer)
        {
            Debug.Log(rend.gameObject.name);
            if (rend.gameObject.name == "Cylinder035" || rend.gameObject.name == "Line007")
            {
                rend.material.color = Color.yellow;
            }

        }

    }
    public void ChangeRaspylitelMaterial()
    {
        var renderer = raspylitel.GetComponentsInChildren<Renderer>(true);
        foreach (var rend in renderer)
        {
            Debug.Log(rend.gameObject.name);
            if (rend.gameObject.name == "Cylinder035" || rend.gameObject.name == "Line007")
            {
                rend.material = materialred;
            }
        }
    }
    #endregion

    #region Распылитель (правый)
    public void ChangeRaspylitelRightColor()
    {
        var renderer = raspylitel_right.GetComponentsInChildren<Renderer>(true);
        foreach (var rend in renderer)
        {
            Debug.Log(rend.gameObject.name);
            if (rend.gameObject.name == "Cylinder036" || rend.gameObject.name == "Line008")
            {
                rend.material.color = Color.yellow;
            }

        }

    }
    public void ChangeRaspylitelRightMaterial()
    {
        var renderer = raspylitel_right.GetComponentsInChildren<Renderer>(true);
        foreach (var rend in renderer)
        {
            Debug.Log(rend.gameObject.name);
            if (rend.gameObject.name == "Cylinder036" || rend.gameObject.name == "Line008")
            {
                rend.material = materialred;
            }
        }
    }
    #endregion

    #region Рычаг заслонки
    public void ChangeRychagColor()
    {
        var renderer = rychagzaslonki.GetComponentsInChildren<Renderer>(true);
        foreach (var rend in renderer)
        {
            Debug.Log(rend.gameObject.name);
            if (rend.gameObject.name == "Cylinder02" || rend.gameObject.name == "Cylinder01" || rend.gameObject.name == "Cylinder063" || rend.gameObject.name == "Cylinder062" || rend.gameObject.name == "Arc002")
            {
                rend.material.color = Color.yellow;
            }

        }

    }

    public void ChangeRychagMaterial()
    {
        var renderer = rychagzaslonki.GetComponentsInChildren<Renderer>(true);
        foreach (var rend in renderer)
        {
            Debug.Log(rend.gameObject.name);
            if (rend.gameObject.name == "Cylinder02" || rend.gameObject.name == "Cylinder01" || rend.gameObject.name == "Cylinder062")
            {
                rend.material = metaldarkgrey;
            }
            if (rend.gameObject.name == "Cylinder063" || rend.gameObject.name == "Arc002")
            {
                rend.material = materiallightmetal;
            }
        }

    }
    #endregion

    #region Двери топки
    public void ChangeDoorColor()
    {
        var renderer = door.GetComponentsInChildren<Renderer>(true);
        foreach (var rend in renderer)
        {
            Debug.Log(rend.gameObject.name);
            if (rend.gameObject.name == "door-left" || rend.gameObject.name == "door-right")
            {
                rend.material.color = Color.yellow;
            }

        }

    }

    public void ChangeDoorMaterial()
    {
        var renderer = door.GetComponentsInChildren<Renderer>(true);
        foreach (var rend in renderer)
        {
            Debug.Log(rend.gameObject.name);
            if (rend.gameObject.name == "door-left" || rend.gameObject.name == "door-right")
            {
                rend.material = materiallightmetal;
            }
        }

    }
    #endregion

    #region Рычаг подачи масла
    public void ChangeRychagMaslaColor()
    {
        var renderer = rychagmasla.GetComponentsInChildren<Renderer>(true);
        foreach (var rend in renderer)
        {
            Debug.Log(rend.gameObject.name);
            if (rend.gameObject.name == "Cylinder066" || rend.gameObject.name == "Cylinder068" || rend.gameObject.name == "Cylinder069" || rend.gameObject.name == "Sphere005" || rend.gameObject.name == "Torus003" || rend.gameObject.name == "Line017")
            {
                rend.material.color = Color.yellow;
            }

        }

    }

    public void ChangeRychagMaslaMaterial()
    {
        var renderer = rychagmasla.GetComponentsInChildren<Renderer>(true);
        foreach (var rend in renderer)
        {
            Debug.Log(rend.gameObject.name);
            if (rend.gameObject.name == "Torus003" || rend.gameObject.name == "Cylinder069" || rend.gameObject.name == "Line017")
            {
                rend.material = gold;
            }
            if (rend.gameObject.name == "Cylinder066" || rend.gameObject.name == "Cylinder068" || rend.gameObject.name == "Sphere005")
            {
                rend.material = blackmetal;
            }
        }

    }
    #endregion

    #region Манометр
    public void ChangeManometrColor()
    {
        var renderer = manometr.GetComponentsInChildren<Renderer>(true);
        foreach (var rend in renderer)
        {
            Debug.Log(rend.gameObject.name);
            if (rend.gameObject.name == "Cylinder006" || rend.gameObject.name == "Arrow" || rend.gameObject.name == "Sphere006" || rend.gameObject.name == "Line001")
            {
                rend.material.color = Color.yellow;
            }

        }

    }

    public void ChangeManometrMaterial()
    {
        var renderer = manometr.GetComponentsInChildren<Renderer>(true);
        foreach (var rend in renderer)
        {
            Debug.Log(rend.gameObject.name);
            if (rend.gameObject.name == "Line001")
            {
                rend.material = gold;
            }
            //if (rend.gameObject.name == "Cylinder005")
            //{
            //    rend.material = materiallightmetal;
            //}
            if (rend.gameObject.name == "Cylinder006")
            {
                rend.material = shkala;
            }
            if (rend.gameObject.name == "Arrow" || rend.gameObject.name == "Sphere006")
            {
                rend.material = blackmetal;
            }
        }

    }
    #endregion
}
