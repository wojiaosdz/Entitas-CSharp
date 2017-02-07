//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public NameComponent name { get { return (NameComponent)GetComponent(GameComponentsLookup.Name); } }
    public bool hasName { get { return HasComponent(GameComponentsLookup.Name); } }

    public void AddName(string newValue) {
        var component = CreateComponent<NameComponent>(GameComponentsLookup.Name);
        component.value = newValue;
        AddComponent(GameComponentsLookup.Name, component);
    }

    public void ReplaceName(string newValue) {
        var component = CreateComponent<NameComponent>(GameComponentsLookup.Name);
        component.value = newValue;
        ReplaceComponent(GameComponentsLookup.Name, component);
    }

    public void RemoveName() {
        RemoveComponent(GameComponentsLookup.Name);
    }
}