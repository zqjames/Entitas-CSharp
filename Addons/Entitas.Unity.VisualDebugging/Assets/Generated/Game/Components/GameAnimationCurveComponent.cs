//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public AnimationCurveComponent animationCurve { get { return (AnimationCurveComponent)GetComponent(GameComponentsLookup.AnimationCurve); } }
    public bool hasAnimationCurve { get { return HasComponent(GameComponentsLookup.AnimationCurve); } }

    public void AddAnimationCurve(UnityEngine.AnimationCurve newAnimationCurve) {
        var component = CreateComponent<AnimationCurveComponent>(GameComponentsLookup.AnimationCurve);
        component.animationCurve = newAnimationCurve;
        AddComponent(GameComponentsLookup.AnimationCurve, component);
    }

    public void ReplaceAnimationCurve(UnityEngine.AnimationCurve newAnimationCurve) {
        var component = CreateComponent<AnimationCurveComponent>(GameComponentsLookup.AnimationCurve);
        component.animationCurve = newAnimationCurve;
        ReplaceComponent(GameComponentsLookup.AnimationCurve, component);
    }

    public void RemoveAnimationCurve() {
        RemoveComponent(GameComponentsLookup.AnimationCurve);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherAnimationCurve;

    public static Entitas.IMatcher<GameEntity> AnimationCurve {
        get {
            if(_matcherAnimationCurve == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AnimationCurve);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAnimationCurve = matcher;
            }

            return _matcherAnimationCurve;
        }
    }
}