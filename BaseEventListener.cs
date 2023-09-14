using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;

public class BaseEventListener<TEvent, TListener> : MonoBehaviour
     where TEvent : BaseEvent<TEvent, TListener>
     where TListener : BaseEventListener<TEvent, TListener>
{
    [SerializeField] TEvent baseEvent;
    UnityEvent unityEvent = new();

    AsyncOperationHandle<TEvent> handle;

    void Awake()
    {
        Debug.Log($"{name}: Running Awake method...");

        handle = Addressables.LoadAssetAsync<TEvent>("Event");
        handle.WaitForCompletion();

        baseEvent = handle.Result;

        Debug.Log($"{name}: Awake method completed. baseEvent: {baseEvent.name}");
    }


    void OnEnable()
    {
        if (baseEvent == null)
            Debug.Log($"{name}: Base Event is null! Expected of type: {typeof(TEvent)}");

        Debug.Log($"{name}: Sanity Check: {baseEvent.name}");

        baseEvent.Register((TListener)this);
    }

    void OnDisable()
    {
        baseEvent.Unregister((TListener)this);
    }

    public void AddListener(UnityAction call)
    {
        unityEvent.AddListener(call);
    }

    public void RemoveListener(UnityAction call)
    {
        unityEvent.RemoveListener(call);
    }

    public void Invoke()
    {
        unityEvent.Invoke();
    }

#if UNITY_EDITOR
    void Reset()
    {
        var handle = Addressables.LoadAssetAsync<TEvent>("Event");

        handle.Completed += (AsyncOperationHandle<TEvent> completedHandle) =>
        {
            baseEvent = completedHandle.Result;
        };
    }
#endif
}

public class BaseEventListener<TEvent, TListener, T1> : MonoBehaviour
     where TEvent : BaseEvent<TEvent, TListener, T1>
     where TListener : BaseEventListener<TEvent, TListener, T1>
{
    public TEvent baseEvent;
    UnityEvent<T1> unityEvent = new();

    AsyncOperationHandle<TEvent> handle;

    void Awake()
    {
        Debug.Log($"{name}: Running Awake method...");

        handle = Addressables.LoadAssetAsync<TEvent>("Event");
        handle.WaitForCompletion();

        baseEvent = handle.Result;
        Debug.Log($"{name}: Awake method completed. baseEvent: {baseEvent.name}");
    }

    void OnEnable()
    {
        if (baseEvent == null)
            Debug.Log($"{name}: Base Event is null! Expected of type: {typeof(TEvent)}");

        Debug.Log($"{name}: Sanity Check: {baseEvent.name}");

        baseEvent.Register((TListener)this);
    }

    void OnDisable()
    {
        baseEvent.Unregister((TListener)this);
    }

    public void AddListener(UnityAction<T1> call)
    {
        unityEvent.AddListener(call);
    }

    public void RemoveListener(UnityAction<T1> call)
    {
        unityEvent.RemoveListener(call);
    }

    public void Invoke(T1 item)
    {
        unityEvent.Invoke(item);
    }

#if UNITY_EDITOR
    void Reset()
    {
        var handle = Addressables.LoadAssetAsync<TEvent>("Event");

        handle.Completed += (AsyncOperationHandle<TEvent> completedHandle) =>
        {
            baseEvent = completedHandle.Result;
        };
    }
#endif
}

public class BaseEventListener<TEvent, TListener, T1, T2> : MonoBehaviour
     where TEvent : BaseEvent<TEvent, TListener, T1, T2>
     where TListener : BaseEventListener<TEvent, TListener, T1, T2>
{
    public TEvent baseEvent;
    UnityEvent<T1, T2> unityEvent = new();

    AsyncOperationHandle<TEvent> handle;

    void Awake()
    {
        Debug.Log($"{name}: Running Awake method...");

        handle = Addressables.LoadAssetAsync<TEvent>("Event");
        handle.WaitForCompletion();

        baseEvent = handle.Result;

        Debug.Log($"{name}: Awake method completed. baseEvent: {baseEvent.name}");
    }

    void OnEnable()
    {
        if (baseEvent == null)
            Debug.Log($"{name}: Base Event is null! Expected of type: {typeof(TEvent)}");

        Debug.Log($"{name}: Sanity Check: {baseEvent.name}");

        baseEvent.Register((TListener)this);
    }

    void OnDisable()
    {
        baseEvent.Unregister((TListener)this);
    }

    public void AddListener(UnityAction<T1, T2> call)
    {
        unityEvent.AddListener(call);
    }

    public void RemoveListener(UnityAction<T1, T2> call)
    {
        unityEvent.RemoveListener(call);
    }

    public void Invoke(T1 item1, T2 item2)
    {
        unityEvent.Invoke(item1, item2);
    }

#if UNITY_EDITOR
    void Reset()
    {
        var handle = Addressables.LoadAssetAsync<TEvent>("Event");

        handle.Completed += (AsyncOperationHandle<TEvent> completedHandle) =>
        {
            baseEvent = completedHandle.Result;
        };
    }
#endif
}