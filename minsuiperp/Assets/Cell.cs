
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    
    // Start is called before the first frame update
    [SerializeField]
    private Text _view = null;

    [SerializeField]
    private Cellstate _cellState = Cellstate.None;
    public Cellstate Cellstate
    {
        get => _cellState;
        set
        {
            _cellState = value;
            OneCellStateChanged();
        }
    }

    private void Start()
    {
        OneCellStateChanged();
       
    }
    private void OneCellStateChanged()
    {
        if(_view==null)
        {
            return;
        }
        if(_cellState==Cellstate.None)
        {
            _view.text = "";
        }
        else if(_cellState==Cellstate.Mine)
        {
            _view.text = "X";
            _view.color = Color.red;
        }
        else
        {
            _view.text = ((int)_cellState).ToString();
            _view.color = Color.blue;

        }
    }


}

