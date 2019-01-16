//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public GameCameraStateListenerComponent gameCameraStateListener { get { return (GameCameraStateListenerComponent)GetComponent(GameComponentsLookup.GameCameraStateListener); } }
    public bool hasGameCameraStateListener { get { return HasComponent(GameComponentsLookup.GameCameraStateListener); } }

    public void AddGameCameraStateListener(System.Collections.Generic.List<IGameCameraStateListener> newValue) {
        var index = GameComponentsLookup.GameCameraStateListener;
        var component = (GameCameraStateListenerComponent)CreateComponent(index, typeof(GameCameraStateListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGameCameraStateListener(System.Collections.Generic.List<IGameCameraStateListener> newValue) {
        var index = GameComponentsLookup.GameCameraStateListener;
        var component = (GameCameraStateListenerComponent)CreateComponent(index, typeof(GameCameraStateListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGameCameraStateListener() {
        RemoveComponent(GameComponentsLookup.GameCameraStateListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherGameCameraStateListener;

    public static Entitas.IMatcher<GameEntity> GameCameraStateListener {
        get {
            if (_matcherGameCameraStateListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameCameraStateListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameCameraStateListener = matcher;
            }

            return _matcherGameCameraStateListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddGameCameraStateListener(IGameCameraStateListener value) {
        var listeners = hasGameCameraStateListener
            ? gameCameraStateListener.value
            : new System.Collections.Generic.List<IGameCameraStateListener>();
        listeners.Add(value);
        ReplaceGameCameraStateListener(listeners);
    }

    public void RemoveGameCameraStateListener(IGameCameraStateListener value, bool removeComponentWhenEmpty = true) {
        var listeners = gameCameraStateListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveGameCameraStateListener();
        } else {
            ReplaceGameCameraStateListener(listeners);
        }
    }
}