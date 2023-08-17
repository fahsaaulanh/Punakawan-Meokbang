using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class AudioButtonSetting : MonoBehaviour
{
    public static UnityAction<bool> OnToggleBgmClick;
    public static UnityAction<bool> OnToggleSoundCLick;

    [SerializeField] private Button _bgmButton;
    [SerializeField] private Vector3 OnPos, OffPos;
    [SerializeField] private GameObject _handler;
    [SerializeField] private Slider _volumeControl;
    [SerializeField] private AudioData _audioData;
    [SerializeField] private AudioSetting _audioSetting;
    private bool _isBgmMute;

    [SerializeField]
    private enum _buttonType
    {
        ToggleBgm,
        ToggleSound
    }

    private void Start()
    {
        Init();
        _bgmButton.onClick.AddListener(ToggleBgm);

    }

    private void FixedUpdate()
    {
        _audioSetting.Volume = _volumeControl.value;
    }

    private void Init()
    {
        _isBgmMute = _audioSetting.IsBgmMuted;

        if (_isBgmMute)
        {
            _handler.GetComponent<RectTransform>().anchoredPosition = OffPos;
        }
        else
        {
            _handler.GetComponent<RectTransform>().anchoredPosition = OnPos;
        }

        _volumeControl.value = _audioSetting.Volume;
    }

    private void SaveVolumeValue()
    {
        _audioSetting.Volume = _volumeControl.value;
    }

    private void ToggleBgm()
    {
        _isBgmMute = !_isBgmMute;
        _audioSetting.IsBgmMuted = _isBgmMute;
        OnToggleBgmClick?.Invoke(_isBgmMute);
        if (_isBgmMute)
        {
            _handler.GetComponent<RectTransform>().anchoredPosition = OffPos;
        }
        else
        {
            _handler.GetComponent<RectTransform>().anchoredPosition = OnPos;
        }

    }


}
