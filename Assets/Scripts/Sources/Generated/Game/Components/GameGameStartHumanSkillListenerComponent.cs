//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public GameStartHumanSkillListenerComponent gameStartHumanSkillListener { get { return (GameStartHumanSkillListenerComponent)GetComponent(GameComponentsLookup.GameStartHumanSkillListener); } }
    public bool hasGameStartHumanSkillListener { get { return HasComponent(GameComponentsLookup.GameStartHumanSkillListener); } }

    public void AddGameStartHumanSkillListener(System.Collections.Generic.List<IGameStartHumanSkillListener> newValue) {
        var index = GameComponentsLookup.GameStartHumanSkillListener;
        var component = (GameStartHumanSkillListenerComponent)CreateComponent(index, typeof(GameStartHumanSkillListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGameStartHumanSkillListener(System.Collections.Generic.List<IGameStartHumanSkillListener> newValue) {
        var index = GameComponentsLookup.GameStartHumanSkillListener;
        var component = (GameStartHumanSkillListenerComponent)CreateComponent(index, typeof(GameStartHumanSkillListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGameStartHumanSkillListener() {
        RemoveComponent(GameComponentsLookup.GameStartHumanSkillListener);
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

    static Entitas.IMatcher<GameEntity> _matcherGameStartHumanSkillListener;

    public static Entitas.IMatcher<GameEntity> GameStartHumanSkillListener {
        get {
            if (_matcherGameStartHumanSkillListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameStartHumanSkillListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameStartHumanSkillListener = matcher;
            }

            return _matcherGameStartHumanSkillListener;
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

    public void AddGameStartHumanSkillListener(IGameStartHumanSkillListener value) {
        var listeners = hasGameStartHumanSkillListener
            ? gameStartHumanSkillListener.value
            : new System.Collections.Generic.List<IGameStartHumanSkillListener>();
        listeners.Add(value);
        ReplaceGameStartHumanSkillListener(listeners);
    }

    public void RemoveGameStartHumanSkillListener(IGameStartHumanSkillListener value, bool removeComponentWhenEmpty = true) {
        var listeners = gameStartHumanSkillListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveGameStartHumanSkillListener();
        } else {
            ReplaceGameStartHumanSkillListener(listeners);
        }
    }
}